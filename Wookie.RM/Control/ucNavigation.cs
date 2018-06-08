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

namespace Wookie.RM.Control
{
    public partial class ucNavigation : DevExpress.XtraEditors.XtraUserControl
    {
        public ucNavigation()
        {
            InitializeComponent();
        }

        public DevExpress.XtraBars.Navigation.AccordionControl AccordionControl
        {
            get { return this.accordionControl1; }
        }

        public DevExpress.XtraBars.Navigation.NavigationFrame NavigationFrame
        {
            get { return this.navigationFrame1; }
            set { this.navigationFrame1 = value; }
        }
    }
}
