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
using System.Media;

namespace Wookie.Menu
{
    public partial class ucError : DevExpress.XtraEditors.XtraUserControl
    {
        public ucError(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
            this.Dock = DockStyle.Fill;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.IO.Stream s = Wookie.Menu.Properties.Resources.sw_sound_fatherandson;
            SoundPlayer player = new SoundPlayer(s);
            player.Play();
        }
    }
}
