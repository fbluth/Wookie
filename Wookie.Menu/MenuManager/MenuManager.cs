using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wookie.Tools.Image;

namespace Wookie.Menu.MenuManager
{
    public class MenuManager
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

        public void AddClients(DevExpress.XtraBars.BarSubItem bsiClient)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery.Count() == 0) return;

            foreach (Database.tsysClient client in clientQuery)
            {
                BarButtonItem item = new BarButtonItem();
                item.Caption = client.Name;
                item.ImageOptions.SvgImage = Converter.GetSvgImageFromBinary(client.SvgImage);
                item.ItemClick += new ItemClickEventHandler(this.bsiClientClick);
           
                bsiClient.LinksPersistInfo.Add(new LinkPersistInfo(item));
           
                this.clientDictionary.Add(item, new Client(client.PKClient, new System.Data.SqlClient.SqlConnection(client.ConnectionString), client.Name));
            }
            
            if (this.clientDictionary.Count() > 0)
            {
                ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(clientDictionary.ToArray()[0].Value);
                ClientChanged?.Invoke(this, eventArgs);
            }
        }

        public void LoadData(long pkClient)
        {
            Dictionary<long, Client> clientDictionary = new Dictionary<long, Client>();

            if (modulGroupCollection!=null) modulGroupCollection.Clear();

            var query = from row in context.v_Wookie_Menu_0000
                        where row.PKClient == pkClient
                        orderby row.ModulGroupSortOrder ascending,
                                row.ModulSortOrder ascending,
                                row.CategorySortOrder ascending
                        select row;

            if (query.Count() == 0) return;
            
            foreach (Database.v_Wookie_Menu_0000 row in query)
            {
                Client client = null;
                ModulGroup modulGroup = null;
                Modul modul = null;
                Category category = null;
                

                //Client
                if (!clientDictionary.ContainsKey(row.PKClient))
                {
                    client = new Client(row.PKClient, new System.Data.SqlClient.SqlConnection(row.ClientConnectionString), row.ClientName);
                    clientDictionary.Add(row.PKClient, client);
                }

                client = clientDictionary[row.PKClient];

                //Modul Group
                if (!row.PKModulGroup.HasValue) continue;
                if (!modulGroupCollection.ContainsKey(row.PKModulGroup.Value))
                {
                    modulGroupCollection.Add(row.PKModulGroup.Value, new ModulGroup(row.ModulGroupName, row.ModulGroupSvgImage));
                }

                modulGroup = modulGroupCollection[row.PKModulGroup.Value];

                // Modul
                if (!row.PKModul.HasValue) continue;
                if (!modulGroup.Moduls.ContainsKey(row.PKModul))
                {
                    modulGroup.Moduls.Add(row.PKModul, new Modul(row.ModulName, row.ModulSvgImage));
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
                            row.CategorySvgImage, 
                            row.Assemblyname, 
                            new System.Data.SqlClient.SqlConnection(row.ClientConnectionString), 
                            row.FKExternal));
                }

                category = modul.Categories[row.PKCategory.Value];

                modulGroupCollection.MenuManager = this;
            }

            this.BuildMenu();
        }

        public void BuildMenu()
        {
            if (this.accordionControl == null) return;
            if (this.modulGroupCollection == null) return;

            this.accordionControl.Elements.Clear();

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
                    }
                }
            }

            
        }

        public void AddSettings()
        {
            // Add Settings
            DevExpress.XtraBars.Navigation.AccordionControlElement aceSettings;
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();

            aceSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            aceSettings.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
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
    }
}
