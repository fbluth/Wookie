using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Wookie.Tools.Image;
using DevExpress.Images;
using System.Drawing;

namespace Wookie.Menu.MenuManager
{
    public class MenuManager:IDisposable
    {
        #region Variables
        private Database.MenuDataContext context = null;
        private NavigationFrame navigationFrame = null;
        private Dictionary<AccordionControlElement, Client> clients = new Dictionary<AccordionControlElement, Client>();
        private AccordionControl accordionControl = null;
        private Bar statusBar;

        public delegate void ClientChangeEventHandler(Client sender);
        public delegate void CategoryChangeEventHandler(string caption, Image image);
        public event ClientChangeEventHandler ClientChanged;
        public event CategoryChangeEventHandler CategoryChanged;
        public event EventHandler SettingsClicked;
        #endregion

        #region Constructor
        public MenuManager(System.Data.SqlClient.SqlConnection sqlConnection, NavigationFrame navigationFrame, AccordionControl accordionControl, Bar statusBar)
        {
            this.navigationFrame = navigationFrame;
            this.accordionControl = accordionControl;
            this.context = new Database.MenuDataContext(sqlConnection);
            this.statusBar = statusBar;
        }
        #endregion

        #region Public Functions
        public void AddClients(AccordionControlElement aceClient)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery == null || clientQuery.Count() == 0) return;

            foreach (Database.tsysClient client in clientQuery)
            {
                AccordionControlElement clientItem = new AccordionControlElement()
                {
                    Text = client.Name,
                    Style = ElementStyle.Item                    
                };

                clientItem.ImageOptions.Image = Converter.GetImageFromBinary(client.Image);                
                clientItem.Click += Client_Click;

                if (this.TestConnection(client))
                {
                    this.clients.Add(clientItem, new Client(client.PKClient, new SqlConnection(GetSqlConnectionBuilder(client).ConnectionString), client.Name));
                }
                else
                {
                    // Falls Verbindung zur Datenbank nicht möglich ist, dann Item auf enabled = false setzen.
                    clientItem.Enabled = false;
                    clientItem.Text = client.Name + " (No connection to database)";
                }

                aceClient.Elements.Add(clientItem);
            }
            
