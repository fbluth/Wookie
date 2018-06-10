using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class GroupCollection : Dictionary<object, Group>
    {
        private MenuManager menuManager = null;
        private Page page = null;        

        public GroupCollection(MenuManager menuManager, Page page)
        {
            this.menuManager = menuManager;
            this.page = page;            
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (Group group in this.Values) { group.MenuManager = value; group.Page = page; }
            }
        }        
    }
}
