using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Wookie.Menu.Ribbon
{
    public class RibbonItem
    {
        private long? fkExternal;
        private string assemblyFilename;
        private Client client = new Client();
        private XtraUserControl userControl = null;
        private NavigationPage navigationPage = null;
        private dynamic navigationController = null;

        public RibbonItem(long? fkExternal, string assemblyFilename, Client client)
        {
            this.fkExternal = fkExternal;
            this.assemblyFilename = assemblyFilename;
            this.client = new Client(client.PKClient, client.SqlConnection);

            if (assemblyFilename != null)
            {
                string assemblyFileDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename : (assemblyFilename + ".dll");
                string assemblyFileWithoutDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename.Remove(assemblyFilename.Length - 4, 4) : assemblyFilename;
                string path = Application.StartupPath + "\\" + assemblyFileDll;

                if (System.IO.File.Exists(path))
                {
                    var assembly = Assembly.LoadFile(path);
                    navigationController = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Navigation.NavigationController"));
                    navigationController.Register(this.client.SqlConnection, this.fkExternal);
                    this.userControl = navigationController.UserControl;
                    this.userControl.Dock = DockStyle.Fill;
                }
            }
        }

        public Client Client
        {
            get { return this.client; }            
        }

        public string AssemblyFilename
        {
            get { return this.assemblyFilename; }            
        }

        public long? FKExternal
        {
            get { return this.fkExternal; }            
        }

        public void RegisterMenuItem(string caption, string assemblyFilename, DevExpress.Utils.Svg.SvgImage svgImage)
        {
            if (navigationController != null) navigationController.RegisterMenuItem( caption,  assemblyFilename,  svgImage);
        }

        private XtraUserControl UserControl
        {
            get
            {   
                return this.userControl;
            }
        }

        public NavigationPage NavigationPage
        {
            get
            {
                if (this.navigationPage == null)
                {
                    this.navigationPage = new NavigationPage();
                    this.navigationPage.Controls.Add(UserControl);
                }
                return this.navigationPage;
            }
        }
    }
}