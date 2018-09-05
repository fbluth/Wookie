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
        private Database.MenuDataContext context = null;
        private NavigationFrame navigationFrame = null;
        private Dictionary<AccordionControlElement, Client> clientDictionary = new Dictionary<AccordionControlElement, Client>();
        private AccordionControl accordionControl = null;

        
        public delegate void ClientChangeEventHandler(Client sender);
        public event ClientChangeEventHandler ClientChanged;
        public event EventHandler SettingsClicked;


        public MenuManager(System.Data.SqlClient.SqlConnection sqlConnection, NavigationFrame navigationFrame, AccordionControl accordionControl)
        {
            this.navigationFrame = navigationFrame;
            this.accordionControl = accordionControl;
            this.context = new Database.MenuDataContext(sqlConnection);
        }

        public void AddClients(AccordionControlElement aceClient)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery == null || clientQuery.Count() == 0) return;

            foreach (Database.tsysClient client in clientQuery)
            {
                AccordionControlElement clientItem = new AccordionControlElement();
                clientItem.Text = client.Name;
                clientItem.ImageOptions.Image = Converter.GetImageFromBinary(client.Image);
                clientItem.Click += ClientItem_Click;
                clientItem.Style = ElementStyle.Item;
               
                try
                {
                    SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder
                    {
                        DataSource = client.Datasource,
                        UserID = client.UserID,
                        PersistSecurityInfo = client.PersistSecurityInfo.Value,
                        Password = client.Password,
                        InitialCatalog = client.InitialCatalog
                    };

                    SqlConnection sqlConnection = new SqlConnection(connBuilder.ConnectionString);

                    // Überprüfe ob eine Verbindung zur Datenbank möglich ist.
                    sqlConnection.Open();
                    sqlConnection.Close();

                    // Falls Verbindung möglich in Liste aufnehmen.
                    this.clientDictionary.Add(clientItem, new Client(client.PKClient, sqlConnection, client.Name));
                }
                catch
                {
                    // Falls Verbindung zur Datenbank nicht möglich ist, dann Item auf enabled = false setzen.
                    clientItem.Enabled = false;
                    clientItem.Text = client.Name + " (No connection to database)";
                }

                aceClient.Elements.Add(clientItem);
            }
            
            if (this.clientDictionary.Count() > 0)
            {
                ClientChanged?.Invoke((Client)clientDictionary.ToArray()[0].Value);
            }
        }

        private void ClientItem_Click(object sender, EventArgs e)
        {
            if (this.clientDictionary[(AccordionControlElement)sender] == null) return;

            ClientChanged?.Invoke((Client)this.clientDictionary[(AccordionControlElement)sender]);
        }

        public void AddSettings()
        {
            // Add Settings
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

        public void LoadMenu(Client client)
        {
            if (this.accordionControl == null) return;

            this.accordionControl.BeginUpdate();

            this.accordionControl.Elements.Clear();
            this.CreateMenu(client, null, null);

            this.accordionControl.EndUpdate();
        }

        private int CreateMenu(Client client, long? FKClientElement, AccordionControlElement element)
        {
            var query = from row in context.tsysClientElement
                        where row.FKClient == client.PKClient
                        select row;

            if (FKClientElement != null)
                query = query.Where(s => s.FKClientElement == FKClientElement.Value);
            else
                query = query.Where(s => s.FKClientElement == null);

            query = query.OrderBy( s => s.SortOrder);

            if (query == null || query.Count() == 0) return 0;

            foreach (Database.tsysClientElement row in query)
            {
                MenuItem menuItem = new MenuItem(row.Name, row.Image, row.Assemblyname, client.SqlConnection, row.FKExternal);
                menuItem.MenuItemClick += new MenuItem.MenuItemEventHandler(this.menuItemClick);
                
                if (element == null)
                {
                    this.accordionControl.Elements.Add(menuItem.AccordionControlElement);
                }
                else
                {
                    element.Elements.Add(menuItem.AccordionControlElement);
                }

                int count = CreateMenu(client, row.PKClientElement, menuItem.AccordionControlElement);
                if (count == 0) menuItem.AccordionControlElement.Style = ElementStyle.Item;
            }

            return query.Count();
        }

        private void menuItemClick(MenuItem sender)
        {
            if (sender.NavigationPage != null)
            {
                if (!this.navigationFrame.Pages.Contains(sender.NavigationPage))
                    this.navigationFrame.Pages.Add(sender.NavigationPage);
                this.navigationFrame.SelectedPage = sender.NavigationPage;
            }
            else
            {
                this.navigationFrame.SelectedPage = sender.NavigationPage;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            SettingsClicked?.Invoke(this, new EventArgs());
        }

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.context.Dispose();                    
                    this.clientDictionary.Clear();
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
