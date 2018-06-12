using System.Windows.Forms;
using DevExpress.XtraBars;
using Wookie.Menu;
using DevExpress.XtraBars.Navigation;
using Wookie.Menu.MenuManager;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace Wookie.Controls
{
    public partial class frmWookieApp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private NavigationPage navigationPageLogin;
        private MenuManager menuManager = null;
        private DevExpress.XtraBars.Ribbon.RibbonForm parent = null;
        #endregion

        #region Constructor
        public frmWookieApp()
        {
            InitializeComponent();

            ucLogin loginControl = new ucLogin();
            loginControl.Dock = DockStyle.Fill;
            loginControl.Login += new Wookie.Controls.LoginEventHandler(this.loginControl_Login);
            this.navigationPageLogin = new NavigationPage();
            this.navigationPageLogin.Controls.Add(loginControl);
            
            menuManager = new MenuManager(Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB, this.navigationFrame1, this.ribbonControl1);
            menuManager.ClientChanged += new ClientChangeEventHandler(this.ClientChange);
            menuManager.AddClientsToRibbon();
        }

        public frmWookieApp(DevExpress.XtraBars.Ribbon.RibbonForm parent)
        {
            InitializeComponent();

            this.parent = parent;

            ucLogin loginControl = new ucLogin();
            loginControl.Dock = DockStyle.Fill;
            loginControl.Login += new Wookie.Controls.LoginEventHandler(this.loginControl_Login);
            this.navigationPageLogin = new NavigationPage();
            this.navigationPageLogin.Controls.Add(loginControl);

            menuManager = new MenuManager(Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB, this.navigationFrame1, this.ribbonControl1);
            menuManager.ClientChanged += new ClientChangeEventHandler(this.ClientChange);
            menuManager.AddClientsToRibbon();
        }
        #endregion

        #region Private methods
        private void Login()
        {
            if (!this.navigationFrame1.Pages.Contains(navigationPageLogin))
                this.navigationFrame1.Pages.Add(navigationPageLogin);
            this.navigationFrame1.SelectedPage = navigationPageLogin;
        }
        #endregion

        #region Events
        private void ClientChange(object sender, ClientChangeEventArgs e)
        {
            if (menuManager.Pages!= null && menuManager.Pages.Count>0)
                menuManager.Remove(menuManager.Pages);
            menuManager.MergeMenu(e.Client.PKClient);
            this.Text = "Wookie - " + e.Client.Name;
        }

        private void biLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Login();
        }

        private void loginControl_Login(object sender, LoginEventArgs e)
        {
            if (e.LoginSuccessful)
            {
                this.navigationFrame1.Pages.Remove(navigationPageLogin);                
            }
        }
        #endregion

        public void Duplicate(RibbonForm parent)
        {
            frmWookieApp frmWookieApp = new frmWookieApp(parent);
            frmWookieApp.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (parent != null)
            {
                ((frmWookieApp)this.parent).Duplicate(parent);
            }
            else
            {
                frmWookieApp frmWookieApp = new frmWookieApp(this);
                frmWookieApp.Show();
            }
            
        }
    }
}