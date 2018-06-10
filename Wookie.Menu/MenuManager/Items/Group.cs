using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Ribbon;
using System.Data.Linq;
using Wookie.Tools.Image;

namespace Wookie.Menu.MenuManager
{
    public class Group
    {
        private string caption = null;
        private SvgImage svgImage = null;
        private RibbonPageGroup ribbonPageGroup = null;
        private MenuManager menuManager = null;
        private ItemCollection items = null;
        private SubItemCollection subitems = null;

        public Page Page { get; set; }

        public Group(string caption)
        {
            this.items = new ItemCollection(this.menuManager, this);
            this.subitems = new SubItemCollection(this.menuManager, this);
            this.caption = caption;            
        }

        public Group(string caption, SvgImage svgImage) : this(caption)
        {
            this.SvgImage = svgImage;
        }

        public Group(string caption, Binary binary) : this(caption)
        {
            this.SvgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (ribbonPageGroup != null) ribbonPageGroup.Text = value; this.caption = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.ribbonPageGroup != null) ribbonPageGroup.ImageOptions.SvgImage = value; this.svgImage = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; this.items.MenuManager = value; this.subitems.MenuManager = value; }
        }

        public ItemCollection Items
        {
            get { return this.items; }
        }

        public SubItemCollection SubItems
        {
            get { return this.subitems; }
        }

        public RibbonPageGroup RibbonPageGroup
        {
            get
            {
                if (ribbonPageGroup == null)
                {
                    ribbonPageGroup = new RibbonPageGroup(this.caption);
                    ribbonPageGroup.ImageOptions.SvgImage = this.svgImage;
                    ribbonPageGroup.AllowTextClipping = false;
                }
                return ribbonPageGroup;
            }
        }
    }
}
