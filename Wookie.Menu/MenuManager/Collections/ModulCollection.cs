using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public class ModulCollection : Dictionary<object, Modul>
    {
        private MenuManager menuManager = null;
        private ModulGroup modulGroup = null;        

        public ModulCollection(MenuManager menuManager, ModulGroup modulGroup)
        {
            this.menuManager = menuManager;
            this.modulGroup = modulGroup;            
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (Modul modul in this.Values) { modul.MenuManager = value; }
            }
        }        
    }
}
