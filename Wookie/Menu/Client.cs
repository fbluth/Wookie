using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu
{
    public class Client
    {
        private long pkClient;
        private System.Data.SqlClient.SqlConnection sqlConnection;

        public Client()
        {
        }

        public Client(long pkClient, System.Data.SqlClient.SqlConnection sqlConnection)
        {
            this.pkClient = pkClient;
            this.sqlConnection = sqlConnection;
        }

        public long PKClient
        {
            get { return this.pkClient; }
            set { this.pkClient = value; }
        }

        public System.Data.SqlClient.SqlConnection SqlConnection
        {
            get { return this.sqlConnection; }
            set { this.sqlConnection = value; }
        }
    }
}
