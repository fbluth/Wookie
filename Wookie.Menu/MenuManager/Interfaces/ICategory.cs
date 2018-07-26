using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace Wookie.Menu.MenuManager
{
    public interface ICategory
    {
        void SetConnection(SqlConnection sqlconnection, long? fkExternal);
        XtraUserControl Control { get; }
    }
}
