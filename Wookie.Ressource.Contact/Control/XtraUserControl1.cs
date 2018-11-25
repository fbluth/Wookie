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

namespace Wookie.Ressource.Contact.Control
{
    public partial class XtraUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControl1()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.widgetView1.QueryControl += widgetView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void widgetView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            //if (e.Document == ucContactDocument)
            //    e.Control = new Wookie.Ressource.Contact.Control.ucContact();
            //if (e.Document == ucHeaderDocument)
            //    e.Control = new Wookie.Ressource.Contact.Control.ucHeader();
            //if (e.Control == null)
            //    e.Control = new System.Windows.Forms.Control();
        }

        private void XtraUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
