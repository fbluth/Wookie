using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Wookie.Tools.Database
{
    public static class MasterDatabase
    {
        #region Variables
        private static SqlConnection sqlConnection = null;
        #endregion

        #region Public Properties
        public static SqlConnection SqlConnection
        {
            get
            {
                if (sqlConnection == null && KeyFileExists)
                {
                    string connectionString = GetSQLConnectionString(KeyFileName);
                    sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);
                }
                return sqlConnection;
            }
        }

        public static bool KeyFileExists
        {
            get { return System.IO.File.Exists(KeyFileName); }
        }

        public static string KeyFileName { get; } = Application.StartupPath + "\\Master.key";

        public static bool Connected
        {
            get
            {
                try
                {
                    SqlConnection.Open();
                    SqlConnection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
        #endregion;

        #region Private Properties
        private static string GetSQLConnectionString(string filename)
        {
            string connectionString = null;
            if (System.IO.File.Exists(filename))
            {
                connectionString = Cryptography.StringCipher.Decrypt(System.IO.File.ReadAllText(filename),"19theta#01");
            }
            return connectionString;
        }
        #endregion
    }
}
