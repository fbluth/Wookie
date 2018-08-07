using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Wookie.Menu
{
    public interface IAssemblyInstance
    {
        void Initialize(SqlConnection SqlConnection, long? foreignKeyExternal);
        SqlConnection SqlConnection { get; }
        XtraUserControl UserControl { get; }
        long? ForeignKeyExternal { get; }        
    }
}