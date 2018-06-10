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
        private PageCollection pageCollection = null;
        private Database.MenuDataContext context = null;
        private NavigationFrame navigationFrame = null;
        private Dictionary<BarItem, Client> clientDictionary = new Dictionary<BarItem, Client>();

        public event ClientChangeEventHandler ClientChanged;

        public MenuManager(System.Data.SqlClient.SqlConnection sqlConnection, NavigationFrame navigationFrame)
        {
            this.pageCollection = new PageCollection(this);
            this.navigationFrame = navigationFrame;
            context = new Database.MenuDataContext(sqlConnection);
        }

        public void AddClientsToRibbon(RibbonControl ribbonControl)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery.Count() == 0) return;

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).BeginInit();

            BarSubItem bsiClient = new BarSubItem();
            bsiClient.Caption = clientQuery.First().Name;
            bsiClient.ImageOptions.SvgImage = Converter.GetSvgImageFromBinary(clientQuery.First().SvgImage);
            bsiClient.Id = ribbonControl.Manager.GetNewItemId();

            ribbonControl.Items.Add(bsiClient);
            ribbonControl.PageHeaderItemLinks.Add(bsiClient);

            foreach (Database.tsysClient client in clientQuery)
            {
                
                BarButtonItem item = new BarButtonItem();
                item.Caption = client.Name;
                item.ImageOptions.SvgImage = Converter.GetSvgImageFromBinary(client.SvgImage);
                item.ItemClick += new ItemClickEventHandler(this.bsiClientClick);
                item.Id = ribbonControl.Manager.GetNewItemId();

                bsiClient.LinksPersistInfo.Add(new LinkPersistInfo(item));
                ribbonControl.Items.Add(item);

                this.clientDictionary.Add(item, new Client(client.PKClient, new System.Data.SqlClient.SqlConnection(client.ConnectionString), client.Name));
            }
            
            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();

            if (this.clientDictionary.Count() > 0)
            {
                ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(clientDictionary.ToArray()[0].Value);
                ClientChanged?.Invoke(this, eventArgs);
            }
        }

        public void LoadData(long pkClient)
        {
            Dictionary<long, Client> clientDictionary = new Dictionary<long, Client>();

            var query = from row in context.v_Wookie_Menu_0000
                        where row.PKClient == pkClient
                        orderby row.PageSortOrder ascending,
                                row.PageGroupSortOrder ascending,
                                row.PageGroupItemCollectionSortOrder ascending,
                                row.PageGroupItemSortOrder ascending,
                                row.MenuItemSortOrder ascending
                        select row;

            if (query.Count() == 0) return;
            
            foreach (Database.v_Wookie_Menu_0000 row in query)
            {
                Client client = null;
                SubItem subItem = null;
                Item item = null;
                Page page = null;
                Group group = null;

                //Client
                if (!clientDictionary.ContainsKey(row.PKClient))
                {
                    client = new Client(row.PKClient, new System.Data.SqlClient.SqlConnection(row.ClientConnectionString), row.ClientName);
                    clientDictionary.Add(row.PKClient, client);
                }

                client = clientDictionary[row.PKClient];

                //Page
                if (!row.PKPage.HasValue) continue;
                if (!pageCollection.ContainsKey(row.PKPage.Value))
                {
                    pageCollection.Add(row.PKPage.Value, new Page(row.PageName, row.PageSvgImage));
                }

                page = pageCollection[row.PKPage.Value];

                if (!row.PKPageGroup.HasValue) continue;
                if (!page.Groups.ContainsKey(row.PKPageGroup))
                {
                    page.Groups.Add(row.PKPageGroup, new Group(row.PageGroupName, row.PageGroupSvgImage));
                }

                //Group + Item
                group = page.Groups[row.PKPageGroup.Value];

                if (!row.PKPageGroupItemCollection.HasValue) continue;
                
                if (row.PageGroupItemCollectionShowInMenu.Value)
                {
                    if (!group.SubItems.ContainsKey(row.PKPageGroupItemCollection.Value))
                    {
                        group.SubItems.Add(row.PKPageGroupItemCollection.Value, new SubItem(row.PageGroupItemCollectionShowInMenu.Value, row.PageGroupItemCollectionName, row.PageGroupItemCollectionSvgImage));
                    }

                    subItem = group.SubItems[row.PKPageGroupItemCollection.Value];

                    if (!row.PKPageGroupItem.HasValue) continue;
                    if (!subItem.Items.ContainsKey(row.PKPageGroupItem.Value))
                    {
                        subItem.Items.Add(row.PKPageGroupItem.Value, new Item(row.PageGroupItemName, row.PageGroupItemSvgImage, row.Assemblyname, client.SqlConnection, row.FKExternal));
                    }

                    item = subItem.Items[row.PKPageGroupItem.Value];
                }
                else
                {
                    if (!row.PKPageGroupItem.HasValue) continue;
                    if (!group.Items.ContainsKey(row.PKPageGroupItem.Value))
                    {
                        group.Items.Add(row.PKPageGroupItem.Value, new Item(row.PageGroupItemName, row.PageGroupItemSvgImage, row.Assemblyname, client.SqlConnection, row.FKExternal));                        
                    }

                    item = group.Items[row.PKPageGroupItem.Value];
                }

                if (!row.PKMenuItem.HasValue) continue;
                if (!item.ModulItems.ContainsKey(row.PKMenuItem.Value))
                {
                    item.ModulItems.Add(row.PKMenuItem.Value, new ModulItem(row.MenuItemName, row.MenuItemSvgImage, row.MenuItemAssemblyname, client.SqlConnection, row.FKExternal));
                }

                pageCollection.MenuManager = this;
            }
        }

        public void Remove(RibbonControl ribbonControl, PageCollection pageCollection)
        {
            foreach (Page page in pageCollection.Values)
            {
                foreach (Group group in page.Groups.Values)
                {
                    foreach (SubItem subItem in group.SubItems.Values)
                    {
                        foreach (Item item in subItem.Items.Values)
                        {
                            ribbonControl.Items.Remove(item.BarButtonItem);
                        }
                        ribbonControl.Items.Remove(subItem.BarSubItem);
                    }
                    foreach (Item item in group.Items.Values)
                    {
                        ribbonControl.Items.Remove(item.BarButtonItem);
                    }
                }
                ribbonControl.Pages.Remove(page.RibbonPage);                               
            }

            
            foreach (KeyValuePair<object, Page> page in pageCollection.ToArray())
            {
                pageCollection.Remove(page.Key);                  
            }

            RibbonBarItems m = ribbonControl.Items;
        }
        
        public void Add(RibbonControl ribbonControl, long pkClient)
        {
            this.LoadData(pkClient);
            RibbonBarItems m = ribbonControl.Items;
            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).BeginInit();
            foreach (Page page in this.pageCollection.Values)
            {
                ribbonControl.Pages.Add(page.RibbonPage);
                foreach (Group group in page.Groups.Values)
                {
                    page.RibbonPage.Groups.Add(group.RibbonPageGroup);
                    foreach (SubItem subItem in group.SubItems.Values)
                    {
                        group.RibbonPageGroup.ItemLinks.Add(subItem.BarSubItem);
                        foreach (Item item in subItem.Items.Values)
                        {
                            //ribbonControl.Items.Add(item.BarButtonItem);
                            //item.BarButtonItem.Id = ribbonControl.Manager.GetNewItemId();
                            subItem.BarSubItem.LinksPersistInfo.Add(new LinkPersistInfo(item.BarButtonItem));
                            item.MenuItemClick += new Item.MenuItemEventHandler(this.menuItem_Click);
                            foreach (ModulItem modulItem in item.ModulItems.Values)
                            {
                                item.Modul.AccordionControl.Elements.Add(modulItem.AccordionControlElement);
                                modulItem.ModulItemClick += new ModulItem.ModulItemEventHandler(this.modulItem_Click);
                            }
                        }                        
                    }

                    foreach (Item item in group.Items.Values)
                    {
                        //ribbonControl.Items.Add(item.BarButtonItem);
                        //item.BarButtonItem.Id = ribbonControl.Manager.GetNewItemId();
                        group.RibbonPageGroup.ItemLinks.Add(item.BarButtonItem);

                        foreach (ModulItem modulItem in item.ModulItems.Values)
                        {
                            item.Modul.AccordionControl.Elements.Add(modulItem.AccordionControlElement);
                            modulItem.ModulItemClick += new ModulItem.ModulItemEventHandler(this.modulItem_Click);
                        }
                    }
                }
            }
            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();
        }

        private void menuItem_Click(Item sender)
        {
            if (sender.NavigationPage == null) return;

            if (!this.navigationFrame.Pages.Contains(sender.NavigationPage))
                this.navigationFrame.Pages.Add(sender.NavigationPage);
            this.navigationFrame.SelectedPage = sender.NavigationPage;
        }

        private void modulItem_Click(ModulItem sender)
        {
            if (sender.NavigationPage == null) return;

            if (!sender.Item.Modul.NavigationFrame.Pages.Contains(sender.NavigationPage))
                sender.Item.Modul.NavigationFrame.Pages.Add(sender.NavigationPage);
            sender.Item.Modul.NavigationFrame.SelectedPage = sender.NavigationPage;
        }

        public PageCollection Pages
        {
            get { return this.pageCollection; }
        }

        private void bsiClientClick(object sender, ItemClickEventArgs e)
        {
            if (this.clientDictionary[e.Item] == null) return;

            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(this.clientDictionary[e.Item]);
            ClientChanged?.Invoke(this, eventArgs);
        }
    }
}
