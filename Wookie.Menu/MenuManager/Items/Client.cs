using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class Client
    {
        public long PKClient { get; set; }
        public System.Data.SqlClient.SqlConnection SqlConnection { get; set; }
        public string Name { get; set; }

        public Client()
        {
        }

        public Client(long pkClient, System.Data.SqlClient.SqlConnection sqlConnection, string name)
        {
            this.PKClient = pkClient;
            this.SqlConnection = sqlConnection;
            this.Name = name;
        }
    }
}
