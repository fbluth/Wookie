using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wookie.Menu.MenuManager;

namespace Wookie.Menu.MenuManager
{
    public delegate void ClientChangeEventHandler(object sender, ClientChangeEventArgs e);


    public class ClientChangeEventArgs : EventArgs
    {
        private Client client = null;

        public ClientChangeEventArgs(Client client)
        {
            this.client = client;            
        }

        public ClientChangeEventArgs()
        {
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }        
    }
}
