using DevExpress.Utils.Svg;
using System.Data.Linq;
using Wookie.Tools.Image;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Reflection;
using System;
using System.Data.SqlClient;
using DevExpress.XtraBars.Navigation;

namespace Wookie.Menu.MenuManager
{
    public class Category
    {
        private MenuManager menuManager = null;
        private string caption = null;
        private SvgImage svgImage = null;
        private AccordionControlElement accordionControlElement = null;
        private NavigationPage navigationPage = null;
        private ICategory categoryInstance = null;

        public string AssemblyFile { get; }
        public SqlConnection SqlConnection {get; set;}
        public long? FKExternal { get; set; }
        
        public Category(string caption, string assemblyFile, SqlConnection sqlconnection, long? fkExternal)
        {   
            this.caption = caption;
            this.AssemblyFile = assemblyFile;
            this.FKExternal = fkExternal;
            this.SqlConnection = sqlconnection;

            this.navigationPage = new NavigationPage();

            if (this.AssemblyFile != null )
            {
                string assemblyFileDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile : (this.AssemblyFile + ".dll");
                string assemblyFileWithoutDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile.Remove(this.AssemblyFile.Length - 4, 4) : this.AssemblyFile;
                string path = Application.StartupPath + "\\" + assemblyFileDll;

                if (System.IO.File.Exists(path))
                {
                    var assembly = Assembly.LoadFile(path);
                    dynamic instance = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Category"));
                    ((ICategory)instance).SetConnection(this.SqlConnection, this.FKExternal);
                    this.categoryInstance = ((ICategory)instance);

                    if (this.categoryInstance != null)
                    {
                        this.categoryInstance.Control.Dock = DockStyle.Fill;                     
                        this.navigationPage.Controls.Add(this.categoryInstance.Control);
                    }
                }
            }
        }

        public Category(string caption, SvgImage svgImage, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
        {            
            this.svgImage = svgImage;
        }

        public Category(string caption, Binary binary, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
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

        
        public ICategory Instance
        {
            get
            {
                return this.categoryInstance;
            }
        }

        public NavigationPage NavigationPage
        {
            get
            {
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
                    accordionControlElement.Text = this.caption;
                    accordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                    accordionControlElement.ImageOptions.SvgImage = this.svgImage;
                    accordionControlElement.Click += new EventHandler(this.accordionControlElement_Click);
                }
                return accordionControlElement;
            }
        }

        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            SendCategoryClicked();
        }

        public delegate void CategoryEventHandler(Category sender);
        public event CategoryEventHandler CategoryClick;

        protected virtual void SendCategoryClicked()
        {
            if ((this.CategoryClick != null))
            {
                this.CategoryClick(this);
            }
        }
    }
}
