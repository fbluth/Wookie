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
using Wookie.Employee.Contact;

namespace Wookie.Employee.Contact.Control
{
    public partial class ucContact : DevExpress.XtraEditors.XtraUserControl
    {
        private Database.ContactDataContext dataContext = null;

        public ucContact()
        {
            InitializeComponent();
            dataContext = new Database.ContactDataContext(ModulData.SqlConnectionClientDB);
            tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.FKContactData == ModulData.FKContactData
                                                 select row;
            gridView1.BestFitColumns(true);
            string a = Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB.ConnectionString;
        }
    }
}
