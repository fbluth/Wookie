using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class CategoryCollection: Dictionary<object,Category>
    {
        private MenuManager menuManager = null;
        private Modul modul = null;
        
        public CategoryCollection(MenuManager menuManager, Modul modul)
        {
            this.menuManager = menuManager;
            this.modul = modul;        
        }        

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (Category category in this.Values) { category.MenuManager = value; }
            }
        }        
    }
}
