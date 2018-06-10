using System.Windows.Forms;
using DevExpress.XtraBars;
using Wookie.Menu;
using DevExpress.XtraBars.Navigation;
using Wookie.Menu.MenuManager;
using DevExpress.XtraEditors;

namespace Wookie.Controls
{
    public partial class frmWookieApp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private NavigationPage navigationPageLogin;
        private MenuManager menuManager = null;
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
            
            menuManager = new MenuManager(Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB, this.navigationFrame1);
            menuManager.ClientChanged += new ClientChangeEventHandler(this.ClientChange);
            menuManager.AddClientsToRibbon(this.ribbonControl1);
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
                menuManager.Remove(this.ribbonControl1, menuManager.Pages);
            menuManager.Add(this.ribbonControl1, e.Client.PKClient);
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
    }
}