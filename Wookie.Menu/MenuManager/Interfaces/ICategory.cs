using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Navigation;

namespace Wookie.Menu.MenuManager
{
    public interface ICategory
    {
        void SetConnection(SqlConnection sqlconnection, long? fkExternal);
        XtraUserControl Control { get; }
    }
}
