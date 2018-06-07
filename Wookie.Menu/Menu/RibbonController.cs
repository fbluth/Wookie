using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Collections.Generic;
using System.Linq;
using Wookie.Tools;

namespace Wookie.Menu
{
    public class RibbonController
    {
        #region Variables
        private Database.MenuDataContext context = null;
        private Dictionary<BarItem, RibbonItem> RibbonItemDictionary = new Dictionary<BarItem, RibbonItem>();
        
        public event RibbonItemClickEventHandler RibbonItemClick;
        public event ClientChangeEventHandler ClientChanged;
        #endregion

        #region Constructor
        public RibbonController(System.Data.SqlClient.SqlConnection sqlConnection)
        {
            context = new Database.MenuDataContext(sqlConnection);
        }
        #endregion

        /// <summary>
        /// Bindet in das übergebene Ribboncontrol einen neuen Menüpunkt ein, über den der Endanwender zwischen den Mandanten wechseln kann.
        /// </summary>
        /// <param name="ribbonControl">Das RibbonControl, dem ein neuer Menüpunkt für die Mandantenauswahl hinzugefügt werden soll.</param>
        public void AddClientsToRibbon(RibbonControl ribbonControl)
        {
            // Lese aus der Datenbank alle Mandanten aus
            var clientQuery = from client in context.tsysClient orderby client.SortOrder select client;

            // Falls keine Mandanten in der Datenbank hinterlegt sind, ist nichts zu tun
            if (clientQuery.Count() == 0) return;

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).BeginInit();

            BarSubItem bsiClient = new BarSubItem();
            bsiClient.Caption = clientQuery.First().Name;
            bsiClient.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(clientQuery.First().SvgImage);
            bsiClient.Id = ribbonControl.Manager.GetNewItemId();

            ribbonControl.Items.Add(bsiClient);
            ribbonControl.PageHeaderItemLinks.Add(bsiClient);

            foreach (Database.tsysClient client in clientQuery)
            {
                BarButtonItem item = new BarButtonItem();
                item.Caption = client.Name;
                item.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(client.SvgImage);
                item.ItemClick += new ItemClickEventHandler(this.bsiClientClick);
                item.Id = ribbonControl.Manager.GetNewItemId();

                bsiClient.LinksPersistInfo.Add(new LinkPersistInfo(item));
                ribbonControl.Items.Add(item);

                RibbonItemDictionary.Add(item, new RibbonItem(null,null, new Client(client.PKClient, new System.Data.SqlClient.SqlConnection(client.ConnectionString))));
            }

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();

            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(RibbonItemDictionary.ToArray()[0].Value.Client, RibbonItemDictionary.ToArray()[0].Key);
            ClientChanged?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Erstellt ein RibbonForm anhand der Datenbankeinträge zum zugehöigen Mandant.
        /// </summary>
        /// <param name="pkClient"></param>
        /// <returns></returns>
        public RibbonControl CreateRibbon(long pkClient)
        {
            var query = from row in context.v_Wookie_Menu_0000
                        where row.PKClient == pkClient
                        orderby row.PageSortOrder, 
                                row.PageGroupSortOrder, 
                                row.PageGroupItemCollectionSortOrder,
                                row.PageGroupItemSortOrder,
                                row.MenuItemSortOrder
                        select row;

            if (query.Count() == 0) return null;

            Dictionary<long, Client> clientDictionary = new Dictionary<long, Client>();
            Dictionary<long?, RibbonPage> pageDictionary = new Dictionary<long?, RibbonPage>();
            Dictionary<long?, RibbonPageGroup> pageGroupDictionary = new Dictionary<long?, RibbonPageGroup>();
            Dictionary<long?, BarSubItem> pageGroupItemCollectionDictionary = new Dictionary<long?, BarSubItem>();
            Dictionary<long?, BarButtonItem> pageGroupItemDictionary = new Dictionary<long?, BarButtonItem>();
            RibbonControl ribbonControl = new RibbonControl();

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).BeginInit();

