using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Drawing;

namespace Wookie.Menu
{
    public interface IAssemblyInstance
    {
        void Initialize(SqlConnection SqlConnection, long? foreignKeyExternal);
        SqlConnection SqlConnection { get; }
        XtraUserControl UserControl { get; }
        long? ForeignKeyExternal { get; }  
        Image Image { get; set; }
    }
}