using DevExpress.Utils.Svg;
using System.Data.Linq;
using Wookie.Tools.Image;
using System.Windows.Forms;
using System.Reflection;
using System;
using System.Data.SqlClient;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System.Drawing;

namespace Wookie.Menu.MenuManager
{
    public class Category: IDisposable
    {
        private MenuManager menuManager = null;
        private string caption = null;
        private Image image = null;
        private AccordionControlElement accordionControlElement = null;
        private NavigationPage navigationPage = null;
        private ICategory categoryInstance = null;
        private SubCategoryCollection subCategories = null;

        public string AssemblyFile { get; }
        public SqlConnection SqlConnection {get; set;}
        public long? FKExternal { get; set; }

        public delegate void CategoryEventHandler(Category sender);
        public event CategoryEventHandler CategoryClick;

        public Category(string caption, string assemblyFile, string sqlconnectionString, long? fkExternal)
        {   
            this.caption = caption;
            this.AssemblyFile = assemblyFile;
            this.FKExternal = fkExternal;
            this.SqlConnection = new SqlConnection(sqlconnectionString);

            this.subCategories = new SubCategoryCollection(this.MenuManager, this);

            LabelControl lblStatus = new LabelControl();
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.AutoSizeMode = LabelAutoSizeMode.None;
            lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            lblStatus.Appearance.FontSizeDelta = 8;
            lblStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;

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
                   
                    if (instance != null)
                    {
                        ((ICategory)instance).SetConnection(this.SqlConnection, this.FKExternal);
                        this.categoryInstance = ((ICategory)instance);
                        this.categoryInstance.Control.Dock = DockStyle.Fill;
                        this.navigationPage.Controls.Add(this.categoryInstance.Control);
                    }
                    else
                    {
                        lblStatus.Text = "Could not create instance from file: " + path;
                        this.navigationPage.Controls.Add(lblStatus);
                    }
                }
                else
                {
                    lblStatus.Text = "File not found: " + path;
                    this.navigationPage.Controls.Add(lblStatus);
                }
            }
            else
            {
                lblStatus.Text = "No assembly defined in database.";
                this.navigationPage.Controls.Add(lblStatus);
            }
        }

        public Category(string caption, Image image, string assemblyFile, string sqlconnectionString, long? fkExternal) : this(caption, assemblyFile, sqlconnectionString, fkExternal)
        {            
            this.Image = image;
        }

        public Category(string caption, Binary binary, string assemblyFile, string sqlconnectionString, long? fkExternal) : this(caption, assemblyFile, sqlconnectionString, fkExternal)
        {
            this.Image = Converter.GetImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (accordionControlElement != null) accordionControlElement.Text = value; this.caption = value; }
        }

        public Image Image
        {
            get { return this.Image; }
            set { if (this.accordionControlElement != null) accordionControlElement.ImageOptions.Image = value; this.image = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; }
        }

        public SubCategoryCollection SubCategories
        {
            get { return this.subCategories; }
        }

        public ICategory Instance
        {
            get { return this.categoryInstance; }
        }

        public NavigationPage NavigationPage
        {
            get { return this.navigationPage; }
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
                        Style = ElementStyle.Item
                    };
                    accordionControlElement.ImageOptions.Image = this.image;
                    accordionControlElement.Click += new EventHandler(this.accordionControlElement_Click);
                    
                    DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
                    toolTipTitleItem1.ImageOptions.Image = this.image;
                    //toolTipTitleItem1.ImageOptions.ImageSize = new System.Drawing.Size(25, 25);
                    
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
                    // verwalteten Zustand (verwaltete Objekte) entsorgen.
                    this.accordionControlElement.Dispose();
                    this.navigationPage.Dispose();
                }

                // nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // große Felder auf Null setzen.
                this.accordionControlElement = null;
                this.navigationPage = null;
                this.categoryInstance = null;
                this.image = null;
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
            // Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }        
        #endregion
    }
}
