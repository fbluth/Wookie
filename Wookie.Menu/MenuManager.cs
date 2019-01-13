using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Wookie.Tools.Image;
using DevExpress.Images;

namespace Wookie.Menu.MenuManager
{
    public class MenuManager:IDisposable
    {
        #region Variables
        private Database.MenuDataContext context = null;
        private NavigationFrame navigationFrame = null;
        private AccordionControl accordionControl = null;

        private Dictionary<AccordionControlElement, Client> clients = new Dictionary<AccordionControlElement, Client>();
        
        private Bar statusBar;
        public delegate void ClientChangeEventHandler(Client sender);
        public event ClientChangeEventHandler ClientChanged;
        public event EventHandler SettingsClicked;
        private BarStaticItem barItemMessage = new BarStaticItem();
        private BarStaticItem barItemSelection= new BarStaticItem();
        private List<MenuItem> menuItems = null;
        private System.Data.SqlClient.SqlConnection sqlConnection;
        #endregion

        #region Constructor
        public MenuManager(System.Data.SqlClient.SqlConnection sqlConnection, NavigationFrame navigationFrame, AccordionControl accordionControl, Bar statusBar)
        {
            this.navigationFrame = navigationFrame;
            this.accordionControl = accordionControl;
            this.sqlConnection = sqlConnection;

            this.statusBar = statusBar;
            this.statusBar.AddItem(barItemMessage);
            this.statusBar.AddItem(barItemSelection);
        }
        #endregion

        #region Public Functions
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aceClient"></param>
        public void AddClients(AccordionControlElement aceClient)
        {
            // Lese aus der Datenbank alle Mandanten aus
            this.context = new Database.MenuDataContext(this.sqlConnection);
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
                    this.clients.Add(clientItem, new Client(client.PKClient, new SqlConnection(GetSqlConnectionStringBuilder(client).ConnectionString), client.Name));
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

            foreach (Database.tsysClientElement clientElement in query)
            {
                MenuItem menuItem = new MenuItem(clientElement.Name, clientElement.Image);

                menuItem.LoadAssembly(clientElement.Assemblyname, clientElement.Namespace);

                if (menuItem.Assembly != null)
                { 
                    menuItem.Assembly.SqlConnection = client.SqlConnection;
                    menuItem.Assembly.FKExternal = clientElement.FKExternal;
                    menuItem.Assembly.UniqueIdentifier = clientElement.UniqueIdentifier.HasValue ? clientElement.UniqueIdentifier.ToString() : "";

                    this.menuItems.Add(menuItem);
                }

                if (menuItem.LoadResult != MenuItem.AssemblyLoadResult.AssemblyMissing)
                {
                    menuItem.MenuItemClick += this.MenuItem_Click;
                    menuItem.StatusBarChanged += this.MenuItem_StatusBarChanged;
                    menuItem.SelectionChanged += this.MenuItem_SelectionChanged;
                }

                if (element == null)
                {
                    this.accordionControl.Elements.Add(menuItem.AccordionControlElement);
                }
                else
                {
                    element.Elements.Add(menuItem.AccordionControlElement);
                }

                int count = CreateMenu(client, clientElement.ID, menuItem.AccordionControlElement);
                if (count == 0) menuItem.AccordionControlElement.Style = ElementStyle.Item;
            }

            return query.Count();
        }

        private void AddSettingsItem()
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
            aceSettings.Click += this.Settings_Click;

            this.accordionControl.Elements.Add(aceSettings);
        }

        private void AddMenu(Client client)
        {
            if (this.accordionControl == null) return;

            this.menuItems = new List<MenuItem>();

            this.accordionControl.BeginUpdate();
            this.accordionControl.Elements.Clear();

            this.context = new Database.MenuDataContext(this.sqlConnection);

            this.CreateMenu(client, null, null);
            this.AddSettingsItem();
            this.accordionControl.EndUpdate();

            if (this.menuItems.Count > 0) OnMenuItemClick(this.menuItems[0]);
        }

        private SqlConnectionStringBuilder GetSqlConnectionStringBuilder(Database.tsysClient client)
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
                SqlConnectionStringBuilder connBuilder = GetSqlConnectionStringBuilder(client);

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

        #region Handled Events
        private void MenuItem_Click(MenuItem sender)
        {
            this.OnMenuItemClick(sender);
        }

        private void OnMenuItemClick(MenuItem item)
        {
            if (item != null && item.NavigationPage != null)
            {
                if (!this.navigationFrame.Pages.Contains(item.NavigationPage))
                    this.navigationFrame.Pages.Add(item.NavigationPage);

                this.navigationFrame.SelectedPage = item.NavigationPage;

                item.Assembly?.Activate();
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

        private void MenuItem_SelectionChanged(SelectionEventArgs args)
        {
            if (this.menuItems == null) return;

            barItemSelection.Caption = args.Caption;

            foreach (MenuItem item in this.menuItems)
            {
                if (item.Assembly == null) continue;

                if (item.Assembly.UniqueIdentifier == args.Sender)
                {
                    item.Assembly.FKExternal = args.FKExternal;
                    item.Assembly.DetailUserControl = args.DetailUserControl;
                    item.Assembly.FKSelected = args.FKSelected;
                }
            }
        }

        private void MenuItem_StatusBarChanged(StatusBarEventArgs args)
        {
            barItemMessage.Caption = args.Text;
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