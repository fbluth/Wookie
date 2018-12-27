using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using Wookie.Tools.Image;

namespace Wookie.Menu
{
    public class MenuItem
    {
        #region Variables
        public enum AssemblyLoadResult
        {
            Undefined = 0,
            AssemblyMissing = 1,
            AssemblyNotFound = 2,
            AssemblyFailed = 3,
            AssemblyLoaded = 4
        };
        public delegate void MenuItemEventHandler(MenuItem sender);
        public event MenuItemEventHandler MenuItemClick;
        public AssemblyLoadResult LoadResult { get; set; }
        #endregion

        #region Constructor
        public MenuItem(string caption)
        {
            this.InitializeAccordionControlElement();
            this.AccordionControlElement.Text = caption;            
        }

        public MenuItem(string caption, Image image) : this(caption)
        {
            this.AccordionControlElement.ImageOptions.Image = image;
        }

        public MenuItem(string caption, Binary image) : this(caption)
        {
            this.AccordionControlElement.ImageOptions.Image = Converter.GetImageFromBinary(image);
        }
        #endregion

        public void LoadAssembly(string assemblyFile, string nameSpace)
        {
            this.LoadResult = this.InitializeAssembly(assemblyFile, nameSpace);
            this.CreateNavigationPage(this.LoadResult);
        }

        #region Public Properties
        public string Caption
        {
            get { return this.AccordionControlElement.Text; }
            set { this.AccordionControlElement.Text = value; }
        }

        public Image Image
        {
            get { return this.AccordionControlElement.ImageOptions.Image; }
            set { this.AccordionControlElement.ImageOptions.Image = value; }
        }

        public IAssemblyInstance Assembly { get; private set; } = null;

        public NavigationPage NavigationPage { get; private set; } = null;

        public AccordionControlElement AccordionControlElement { get; private set; } = null;
        #endregion


        #region Private functions
        private void CreateNavigationPage(AssemblyLoadResult loadResult)
        {
            this.NavigationPage = new NavigationPage();
            Control control = null;

            switch (loadResult)
            {
                case AssemblyLoadResult.AssemblyFailed:
                    control = new ucError("Could not create instance");
                    break;
                case AssemblyLoadResult.AssemblyMissing:
                    control = new ucError("No assembly defined");                    
                    break;
                case AssemblyLoadResult.AssemblyNotFound:                    
                    control = new ucError("File not found");
                    break;
                case AssemblyLoadResult.AssemblyLoaded:
                    if (this.Assembly != null && this.Assembly.UserControl != null)
                    {
                        this.Assembly.UserControl.Dock = DockStyle.Fill;
                        control = this.Assembly.UserControl;
                    }
                    break;
                default:
                    control = new ucError("Undefined error");
                    break;
            }

            if (control != null) this.NavigationPage.Controls.Add(control);
        }

        private AssemblyLoadResult InitializeAssembly(string assemblyFile, string nameSpace)
        {
            if (assemblyFile == null || assemblyFile.Trim().Length == 0 ) return AssemblyLoadResult.AssemblyMissing;

            string assemblyFileDll = assemblyFile.Trim().ToLower().EndsWith(".dll") ? assemblyFile.Trim() : (assemblyFile + ".dll");
            string assemblyFileWithoutDll = assemblyFile.Trim().ToLower().EndsWith(".dll") ? assemblyFile.Trim().Remove(assemblyFile.Length - 4, 4) : assemblyFile;
            string path = Application.StartupPath + "\\" + assemblyFileDll;
            string realNameSpace = (nameSpace == null || nameSpace.Trim().Length == 0) ? assemblyFileWithoutDll : nameSpace.Trim();
            if (!System.IO.File.Exists(path)) return AssemblyLoadResult.AssemblyNotFound;

            try
            {
                var assembly = System.Reflection.Assembly.LoadFile(path);
                dynamic instance = Activator.CreateInstance(assembly.GetType(realNameSpace + ".Category"));

                if (instance != null)
                {
                    this.Assembly = ((IAssemblyInstance)instance);
                    this.Assembly.Caption = this.Caption;
                    this.Assembly.Image = this.Image;
                    
                    return AssemblyLoadResult.AssemblyLoaded;
                }
            }
            catch 
            {
                return AssemblyLoadResult.AssemblyFailed;
            }

            return AssemblyLoadResult.AssemblyFailed;            
        }

        private void InitializeAccordionControlElement()
        {
            if (this.AccordionControlElement == null)
            {
                this.AccordionControlElement = new AccordionControlElement();
                this.AccordionControlElement.Click += new EventHandler(this.accordionControlElement_Click);                
            }
        }
        #endregion

        #region Events        
        public event StatusBarEventHandler StatusBarChanged
        {
            add { if (this.Assembly != null) this.Assembly.StatusBarChanged += value; }
            remove { if (this.Assembly != null) this.Assembly.StatusBarChanged -= value; }
        }

        public event SelectionEventHandler SelectionChanged
        {
            add { if (this.Assembly != null) this.Assembly.SelectionChanged += value; }
            remove { if (this.Assembly != null) this.Assembly.SelectionChanged -= value; }
        }
        #endregion

        #region Handled Events
        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this);
        }
        #endregion
    }
}
