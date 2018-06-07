using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wookie.Controls
{
    

    public partial class ucLogin : DevExpress.XtraEditors.XtraUserControl
    {
        public event LoginEventHandler Login;

        public ucLogin()
        {
            InitializeComponent();
        }

        private void ucLogin_SizeChanged(object sender, EventArgs e)
        {
            int x = this.Width / 2 - panelControl1.Width / 2;
            int y = this.Height / 2 - panelControl1.Height / 2;

            this.panelControl1.Location = new Point(x<0?0:x,y<0?0:y);

        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoginEventArgs eventArgs = new LoginEventArgs(0,true);
            Login?.Invoke(this, eventArgs);
        }
    }

    public delegate void LoginEventHandler(object sender, LoginEventArgs e);

    public class LoginEventArgs : EventArgs
    {
        private long fkUser;
        private bool loginSuccessful = false;

        public LoginEventArgs(long fkUser, bool loginSuccessful)
        {
            this.fkUser = fkUser;
            this.loginSuccessful = loginSuccessful;
        }

        public LoginEventArgs()
        {
        }

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
    }
}
