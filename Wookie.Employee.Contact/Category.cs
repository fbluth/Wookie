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

        public Category()
        {   
        }

        public void SetConnection(SqlConnection sqlconnection, long? fkExternal)
        {
            ModulData.SqlConnectionClientDB = sqlconnection;
            ModulData.FKContactData = fkExternal;
            
        }

        public XtraUserControl Control
        {
            get
            {
                if (this.control == null)
                    control = new Control.ucContact();
                return control;
            }
        }

        public RibbonControl RibbonControl
        {
            get { return ((Control.ucContact)Control).RibbonControl; }
        }
    }

    public static class ModulData
    {
        public static SqlConnection SqlConnectionClientDB;
        public static long? FKContactData;
    }
}
