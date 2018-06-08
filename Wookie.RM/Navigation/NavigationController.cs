using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Navigation;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;

namespace Wookie.RM.Navigation
{
    public class NavigationController
    {
        private Control.ucNavigation ucNavigation;
        private Dictionary<AccordionControlElement, NavigationPage> NavigationItemDictionary = new Dictionary<AccordionControlElement, NavigationPage>();
        private System.Data.SqlClient.SqlConnection sqlConnectionClientDB = null;
        private long? FKContactData = null;

        public NavigationController()
        {
            ucNavigation = new Control.ucNavigation();
        }

        public void Register(SqlConnection sqlConnectionClientDB, long? FKExternal)
        {
            this.sqlConnectionClientDB = sqlConnectionClientDB;
            this.FKContactData = FKExternal;
        }

        public void RegisterMenuItem(string caption, string assemblyFilename, DevExpress.Utils.Svg.SvgImage svgImage)
        {
            AccordionControlElement accordionControlElement = new AccordionControlElement();
            accordionControlElement.Name = caption;
            accordionControlElement.Text = caption;
            accordionControlElement.ImageOptions.SvgImage = svgImage;
            accordionControlElement.Click += new System.EventHandler(this.accordionControlElement_Click);
            //((System.ComponentModel.ISupportInitialize)(ucNavigation.AccordionControl)).BeginInit();
            ucNavigation.AccordionControl.Elements.Add(accordionControlElement);
            //((System.ComponentModel.ISupportInitialize)(ucNavigation.AccordionControl)).EndInit();

            NavigationPage navigationPage = new NavigationPage();

            if (assemblyFilename != null)
            {
                string assemblyFileDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename : (assemblyFilename + ".dll");
                string assemblyFileWithoutDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename.Remove(assemblyFilename.Length - 4, 4) : assemblyFilename;
                string path = Application.StartupPath + "\\" + assemblyFileDll;

                if (System.IO.File.Exists(path))
                {
                    var assembly = Assembly.LoadFile(path);
                    dynamic modulController = null;
                    modulController = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".ModulController"));
                    XtraUserControl usercontrol = modulController.Load(this.sqlConnectionClientDB, this.FKContactData);
                    usercontrol.Dock = DockStyle.Fill;
                    navigationPage.Controls.Add(usercontrol);
                }
            }

            ucNavigation.NavigationFrame.Pages.Add(navigationPage);
            NavigationItemDictionary.Add(accordionControlElement, navigationPage);
        }

        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            if (NavigationItemDictionary.ContainsKey((AccordionControlElement)sender))
                ucNavigation.NavigationFrame.SelectedPage = NavigationItemDictionary[(AccordionControlElement)sender];
        }

        public DevExpress.XtraEditors.XtraUserControl UserControl
        {
            get { return this.ucNavigation; }
        }
    }
}
