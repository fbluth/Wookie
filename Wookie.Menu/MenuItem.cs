using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Wookie.Tools.Image;

namespace Wookie.Menu
{
    public class MenuItem
    {
        #region Variables
        private enum AssemblyLoadResult
        {
            Undefined = 0,
            AssemblyMissing = 1,
            AssemblyNotFound = 2,
            AssemblyFailed = 3,
            AssemblyLoaded = 4
        };
        private IAssemblyInstance assemblyInstance = null;
        private string assemblyFile = null;
        private string nameSpace = null;
        private SqlConnection sqlConnection = null;
        public Image Image { get; set; }
        public string Caption {get; set; }
        public delegate void MenuItemEventHandler(MenuItem sender);
        public event MenuItemEventHandler MenuItemClick;
        #endregion

        #region Constructor
        public MenuItem(string text, string assemblyFile, string nameSpace, SqlConnection sqlConnection, long? foreignKeyExternal)
        {   
            this.assemblyFile = assemblyFile;
            this.sqlConnection = sqlConnection;
            this.ForeignKeyExternal = foreignKeyExternal;
            this.nameSpace = nameSpace;

            AssemblyLoadResult loadResult = AssemblyLoadResult.Undefined;

            this.InitializeAccordionControlElement();
            loadResult = this.InitializeAssembly();
            this.InitializeNavigationPage(loadResult);

            if (this.assemblyInstance != null)
                this.assemblyInstance.Caption = text;
            
            this.AccordionControlElement.Text = text;
            this.Caption = text;
        }

        public MenuItem(string text, Image image, string assemblyFile, string nameSpace, SqlConnection sqlConnection, long? foreignKeyExternal) : this(text, assemblyFile, nameSpace, sqlConnection, foreignKeyExternal)
        {
            this.AccordionControlElement.ImageOptions.Image = image;
            this.Image = image;
            if (this.assemblyInstance != null) this.assemblyInstance.Image = image;            
        }

        public MenuItem(string text, Binary image, string assemblyFile, string nameSpace, SqlConnection sqlConnection, long? foreignKeyExternal) : this(text, assemblyFile, nameSpace, sqlConnection, foreignKeyExternal)
        {
            this.AccordionControlElement.ImageOptions.Image = Converter.GetImageFromBinary(image);
            this.Image = Converter.GetImageFromBinary(image); 
            if ( this.assemblyInstance != null) this.assemblyInstance.Image = Converter.GetImageFromBinary(image); 
        }
        #endregion

        #region Private functions
        private void InitializeNavigationPage(AssemblyLoadResult loadResult)
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
                    if (this.assemblyInstance != null && this.assemblyInstance.UserControl != null)
                    {
                        this.assemblyInstance.UserControl.Dock = DockStyle.Fill;
                        control = this.assemblyInstance.UserControl;
                    }
                    break;
                default:
                    control = new ucError("Undefined error");
                    break;
            }

            if (control != null) this.NavigationPage.Controls.Add(control);
        }

        private AssemblyLoadResult InitializeAssembly()
        {
            if (this.assemblyFile == null) return AssemblyLoadResult.AssemblyMissing;

            string assemblyFileDll = this.assemblyFile.ToLower().EndsWith(".dll") ? this.assemblyFile : (this.assemblyFile + ".dll");
            string assemblyFileWithoutDll = this.assemblyFile.ToLower().EndsWith(".dll") ? this.assemblyFile.Remove(this.assemblyFile.Length - 4, 4) : this.assemblyFile;
            string path = Application.StartupPath + "\\" + assemblyFileDll;
            string nameSpace = this.nameSpace == null ? assemblyFileWithoutDll : this.nameSpace;
            if (!System.IO.File.Exists(path)) return AssemblyLoadResult.AssemblyNotFound;

            try
            {
                var assembly = Assembly.LoadFile(path);
                dynamic instance = Activator.CreateInstance(assembly.GetType(nameSpace + ".Category"));

                if (instance != null)
                {
                    this.assemblyInstance = ((IAssemblyInstance)instance);
                    this.assemblyInstance.Initialize(this.sqlConnection, this.ForeignKeyExternal);

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

        #region Properties
        public NavigationPage NavigationPage { get; private set; } = null;

        public AccordionControlElement AccordionControlElement { get; private set; } = null;

        public long? ForeignKeyExternal { get; private set; } = null;

        public event StatusBarEventHandler StatusBarChanged
        {
            add { if (this.assemblyInstance != null) this.assemblyInstance.StatusBarChanged += value; }
            remove { if (this.assemblyInstance != null) this.assemblyInstance.StatusBarChanged -= value; }
        }
        #endregion

        #region Events
        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this);
        }
        #endregion
    }
}
