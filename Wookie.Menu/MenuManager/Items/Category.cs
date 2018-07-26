using DevExpress.Utils.Svg;
using System.Data.Linq;
using Wookie.Tools.Image;
using System.Windows.Forms;
using System.Reflection;
using System;
using System.Data.SqlClient;
using DevExpress.XtraBars.Navigation;

namespace Wookie.Menu.MenuManager
{
    public class Category: IDisposable
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
                    accordionControlElement = new AccordionControlElement
                    {
                        Text = this.caption,
                        Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
                    };
                    accordionControlElement.ImageOptions.SvgImage = this.svgImage;
                    accordionControlElement.Click += new EventHandler(this.accordionControlElement_Click);
                    
                    DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
                    toolTipTitleItem1.ImageOptions.SvgImage = this.svgImage;
                    toolTipTitleItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
                    
                    toolTipTitleItem1.Text = caption;
                    toolTipItem1.LeftIndent = 6;
                    toolTipItem1.Text = caption;
                    superToolTip1.Items.Add(toolTipTitleItem1);
                    superToolTip1.Items.Add(toolTipItem1);
                    accordionControlElement.SuperTip = superToolTip1;
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

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    this.accordionControlElement.Dispose();
                    this.navigationPage.Dispose();
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.
                this.accordionControlElement = null;
                this.navigationPage = null;
                this.categoryInstance = null;
                this.svgImage = null;
                this.menuManager = null;
                this.caption = null;
                disposedValue = true;
            }
        }

        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        public void Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }        
        #endregion
    }
}
