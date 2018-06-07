using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.Ribbon
{
    public delegate void ClientChangeEventHandler(object sender, ClientChangeEventArgs e);


    public class ClientChangeEventArgs : EventArgs
    {
        private BarItem barItem = null;
        private Client client = null;

        public ClientChangeEventArgs(Client client, BarItem barButtonItem)
        {
            this.client = client;
            this.barItem = barButtonItem;
        }

        public ClientChangeEventArgs()
        {
        }

        public Client Client
        {
            get { return this.client; }
            set { this.client = value; }
        }

        public BarItem BarItem
        {
            get { return this.barItem; }
            set { this.barItem = value; }
        }
    }
}
