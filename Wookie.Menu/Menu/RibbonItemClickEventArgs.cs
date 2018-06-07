using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu
{
    public delegate void RibbonItemClickEventHandler(object sender, RibbonItemClickEventArgs e);

    public class RibbonItemClickEventArgs : EventArgs
    {
        private RibbonItem ribbonItem = null;

        public RibbonItemClickEventArgs(RibbonItem ribbonItem)
        {
            this.ribbonItem = ribbonItem;
        }   

        public RibbonItemClickEventArgs()
        {
        }

        public RibbonItem RibbonItem
        {
            get { return this.ribbonItem; }
            set { this.ribbonItem = value; }
        }       
    }
}
