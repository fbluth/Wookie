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

        public RibbonItem()
        {            
        }

        public RibbonItem(long? fkExternal, string assemblyFilename, Client client)
        {
            this.fkExternal = fkExternal;
            this.assemblyFilename = assemblyFilename;
            this.client = new Client(client.PKClient, client.SqlConnection);
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public string AssemblyFilename
        {
            get { return this.assemblyFilename; }
            set { this.assemblyFilename = value; }
        }

        public long? FKExternal
        {
            get { return this.fkExternal; }
            set { this.fkExternal = value; }
        }

        public XtraUserControl UserControl
        {
            get
            {
                if (this.userControl == null)
                {
                    string assemblyFileDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename : (assemblyFilename + ".dll");
                    string assemblyFileWithoutDll = assemblyFilename.ToLower().EndsWith(".dll") ? assemblyFilename.Remove(assemblyFilename.Length - 4, 4) : assemblyFilename;
                    string path = Application.StartupPath + "\\" + assemblyFileDll;

                    if (System.IO.File.Exists(path))
                    {
                        var assembly = Assembly.LoadFile(path);
                        dynamic c = Activator.CreateInstance(assembly.GetType(assemblyFileWithoutDll + ".Startup"));
                        this.userControl = c.Create(Tools.Database.MasterDatabase.SqlConnectionMasterDB, client.SqlConnection, fkExternal);
                        this.userControl.Dock = DockStyle.Fill;
                    }
                }
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