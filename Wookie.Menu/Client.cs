namespace Wookie.Menu
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

        public Client(long pkClient, string connectionString, string name)
        {
            this.PKClient = pkClient;
            this.Name = name;
        }
    }
}
