using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;

namespace Wookie.Menu.MenuManager
{
    public class SubCategory : Category
    {
        public SubCategory(string caption, string assemblyFile, string sqlconnectionString, long? fkExternal):base(caption, assemblyFile, sqlconnectionString, fkExternal)
        {
            
        }

        public SubCategory(string caption, Image image, string assemblyFile, string sqlconnectionString, long? fkExternal) : base(caption, assemblyFile, sqlconnectionString, fkExternal)
        {
            
        }

        public SubCategory(string caption, Binary binary, string assemblyFile, string sqlconnectionString, long? fkExternal) : base(caption, assemblyFile, sqlconnectionString, fkExternal)
        {
            
        }        
    }
}