            foreach (Database.v_Wookie_Menu_0000 row in query)
            {
                Menu.Client client = null;
                RibbonPage ribbonPage = null;
                RibbonPageGroup ribbonPageGroup = null;
                BarButtonItem item = null;
                BarSubItem subitem = null;

                if (!clientDictionary.ContainsKey(row.PKClient))
                {
                    client = new Client(row.PKClient, new System.Data.SqlClient.SqlConnection(row.ClientConnectionString));
                    clientDictionary.Add(row.PKClient, client);
                }

                client = clientDictionary[row.PKClient];

                if (!row.PKPage.HasValue) continue;
                if (!pageDictionary.ContainsKey(row.PKPage))
                {
                    ribbonPage = new RibbonPage(row.PageName);
                    ribbonPage.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(row.PageSvgImage);

                    ribbonControl.Pages.Add(ribbonPage);
                    pageDictionary.Add(row.PKPage, ribbonPage);
                }

                ribbonPage = pageDictionary[row.PKPage];

                if (!row.PKPageGroup.HasValue) continue;
                if (!pageGroupDictionary.ContainsKey(row.PKPageGroup))
                {
                    ribbonPageGroup = new RibbonPageGroup(row.PageGroupName);
                    ribbonPageGroup.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(row.PageGroupSvgImage);
                    ribbonPageGroup.AllowTextClipping = false;

                    ribbonPage.Groups.Add(ribbonPageGroup);
                    pageGroupDictionary.Add(row.PKPageGroup, ribbonPageGroup);
                }

                ribbonPageGroup = pageGroupDictionary[row.PKPageGroup];

                if (!row.PKPageGroupItemCollection.HasValue) continue;
                if (!pageGroupItemCollectionDictionary.ContainsKey(row.PKPageGroupItemCollection))
                {
                    subitem = new BarSubItem();
                    subitem.Caption = row.PageGroupItemCollectionName;
                    subitem.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(row.PageGroupItemCollectionSvgImage);

                    if (row.PageGroupItemCollectionShowInMenu.Value)
                        ribbonPageGroup.ItemLinks.Add(subitem);
                    
                    pageGroupItemCollectionDictionary.Add(row.PKPageGroupItemCollection, subitem);
                }                

                subitem = pageGroupItemCollectionDictionary[row.PKPageGroupItemCollection];

                if (!row.PKPageGroupItem.HasValue) continue;
                if (!pageGroupItemDictionary.ContainsKey(row.PKPageGroupItem))
                {
                    item = ribbonControl.Items.CreateButton(row.PageGroupItemName);
                    item.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(row.PageGroupItemSvgImage);
                    item.Id = ribbonControl.Manager.GetNewItemId();
                    item.ItemClick += new ItemClickEventHandler(this.biClick);

                    if (row.PageGroupItemCollectionShowInMenu.Value)
                    {
                        subitem.LinksPersistInfo.Add(new LinkPersistInfo(item));
                    }
                    else
                    {
                        ribbonPageGroup.ItemLinks.Add(item);
                    }
                    RibbonItemDictionary.Add(item, new RibbonItem(row.FKExternal, row.Assemblyname, client));
                    pageGroupItemDictionary.Add(row.PKPageGroupItem, item);
                }
            }

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();

            return ribbonControl;
        }
        
        private void biClick(object sender, ItemClickEventArgs e)
        {
            if (RibbonItemDictionary[e.Item] == null) return;

            RibbonItemClickEventArgs eventArgs = new RibbonItemClickEventArgs(RibbonItemDictionary[e.Item]);
            RibbonItemClick?.Invoke(this, eventArgs);
        }

        private void bsiClientClick(object sender, ItemClickEventArgs e)
        {
            if (RibbonItemDictionary[e.Item] == null) return;

            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(RibbonItemDictionary[e.Item].Client, (BarItem)e.Item);
            ClientChanged?.Invoke(this, eventArgs);
        }
    }
}
