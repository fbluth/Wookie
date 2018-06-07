using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Wookie.RM.Employee
{
    public class Startup
    {
        public XtraUserControl Create(SqlConnection sqlConnectionMasterDB, SqlConnection sqlConnectionClientDB, long? FKExternal)
        {
            MasterData.SqlConnectionMasterDB = sqlConnectionMasterDB;
            MasterData.SqlConnectionClientDB = sqlConnectionClientDB;
            MasterData.FKContactData = FKExternal;

            return new ucContact();
        }
    }

    public static class MasterData
    {
        public static SqlConnection SqlConnectionClientDB;
        public static SqlConnection SqlConnectionMasterDB;
        public static long? FKContactData;
    }
}
