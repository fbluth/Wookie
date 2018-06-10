using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class PageCollection:Dictionary<object, Page>
    {
        private MenuManager menuManager = null;

        public PageCollection(MenuManager menuManager)
        {
            this.menuManager = menuManager;              
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (Page page in this.Values) { page.MenuManager = value; }
            }
        }   
        
    }
}
