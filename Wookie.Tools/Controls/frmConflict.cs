using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wookie.Tools.Controls
{
    public partial class frmConflict : DevExpress.XtraEditors.XtraForm
    {
        public frmConflict(ucConflicts ucConflicts)
        {
            InitializeComponent();
            ucConflicts.Dock = DockStyle.Fill;
            this.Controls.Add(ucConflicts);
        }
    }
}