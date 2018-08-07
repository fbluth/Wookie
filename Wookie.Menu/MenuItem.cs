using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
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
        private SqlConnection sqlConnection = null;
        private LabelControl lblStatus = null;
        
        public delegate void MenuItemEventHandler(MenuItem sender);
        public event MenuItemEventHandler MenuItemClick;
        #endregion

        #region Constructor
        public MenuItem(string text, string assemblyFile, SqlConnection sqlConnection, long? foreignKeyExternal)
        {   
            this.assemblyFile = assemblyFile;
            this.sqlConnection = sqlConnection;
            this.ForeignKeyExternal = foreignKeyExternal;
            AssemblyLoadResult result = AssemblyLoadResult.Undefined;

            this.InitializeAccordionControlElement();
            this.InitializeStatusLabel();
            result = this.InitializeAssembly();
            this.InitializeNavigationPage(result);

            this.AccordionControlElement.Text = text;
        }

        public MenuItem(string text, Image image, string assemblyFile, SqlConnection sqlConnection, long? foreignKeyExternal) : this(text, assemblyFile, sqlConnection, foreignKeyExternal)
        {
            this.AccordionControlElement.ImageOptions.Image = image;
        }

        public MenuItem(string text, Binary image, string assemblyFile, SqlConnection sqlConnection, long? foreignKeyExternal) : this(text, assemblyFile, sqlConnection, foreignKeyExternal)
        {
            this.AccordionControlElement.ImageOptions.Image = Converter.GetImageFromBinary(image);
        }
        #endregion

        #region Private functions
        private void InitializeStatusLabel()
        {
            if (this.lblStatus == null)
            {
                this.lblStatus = new LabelControl();
                this.lblStatus.Dock = DockStyle.Fill;
                this.lblStatus.AutoSizeMode = LabelAutoSizeMode.None;
                this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                this.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
                this.lblStatus.Appearance.FontSizeDelta = 8;
                this.lblStatus.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            }
        }

        private void InitializeNavigationPage(AssemblyLoadResult loadResult)
        {
            this.NavigationPage = new NavigationPage();
            Control control = null;

            switch (loadResult)
            {
                case AssemblyLoadResult.AssemblyFailed:
                    this.lblStatus.Text = "Could not create instance";
                    control = this.lblStatus;
                    break;
                case AssemblyLoadResult.AssemblyMissing:
                    this.lblStatus.Text = "No assembly defined";
                    control = this.lblStatus;
                    break;
                case AssemblyLoadResult.AssemblyNotFound:
                    this.lblStatus.Text = "File not found";
                    control = this.lblStatus;
                    break;
                case AssemblyLoadResult.AssemblyLoaded:
                    if (this.assemblyInstance != null && this.assemblyInstance.UserControl != null)
                    {
                        this.assemblyInstance.UserControl.Dock = DockStyle.Fill;
                        control = this.assemblyInstance.UserControl;
                    }
                    break;
                default:
                    this.lblStatus.Text = "Undefined error";
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

            if (!System.IO.File.Exists(path)) return AssemblyLoadResult.AssemblyNotFound;

            try
            {
                var assembly = Assembly.LoadFile(path);
                dynamic instance = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Category"));

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
                //this.AccordionControlElement.Style = ElementStyle.Item;
                //DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                //DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                //DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();

                //toolTipTitleItem1.Text = caption;
                //toolTipItem1.LeftIndent = 6;
                //toolTipItem1.Text = caption;
                //superToolTip1.Items.Add(toolTipTitleItem1);
                //superToolTip1.Items.Add(toolTipItem1);
                //accordionControlElement.SuperTip = superToolTip1;
            }
        }
        #endregion

        #region Properties
        public NavigationPage NavigationPage { get; private set; } = null;

        public AccordionControlElement AccordionControlElement { get; private set; } = null;

        public long? ForeignKeyExternal { get; private set; } = null;
        #endregion

        #region Events
        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            MenuItemClick?.Invoke(this);
        }
        #endregion
    }
}
