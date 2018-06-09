using System;
using System.Drawing;

namespace Wookie.Controls
{
    public partial class ucLogin : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        public event LoginEventHandler Login;
        #endregion

        #region Constructor
        public ucLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void ucLogin_SizeChanged(object sender, EventArgs e)
        {
            int x = this.Width / 2 - panelControl1.Width / 2;
            int y = this.Height / 2 - panelControl1.Height / 2;

            this.panelControl1.Location = new Point(x<0?0:x,y<0?0:y);
        }

        private void txtPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoginEventArgs eventArgs = new LoginEventArgs(0, true);
            Login?.Invoke(this, eventArgs);
        }
        #endregion
    }

    public delegate void LoginEventHandler(object sender, LoginEventArgs e);

    public class LoginEventArgs : EventArgs
    {
        #region Variables
        private long fkUser;
        private bool loginSuccessful = false;
        #endregion

        #region Constructor
        public LoginEventArgs(long fkUser, bool loginSuccessful)
        {
            this.fkUser = fkUser;
            this.loginSuccessful = loginSuccessful;
        }

        public LoginEventArgs()
        {
        }
        #endregion

        #region Properties
        public long FKUser
        {
            get { return this.fkUser; }
            set { this.fkUser = value; }
        }

        public bool LoginSuccessful
        {
            get { return this.loginSuccessful; }
            set { this.loginSuccessful = value; }
        }
        #endregion
    }
}
