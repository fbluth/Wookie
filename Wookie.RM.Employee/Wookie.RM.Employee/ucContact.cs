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

namespace Wookie.RM.Employee
{
    public partial class ucContact : DevExpress.XtraEditors.XtraUserControl
    {
        public ucContact()
        {
            InitializeComponent();            
        }

        private void acEmployee_SelectedElementChanged(object sender, DevExpress.XtraBars.Navigation.SelectedElementChangedEventArgs e)
        {

        }
    }
}
