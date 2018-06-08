using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Employee.Contact
{
    public class ModulController
    {
        public XtraUserControl Load(SqlConnection sqlConnectionClientDB, long? fkExternal)
        {
            ModulData.SqlConnectionClientDB = sqlConnectionClientDB;
            ModulData.FKContactData = fkExternal;
            return new Control.ucContact();
        }
    }

    public static class ModulData
    {
        public static SqlConnection SqlConnectionClientDB;
        public static long? FKContactData;
    }
}
