using System;
using System.Collections.Generic;

namespace Wookie.Menu.MenuManager
{
    [Serializable]
    public class ModulGroupCollection:Dictionary<object, ModulGroup>
    {
        private MenuManager menuManager = null;

        public ModulGroupCollection(MenuManager menuManager)
        {
            this.menuManager = menuManager;              
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (ModulGroup modulGroup in this.Values) { modulGroup.MenuManager = value; }
            }
        }           
    }
}
