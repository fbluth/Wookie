using System.Windows.Forms;
using DevExpress.XtraBars;
using Wookie.Menu;
using DevExpress.XtraBars.Navigation;

namespace Wookie.Controls
{
    public partial class frmWookieApp : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Variables
        private Wookie.Menu.RibbonController ribbonController;
        private NavigationPage navLogin;
        #endregion

        #region Constructor
        public frmWookieApp()
        {
            InitializeComponent();

            ucLogin loginControl = new ucLogin();
            loginControl.Dock = DockStyle.Fill;
            loginControl.Login += new Wookie.Controls.LoginEventHandler(this.loginControl_Login);
            this.navLogin = new NavigationPage();
            this.navLogin.Controls.Add(loginControl);

            this.Login();
        }
        #endregion

        #region Private methods
        private void Login()
        {
            if (!this.navigationFrame1.Pages.Contains(navLogin))
                this.navigationFrame1.Pages.Add(navLogin);
            this.navigationFrame1.SelectedPage = navLogin;
        }

        private void CreateRibbon()
        {
            ribbonController = new Wookie.Menu.RibbonController(Tools.DatabaseHelper.SqlConnectionMasterDB);
            ribbonController.RibbonItemClick += new Menu.RibbonItemClickEventHandler(this.RibbonItemClick);
            ribbonController.ClientChanged += new Menu.ClientChangeEventHandler(this.ClientChange);
            ribbonController.AddClientsToRibbon(this.ribbonControl1);
        }
        #endregion

        #region Events
        private void RibbonItemClick(object sender, RibbonItemClickEventArgs e)
        {
            if (navigationFrame1.Pages.Contains(e.RibbonItem.NavigationPage))
                navigationFrame1.SelectedPage = e.RibbonItem.NavigationPage;
            else
            {
                navigationFrame1.Pages.Add(e.RibbonItem.NavigationPage);
                navigationFrame1.SelectedPage = e.RibbonItem.NavigationPage;
            }
        }

        private void ClientChange(object sender, ClientChangeEventArgs e)
        {            
            ribbonControl1.UnMergeRibbon();            
            ribbonControl1.MergeRibbon(ribbonController.CreateRibbon(e.Client.PKClient));
            this.Text = "Wookie - " + e.BarItem.Caption;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Login();
        }

        private void loginControl_Login(object sender, LoginEventArgs e)
        {
            if (e.LoginSuccessful)
            {
                this.navigationFrame1.Pages.Remove(navLogin);
                this.CreateRibbon();                
            }
        }
        #endregion
    }
}