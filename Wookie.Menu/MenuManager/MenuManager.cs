using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using Wookie.Tools.Image;

namespace Wookie.Menu.MenuManager
{
    public class MenuManager:IDisposable
    {
        private ModulGroupCollection modulGroupCollection = null;
        private Database.MenuDataContext context = null;
        private NavigationFrame navigationFrame = null;
        private Dictionary<BarItem, Client> clientDictionary = new Dictionary<BarItem, Client>();
        private AccordionControl accordionControl = null;

        public event ClientChangeEventHandler ClientChanged;
        public event EventHandler SettingsClicked;

        public MenuManager(System.Data.SqlClient.SqlConnection sqlConnection, NavigationFrame navigationFrame, AccordionControl accordionControl)
        {
            this.modulGroupCollection = new ModulGroupCollection(this);
            this.navigationFrame = navigationFrame;
            this.accordionControl = accordionControl;
            context = new Database.MenuDataContext(sqlConnection);
        }

        public void AddClients(BarSubItem bsiClient)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery == null || clientQuery.Count() == 0) return;

            foreach (Database.tsysClient client in clientQuery)
            {
                BarButtonItem item = new BarButtonItem();
                item.Caption = client.Name;
                item.ImageOptions.Image = Converter.GetImageFromBinary(client.Image);
                item.ItemClick += new ItemClickEventHandler(this.bsiClientClick);
           
                bsiClient.LinksPersistInfo.Add(new LinkPersistInfo(item));
                try
                {
                    SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();

                    connBuilder.DataSource = client.Datasource;
                    connBuilder.UserID = client.UserID;
                    connBuilder.PersistSecurityInfo = client.PersistSecurityInfo.Value;
                    connBuilder.Password = client.Password;
                    connBuilder.InitialCatalog = client.InitialCatalog;

                    SqlConnection sqlConnection = new SqlConnection(connBuilder.ConnectionString);

                    //Überprüfe ob eine Verbindung zur Datenbank möglich ist.
                    sqlConnection.Open();
                    sqlConnection.Close();

                    //Falls Verbindung möglich in Liste aufnehmen.
                    this.clientDictionary.Add(item, new Client(client.PKClient, sqlConnection, client.Name));
                }
                catch
                {
                    //Falls Verbindung zur Datenbank nicht möglich ist, dann Item auf enabled = false setzen.
                    item.Enabled = false;
                    item.Caption = client.Name + " (No connection to database)";
                }                
            }
            
