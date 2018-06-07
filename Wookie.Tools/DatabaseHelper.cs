using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Tools
{
    public static class DatabaseHelper
    {
        private static System.Data.SqlClient.SqlConnection sqlConnectionMasterDB;

        public static System.Data.SqlClient.SqlConnection SqlConnectionMasterDB
        {
            get
            {
                if (sqlConnectionMasterDB == null)
                {
                    sqlConnectionMasterDB = new System.Data.SqlClient.SqlConnection(GetSQLConnectionString(""));
                }
                return sqlConnectionMasterDB;
            }
        }

        private static string GetSQLConnectionString(string filename)
        {
            return "Data Source=localhost;Initial Catalog=BS_PM_Master;Persist Security Info=True;User ID=sa;Password=19theta#01";
        }
    }
}
