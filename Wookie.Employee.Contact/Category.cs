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
            get { return new Control.ucContact(); }
        }
    }

    public static class ModulData
    {
        public static SqlConnection SqlConnectionClientDB;
        public static long? FKContactData;
    }
}
