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
    public class Page
    {
        private string caption = null;
        private SvgImage svgImage = null;
        private GroupCollection groups = null;
        private RibbonPage ribbonPage = null;
        private MenuManager menuManager = null;

        public Page(string caption)
        {
            this.groups = new GroupCollection(this.MenuManager, this);
            this.caption = caption;            
        }

        public Page(string caption, SvgImage svgImage):this(caption)
        {
            this.svgImage = svgImage;
        }

        public Page(string caption, Binary binary):this(caption)
        {
            this.svgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (ribbonPage != null) ribbonPage.Text = value; this.caption = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.ribbonPage != null) ribbonPage.ImageOptions.SvgImage = value; this.svgImage = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; this.groups.MenuManager = value; }
        }

        public GroupCollection Groups
        {
            get { return this.groups; }          
        }

        public RibbonPage RibbonPage
        {
            get
            {
                if (ribbonPage == null)
                {
                    ribbonPage = new RibbonPage(this.caption);
                    ribbonPage.ImageOptions.SvgImage = this.svgImage;                    
                }
                return ribbonPage;
            }
        }
    }
}
