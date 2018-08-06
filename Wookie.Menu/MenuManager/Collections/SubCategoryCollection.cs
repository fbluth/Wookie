using System;
using System.Collections.Generic;

namespace Wookie.Menu.MenuManager
{
    [Serializable]
    public class SubCategoryCollection : Dictionary<object, SubCategory>
    {
        private MenuManager menuManager = null;
        private Category category = null;

        public SubCategoryCollection(MenuManager menuManager, Category category)
        {
            this.menuManager = menuManager;
            this.category = category;
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set
            {
                this.menuManager = value;
                foreach (SubCategory subCategory in this.Values) { subCategory.MenuManager = value; }
            }
        }
    }
}
