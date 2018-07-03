using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Employee.Contact
{
    public class Category : Wookie.Menu.MenuManager.ICategory
    {

        private XtraUserControl control = null;
        private ModulData modulData = null;

        public Category()
        {   
        }

        public void SetConnection(SqlConnection sqlconnection, long? fkExternal)
        {
            this.modulData = new ModulData();
            this.modulData.SqlConnectionClientDB = sqlconnection;
            this.modulData.FKContactData = fkExternal;            
        }

        public XtraUserControl Control
        {
            get
            {
                if (this.control == null)
                    control = new Control.ucContact2(modulData);
                return control;
            }
        }

        public ModulData ModulData
        {
            get
            {
                return this.modulData;
            }
        }
    }

    public class ModulData
    {
        public SqlConnection SqlConnectionClientDB;
        public long? FKContactData;
    }
}
