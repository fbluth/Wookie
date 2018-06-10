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
    public class ModulItem
    {
        private AccordionControlElement accordionControlElement = null;
        private MenuManager menuManager = null;
        private string caption = null;
        private SvgImage svgImage = null;
        private NavigationPage navigationPage = null;
        private ICategory category = null;

        public Item Item { get; set; }
        public string AssemblyFile { get; }
        public SqlConnection SqlConnection { get; set; }
        public long? FKExternal { get; set; }

        public ModulItem(string caption, string assemblyFile, SqlConnection sqlconnection, long? fkExternal)
        {
            this.caption = caption;
            this.AssemblyFile = assemblyFile;
            this.FKExternal = fkExternal;
            this.SqlConnection = sqlconnection;

            if (this.AssemblyFile != null)
            {
                string assemblyFileDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile : (this.AssemblyFile + ".dll");
                string assemblyFileWithoutDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile.Remove(this.AssemblyFile.Length - 4, 4) : this.AssemblyFile;
                string path = Application.StartupPath + "\\" + assemblyFileDll;

                if (System.IO.File.Exists(path))
                {
                    var assembly = Assembly.LoadFile(path);
                    dynamic instance = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Category"));
                    ((ICategory)instance).SetConnection(this.SqlConnection, this.FKExternal);
                    this.category = ((ICategory)instance);
                }
            }
        }

        public ModulItem(string caption, SvgImage svgImage, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
        {
            this.svgImage = svgImage;
        }

        public ModulItem(string caption, Binary binary, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
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

        public ICategory Category
        {
            get
            {
                return this.category;
            }
        }

        public NavigationPage NavigationPage
        {
            get
            {
                if (this.category != null && this.navigationPage == null)
                {
                    this.navigationPage = new NavigationPage();
                    XtraUserControl control = this.category.Control;
                    control.Dock = DockStyle.Fill;
                    this.navigationPage.Controls.Add(control);
                }
                return this.navigationPage;
            }
        }

        public AccordionControlElement AccordionControlElement
        {
            get
            {
                if (accordionControlElement == null)
                {
                    accordionControlElement = new AccordionControlElement();
                    accordionControlElement.Text = caption;
                    accordionControlElement.ImageOptions.SvgImage = svgImage;
                    accordionControlElement.Click += new EventHandler(this.accordionControlElement_Click);
                }
                return accordionControlElement;
            }
        }

        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            SendModulItemClicked();
        }

        public delegate void ModulItemEventHandler(ModulItem sender);
        public event ModulItemEventHandler ModulItemClick;

        protected virtual void SendModulItemClicked()
        {
            if ((this.ModulItemClick != null))
            {
                this.ModulItemClick(this);
            }
        }
    }
}
