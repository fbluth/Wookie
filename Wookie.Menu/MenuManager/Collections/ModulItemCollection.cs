using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class ModulItemCollection: Dictionary<object,ModulItem>
    {
        private MenuManager menuManager = null;
        private Item item = null;        

        public ModulItemCollection(MenuManager menuManager, Item item)
        {
            this.menuManager = menuManager;
            this.item = item;                        
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (ModulItem modulItem in this.Values) { modulItem.MenuManager = value; modulItem.Item = item; }
            }
        }
    }
}
