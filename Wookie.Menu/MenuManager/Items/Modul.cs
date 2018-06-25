using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wookie.Tools.Image;

namespace Wookie.Menu.MenuManager
{
    public class Modul
    {
        private AccordionControlElement accordionControlElement = null;
        private MenuManager menuManager = null;
        private string caption = null;
        private SvgImage svgImage = null;
        public SqlConnection SqlConnection { get; set; }
        private CategoryCollection categories = null;

        public Modul(string caption)
        {
            this.categories = new CategoryCollection(this.MenuManager, this);
            this.caption = caption;
        }

        public Modul(string caption, SvgImage svgImage) : this(caption)
        {
            this.svgImage = svgImage;
        }

        public Modul(string caption, Binary binary) : this(caption)
        {
            this.svgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (accordionControlElement != null) accordionControlElement.Text = value; this.caption = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.accordionControlElement != null) accordionControlElement.ImageOptions.SvgImage = value; this.svgImage = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; }
        }

        public CategoryCollection Categories
        {
            get { return this.categories; }
        }

        public AccordionControlElement AccordionControlElement
        {
            get
            {
                if (accordionControlElement == null)
                {
                    accordionControlElement = new AccordionControlElement();
                    accordionControlElement.Text = this.caption;
                    accordionControlElement.Expanded = false;
                    accordionControlElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
                    accordionControlElement.ImageOptions.SvgImage = this.svgImage;
                }
                return accordionControlElement;
            }
        }
    }
}
