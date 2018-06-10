using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Menu.MenuManager
{
    public interface ICategory
    {
        void SetConnection(SqlConnection sqlconnection, long? fkExternal);
        XtraUserControl Control { get; }
    }
}