            if (this.clientDictionary.Count() > 0)
            {
                ClientChangeEventArgs eventArgs = new ClientChangeEventArgs((Client)clientDictionary.ToArray()[0].Value);
                ClientChanged?.Invoke(this, eventArgs);
            }
        }

        public void LoadData(long pkClient, bool clear)
        {
            Dictionary<long, Client> clientDictionary = new Dictionary<long, Client>();

            if (modulGroupCollection!=null) modulGroupCollection.Clear();

            var query = from row in context.v_Wookie_Menu_0000
                        where row.PKClient == pkClient
                        orderby row.ModulGroupSortOrder ascending,
                                row.ModulSortOrder ascending,
                                row.CategorySortOrder ascending,
                                row.SubCategorySortOrder ascending
                        select row;

            if (query == null || query.Count() == 0) return;
            
            foreach (Database.v_Wookie_Menu_0000 row in query)
            {
                Client client = null;
                ModulGroup modulGroup = null;
                Modul modul = null;
                Category category = null;
                SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();
                connBuilder.DataSource = row.Datasource;
                connBuilder.InitialCatalog = row.InitialCatalog;
                connBuilder.PersistSecurityInfo = row.PersistSecurityInfo.Value;
                connBuilder.UserID = row.UserID;
                connBuilder.Password = row.Password;
                

                //Client
                if (!clientDictionary.ContainsKey(row.PKClient))
                {
                    client = new Client(row.PKClient, connBuilder.ConnectionString, row.ClientName);
                    clientDictionary.Add(row.PKClient, client);
                }

                client = clientDictionary[row.PKClient];

                //Modul Group
                if (!row.PKModulGroup.HasValue) continue;
                if (!modulGroupCollection.ContainsKey(row.PKModulGroup.Value))
                {
                    modulGroupCollection.Add(row.PKModulGroup.Value, new ModulGroup(row.ModulGroupName, row.ModulGroupImage));
                }

                modulGroup = modulGroupCollection[row.PKModulGroup.Value];

                // Modul
                if (!row.PKModul.HasValue) continue;
                if (!modulGroup.Moduls.ContainsKey(row.PKModul))
                {
                    modulGroup.Moduls.Add(row.PKModul, new Modul(row.ModulName, row.ModulImage));
                }

                modul = modulGroup.Moduls[row.PKModul.Value];

                // Category
                if (!row.PKCategory.HasValue) continue;
                if (!modul.Categories.ContainsKey(row.PKCategory))
                {
                    modul.Categories.Add(
                        row.PKCategory, 
                        new Category(
                            row.CategoryName, 
                            row.CategoryImage, 
                            row.CategoryAssemblyname,
                            connBuilder.ConnectionString,
                            row.FKExternal));
                }

                category = modul.Categories[row.PKCategory.Value];

                // Category
                if (!row.PKSubCategory.HasValue) continue;
                if (!category.SubCategories.ContainsKey(row.PKSubCategory))
                {
                    category.SubCategories.Add(
                        row.PKSubCategory,
                        new SubCategory(
                            row.SubCategoryName,
                            row.SubCategoryImage,
                            row.SubCategoryAssemblyname,
                            connBuilder.ConnectionString,
                            row.FKExternal));
                }               

                modulGroupCollection.MenuManager = this;
            }

            this.BuildMenu(clear);
        }

        public void BuildMenu(bool clear)
        {
            if (this.accordionControl == null) return;
            if (this.modulGroupCollection == null) return;

            accordionControl.BeginUpdate();

            if (clear) this.accordionControl.Elements.Clear();

            foreach (ModulGroup modulGroup in this.modulGroupCollection.Values)
            {
                this.accordionControl.Elements.Add(modulGroup.AccordionControlElement);

                if (modulGroup.Moduls == null) continue;
                foreach (Modul modul in modulGroup.Moduls.Values)
                {
                    modulGroup.AccordionControlElement.Elements.Add(modul.AccordionControlElement);

                    if (modul.Categories == null) continue;
                    foreach (Category category in modul.Categories.Values)
                    {
                        modul.AccordionControlElement.Elements.Add(category.AccordionControlElement);
                        category.CategoryClick += new Category.CategoryEventHandler(this.categoryClick);

                        if (category.SubCategories == null) continue;
                        foreach (SubCategory subCategory in category.SubCategories.Values)
                        {
                            category.AccordionControlElement.Style = ElementStyle.Group;
                            category.AccordionControlElement.Elements.Add(subCategory.AccordionControlElement);
                            subCategory.CategoryClick += new Category.CategoryEventHandler(this.categoryClick);
                        }
                    }
                }
            }

            accordionControl.EndUpdate();
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

            aceSettings = new AccordionControlElement();
            aceSettings.ControlFooterAlignment = AccordionItemFooterAlignment.Far;
            aceSettings.Expanded = true;
            //aceSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            aceSettings.Name = "aceSettings";
            //toolTipTitleItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipTitleItem1.Text = "Settings";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Modify general settings which apply to all instances.";
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "T-Systems - Wookie";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            aceSettings.SuperTip = superToolTip1;
            aceSettings.Text = "Settings";
            aceSettings.Click += new System.EventHandler(this.Settings_Click);

            this.accordionControl.Elements.Add(aceSettings);
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            EventArgs eventArgs = new EventArgs();
            SettingsClicked?.Invoke(this, eventArgs);
        }

        private void categoryClick(Category sender)
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

        public ModulGroupCollection ModulGroups
        {
            get { return this.modulGroupCollection; }
        }

        private void bsiClientClick(object sender, ItemClickEventArgs e)
        {
            if (this.clientDictionary[e.Item] == null) return;

            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(this.clientDictionary[e.Item]);
            ClientChanged?.Invoke(this, eventArgs);
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
                    this.modulGroupCollection.Clear();
                    this.clientDictionary.Clear();
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.
                this.modulGroupCollection = null;
                this.navigationFrame = null;
                this.clientDictionary = null;
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
