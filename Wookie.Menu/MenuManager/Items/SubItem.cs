using DevExpress.Utils.Svg;
using System.Data.Linq;
using Wookie.Tools.Image;
using DevExpress.XtraBars;

namespace Wookie.Menu.MenuManager
{
    public class SubItem
    {   
        private BarSubItem barSubItem = null;
        private MenuManager menuManager = null;
        private string caption = null;
        private SvgImage svgImage = null;
        private ItemCollection items = null;
        private bool showInMenu = false;

        public Group Group { get; set; }

        public SubItem(bool showInMenu, string caption)
        {
            this.items = new ItemCollection(this.MenuManager, this);
            this.caption = caption;
            this.showInMenu = showInMenu;
        }

        public SubItem(bool showInMenu, string caption, SvgImage svgImage) : this(showInMenu, caption)
        {
            this.svgImage = svgImage;
        }

        public SubItem(bool showInMenu, string caption, Binary binary) : this(showInMenu, caption)
        {
            this.svgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (barSubItem != null) barSubItem.Caption = value; this.caption = value; }
        }

        public bool ShowInMenu
        {
            get { return this.showInMenu; }
            set { this.showInMenu = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.barSubItem != null) barSubItem.ImageOptions.SvgImage = value; this.svgImage = value; }
        }


        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; this.items.MenuManager = value; }
        }

        public ItemCollection Items
        {
            get { return this.items; }
        }

        public BarSubItem BarSubItem
        {
            get
            {
                if (barSubItem == null)
                {
                    barSubItem = new BarSubItem();
                    barSubItem.ImageOptions.SvgImage = this.svgImage;
                    barSubItem.Caption = this.caption;
                }
                return barSubItem;
            }
        }
    }
}
