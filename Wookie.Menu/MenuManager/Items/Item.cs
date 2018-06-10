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
    public class Item
    {
        private BarButtonItem barButtonItem = null;
        private MenuManager menuManager = null;
        private string caption = null;
        private SvgImage svgImage = null;
        private ModulItemCollection modulItems = null;
        private NavigationPage navigationPage = null;
        private IModul modul = null;

        public Group Group { get; set; }
        public string AssemblyFile { get; }
        public SqlConnection SqlConnection {get; set;}
        public long? FKExternal { get; set; }
        
        public Item(string caption, string assemblyFile, SqlConnection sqlconnection, long? fkExternal)
        {
            this.modulItems = new ModulItemCollection(this.MenuManager, this);
            this.caption = caption;
            this.AssemblyFile = assemblyFile;
            this.FKExternal = fkExternal;
            this.SqlConnection = sqlconnection;

            if (this.AssemblyFile != null )
            {
                string assemblyFileDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile : (this.AssemblyFile + ".dll");
                string assemblyFileWithoutDll = this.AssemblyFile.ToLower().EndsWith(".dll") ? this.AssemblyFile.Remove(this.AssemblyFile.Length - 4, 4) : this.AssemblyFile;
                string path = Application.StartupPath + "\\" + assemblyFileDll;

                if (System.IO.File.Exists(path))
                {
                    var assembly = Assembly.LoadFile(path);
                    dynamic instance = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Modul"));
                    ((IModul)instance).SetConnection(this.SqlConnection, this.FKExternal);
                    this.modul = ((IModul)instance);
                }
            }
        }

        public Item(string caption, SvgImage svgImage, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
        {            
            this.svgImage = svgImage;
        }

        public Item(string caption, Binary binary, string assemblyFile, SqlConnection sqlconnection, long? fkExternal) : this(caption, assemblyFile, sqlconnection, fkExternal)
        {
            this.svgImage = Converter.GetSvgImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (barButtonItem != null) barButtonItem.Caption = value; this.caption = value; }
        }

        public SvgImage SvgImage
        {
            get { return this.svgImage; }
            set { if (this.barButtonItem != null) barButtonItem.ImageOptions.SvgImage = value; this.svgImage = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; this.modulItems.MenuManager = value; }
        }

        public ModulItemCollection ModulItems
        {
            get { return this.modulItems; }
        }

        public IModul Modul
        {
            get
            {
                return this.modul;
            }
        }

        public NavigationPage NavigationPage
        {
            get
            {
                if (this.navigationPage == null)
                {
                    this.navigationPage = new NavigationPage();
                    XtraUserControl control = this.modul.Control;
                    control.Dock = DockStyle.Fill;
                    this.navigationPage.Controls.Add(control);
                }
                return this.navigationPage;
            }
        }

        public BarButtonItem BarButtonItem
        {
            get
            {
                if (barButtonItem == null)
                {
                    barButtonItem = new BarButtonItem();
                    barButtonItem.ImageOptions.SvgImage = this.svgImage;
                    barButtonItem.Caption = this.caption;
                    BarButtonItem.ItemClick += new ItemClickEventHandler(this.barButtonItem_ItemClick);
                }
                return barButtonItem;
            }
        }

        private void barButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SendMenuItemClicked();
        }

        public delegate void MenuItemEventHandler(Item sender);
        public event MenuItemEventHandler MenuItemClick;

        protected virtual void SendMenuItemClicked()
        {
            if ((this.MenuItemClick != null))
            {
                this.MenuItemClick(this);
            }
        }
    }
}