            if (this.clients.Count() > 0)
            {
                Client client = clients.ToArray()[0].Value as Client;
                this.AddMenu(client);
                ClientChanged?.Invoke(client);
            }
        }
        #endregion

        #region Private Functions
        private int CreateMenu(Client client, Guid? id, AccordionControlElement element)
        {
            var query = from row in context.tsysClientElement
                        where row.FKClient == client.PKClient
                        select row;

            if (id != null)
                query = query.Where(s => s.ParentID == id.Value);
            else
                query = query.Where(s => s.ParentID == null);

            query = query.OrderBy( s => s.SortOrder);

            if (query == null || query.Count() == 0) return 0;

            foreach (Database.tsysClientElement row in query)
            {
                MenuItem menuItem = new MenuItem(row.Name, row.Image, row.Assemblyname, client.SqlConnection, row.FKExternal);
                menuItem.MenuItemClick += new MenuItem.MenuItemEventHandler(this.MenuItem_Click);
                menuItem.StatusBarChanged += MenuItem_StatusBarChanged;
                if (element == null)
                {
                    this.accordionControl.Elements.Add(menuItem.AccordionControlElement);
                }
                else
                {
                    element.Elements.Add(menuItem.AccordionControlElement);
                }

                int count = CreateMenu(client, row.ID, menuItem.AccordionControlElement);
                if (count == 0) menuItem.AccordionControlElement.Style = ElementStyle.Item;
            }

            return query.Count();
        }

        private void MenuItem_StatusBarChanged(StatusBarEventArgs args)
        {
            BarStaticItem barItem = new BarStaticItem();
            barItem.Caption = args.Text;
            this.statusBar.ClearLinks();
            this.statusBar.AddItem(barItem);
        }

        private void AddSettings()
        {
            AccordionControlElement aceSettings;
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();

            aceSettings = new AccordionControlElement
            {
                ControlFooterAlignment = AccordionItemFooterAlignment.Far,
                Expanded = true,
                Name = "aceSettings",
                Image = ImageResourceCache.Default.GetImage("images/setup/properties_32x32.png")
            };

            toolTipTitleItem1.Text = "Settings";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Modify general settings which apply to all instances.";
            toolTipTitleItem2.LeftIndent = 6;
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            aceSettings.SuperTip = superToolTip1;
            aceSettings.Text = "Settings";
            aceSettings.Click += new System.EventHandler(this.Settings_Click);

            this.accordionControl.Elements.Add(aceSettings);
        }

        private void AddMenu(Client client)
        {
            if (this.accordionControl == null) return;

            this.accordionControl.BeginUpdate();
            this.accordionControl.Elements.Clear();
            this.CreateMenu(client, null, null);
            this.AddSettings();
            this.accordionControl.EndUpdate();
        }

        private SqlConnectionStringBuilder GetSqlConnectionBuilder(Database.tsysClient client)
        {
            if (client == null) return null;

            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();

            if (client.Datasource != null) connBuilder.DataSource = client.Datasource;
            if (client.UserID != null) connBuilder.UserID = client.UserID;
            if (client.Password != null) connBuilder.Password = client.Password;
            if (client.InitialCatalog != null) connBuilder.InitialCatalog = client.InitialCatalog;
            if (client.FailoverPartner != null) connBuilder.FailoverPartner = client.FailoverPartner;

            if (client.Encrypt.HasValue) connBuilder.Encrypt = client.Encrypt.Value;
            if (client.PersistSecurityInfo.HasValue) connBuilder.PersistSecurityInfo = client.PersistSecurityInfo.Value;
            if (client.ConnectTimeout.HasValue) connBuilder.ConnectTimeout = client.ConnectTimeout.Value;
            if (client.ConnectRetryCount.HasValue) connBuilder.ConnectRetryCount = client.ConnectRetryCount.Value;
            if (client.ConnectRetryInterval.HasValue) connBuilder.ConnectRetryInterval = client.ConnectRetryInterval.Value;
            if (client.PacketSize.HasValue) connBuilder.PacketSize = client.PacketSize.Value;
            if (client.Pooling.HasValue) connBuilder.Pooling = client.Pooling.Value;

            return connBuilder;
        }

        private bool TestConnection(Database.tsysClient client)
        {
            try
            {
                SqlConnectionStringBuilder connBuilder = GetSqlConnectionBuilder(client);

                if (connBuilder != null)
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connBuilder.ConnectionString))
                    {
                        // Überprüfe ob eine Verbindung zur Datenbank möglich ist.
                        sqlConnection.Open();
                        sqlConnection.Close();

                        return true;                        
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Events
        private void MenuItem_Click(MenuItem sender)
        {
            if (sender != null && sender.NavigationPage != null)
            {
                if (!this.navigationFrame.Pages.Contains(sender.NavigationPage))
                    this.navigationFrame.Pages.Add(sender.NavigationPage);

                this.navigationFrame.SelectedPage = sender.NavigationPage;

                CategoryChanged?.Invoke(sender.Caption, sender.Image);
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsClicked?.Invoke(this, new EventArgs());
        }

        private void Client_Click(object sender, EventArgs e)
        {
            Client client = this.clients[(AccordionControlElement)sender] as Client;

            if (client == null) return;

            this.AddMenu(client);            

            this.ClientChanged?.Invoke(client);
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.context.Dispose();                    
                    this.clients.Clear();
                }

                // nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // große Felder auf Null setzen.
                this.navigationFrame = null;
                this.accordionControl = null;

                disposedValue = true;
            }
        }

        // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
        // ~MenuManager() {
        //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
        //   Dispose(false);
        // }

        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
