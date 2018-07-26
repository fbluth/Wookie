using System;
using System.Collections.Generic;

namespace Wookie.Menu.MenuManager
{
    [Serializable]
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
