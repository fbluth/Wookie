using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class ItemCollection: Dictionary<object,Item>
    {
        private MenuManager menuManager = null;
        private Group group = null;
        private SubItem subItem = null;
        
        public ItemCollection(MenuManager menuManager, SubItem subItem)
        {
            this.menuManager = menuManager;
            this.subItem = subItem;        
        }

        public ItemCollection(MenuManager menuManager, Group group)
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
                foreach (Item item in this.Values) { item.MenuManager = value; item.Group = group; }
            }
        }        
    }
}
