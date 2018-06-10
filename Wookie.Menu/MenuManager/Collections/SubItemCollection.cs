using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class SubItemCollection:Dictionary<object,SubItem>
    {
        private MenuManager menuManager = null;
        private Group group = null;
        
        public SubItemCollection(MenuManager menuManager, Group group)
        {
            this.menuManager = menuManager;
            this.group = group;        
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (SubItem item in this.Values) item.MenuManager = value;
            }
        }        
    }
}
