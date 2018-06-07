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
        private MenuDataContext context = null;
        private Dictionary<BarItem, RibbonItem> RibbonItemList = new Dictionary<BarItem, RibbonItem>();
        
        public event RibbonItemClickEventHandler RibbonItemClick;
        public event ClientChangeEventHandler ClientChanged;
        #endregion

        #region Constructor
        public RibbonController(System.Data.SqlClient.SqlConnection sqlConnection)
        {
            context = new MenuDataContext(sqlConnection);
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

            BarSubItem bsiClient = CreateBarSubItem(clientQuery.First().Name, ImageHelper.GetSvgImageFromBinary(clientQuery.First().SvgImage));
            bsiClient.Id = ribbonControl.Manager.GetNewItemId();
            ribbonControl.Items.Add(bsiClient);
            ribbonControl.PageHeaderItemLinks.Add(bsiClient);

            foreach (Menu.tsysClient client in clientQuery)
            {
                BarButtonItem item = CreateBarButtonItem(client.Name, ImageHelper.GetSvgImageFromBinary(client.SvgImage));
                item.ItemClick += new ItemClickEventHandler(this.bsiClientClick);
                item.Id = ribbonControl.Manager.GetNewItemId();
                bsiClient.LinksPersistInfo.Add(new LinkPersistInfo(item));
                ribbonControl.Items.Add(item);

                RibbonItemList.Add(item, new RibbonItem(null,null, new Client(client.PKClient, new System.Data.SqlClient.SqlConnection(client.ConnectionString))));
            }

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();

            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(RibbonItemList.ToArray()[0].Value.Client, RibbonItemList.ToArray()[0].Key);
            ClientChanged?.Invoke(this, eventArgs);
        }
        
        /// <summary>
        /// Erstellt ein RibbonForm anhand der Datenbankeinträge zum zugehöigen Mandant.
        /// </summary>
        /// <param name="pkClient"></param>
        /// <returns></returns>
        public RibbonControl CreateRibbon(long pkClient)
        {
            RibbonControl ribbonControl = new RibbonControl();

            var clientQuery = from client in context.tsysClient where client.PKClient == pkClient orderby client.SortOrder select client;
            if (clientQuery.Count() == 0) return null;

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).BeginInit();

            var pageQuery = from page in context.tsysPage where page.FKClient == pkClient orderby page.SortOrder select page;

            foreach (Menu.tsysPage page in pageQuery)
            {
                RibbonPage ribbonPage = new RibbonPage(page.Name);
                ribbonPage.ImageOptions.SvgImage = ImageHelper.GetSvgImageFromBinary(page.SvgImage);

                var pageGroupQuery = from pageGroup in context.tsysPageGroup where pageGroup.FKPage == page.PKPage orderby pageGroup.SortOrder select pageGroup;

                foreach (Menu.tsysPageGroup pageGroup in pageGroupQuery)
                {
                    RibbonPageGroup ribbonPageGroup = new RibbonPageGroup(pageGroup.Name);
                    ribbonPageGroup.ImageOptions.SvgImage = Tools.ImageHelper.GetSvgImageFromBinary(pageGroup.SvgImage);
                    ribbonPageGroup.AllowTextClipping = false;

                    var pageGroupItemCollectionQuery = from pageGroupItemCollection in context.tsysPageGroupItemCollection where pageGroupItemCollection.FKPageGroup == pageGroup.PKPageGroup orderby pageGroupItemCollection.SortOrder select pageGroupItemCollection;

                    foreach (Menu.tsysPageGroupItemCollection pageGroupItemCollection in pageGroupItemCollectionQuery)
                    {
                        var pageGroupItemQuery = from pageGroupItem in context.tsysPageGroupItem where pageGroupItem.FKPageGroupItemCollection == pageGroupItemCollection.PKPageGroupItemCollection orderby pageGroupItem.SortOrder select pageGroupItem;

                        if (pageGroupItemQuery.Count() == 1)
                        {
                            Menu.tsysPageGroupItem pageGroupItem = pageGroupItemQuery.Single();

                            BarButtonItem item = CreateBarButtonItem(pageGroupItem.Name, ImageHelper.GetSvgImageFromBinary(pageGroupItem.SvgImage));
                            item.ItemClick += new ItemClickEventHandler(this.biClick);
                            item.Id = ribbonControl.Manager.GetNewItemId();
                            RibbonItemList.Add(item, new RibbonItem(
                                    pageGroupItem.FKExternal, 
                                    pageGroupItem.Assemblyname, 
                                    new Client(pkClient, new System.Data.SqlClient.SqlConnection(clientQuery.Single().ConnectionString))));

                            ribbonPageGroup.ItemLinks.Add(item);
                        }
                        else if (pageGroupItemQuery.Count() > 1)
                        {
                            BarSubItem barSubItem = CreateBarSubItem(pageGroupItemQuery.First().Name, ImageHelper.GetSvgImageFromBinary(pageGroupItemQuery.First().SvgImage));

                            ribbonControl.Items.Add(barSubItem);

                            foreach (Menu.tsysPageGroupItem pageGroupItem in pageGroupItemQuery)
                            {

                                BarButtonItem item = CreateBarButtonItem(pageGroupItem.Name, ImageHelper.GetSvgImageFromBinary(pageGroupItem.SvgImage));
                                item.ItemClick += new ItemClickEventHandler(this.bsiClick);
                                item.Id = ribbonControl.Manager.GetNewItemId();
                                RibbonItemList.Add(item, new RibbonItem(
                                   pageGroupItem.FKExternal,
                                   pageGroupItem.Assemblyname,
                                   new Client(pkClient, new System.Data.SqlClient.SqlConnection(clientQuery.Single().ConnectionString))));

                                barSubItem.LinksPersistInfo.Add(new LinkPersistInfo(item));
                                ribbonControl.Items.Add(item);
                            }
                            ribbonPageGroup.ItemLinks.Add(barSubItem);
                        }
                    }
                    ribbonPage.Groups.Add(ribbonPageGroup);
                }
                ribbonControl.Pages.Add(ribbonPage);
            }

            ((System.ComponentModel.ISupportInitialize)(ribbonControl)).EndInit();

            return ribbonControl;
        }

        private BarButtonItem CreateBarButtonItem(string caption, SvgImage svgImage)
        {
            BarButtonItem item = new BarButtonItem();
            item.Caption = caption;
            item.ImageOptions.SvgImage = svgImage;
            return item;
        }

        private BarSubItem CreateBarSubItem(string caption, SvgImage svgImage)
        {
            BarSubItem item = new BarSubItem();
            item.Caption = caption;
            item.ImageOptions.SvgImage = svgImage;
            return item;
        }

        private void biClick(object sender, ItemClickEventArgs e)
        {
            if (RibbonItemList[e.Item] == null) return;

            RibbonItemClickEventArgs eventArgs = new RibbonItemClickEventArgs(RibbonItemList[e.Item]);
            RibbonItemClick?.Invoke(this, eventArgs);
        }

        private void bsiClick(object sender, ItemClickEventArgs e)
        {
            if (RibbonItemList[e.Item] == null) return;

            if (e.Link.OwnerItem != null)
            {
                e.Link.OwnerItem.Caption = e.Item.Caption;
                e.Link.OwnerItem.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            }
            RibbonItemClickEventArgs eventArgs = new RibbonItemClickEventArgs(RibbonItemList[e.Item]);
            RibbonItemClick?.Invoke(this, eventArgs);
        }

        private void bsiClientClick(object sender, ItemClickEventArgs e)
        {
            if (RibbonItemList[e.Item] == null) return;

            if (e.Link.OwnerItem != null)
            {
                e.Link.OwnerItem.Caption = e.Item.Caption;
                e.Link.OwnerItem.ImageOptions.SvgImage = e.Item.ImageOptions.SvgImage;
            }
            ClientChangeEventArgs eventArgs = new ClientChangeEventArgs(RibbonItemList[e.Item].Client, (BarItem)e.Item);
            ClientChanged?.Invoke(this, eventArgs);
        }
    }
}
