using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Drawing;
using System;

namespace Wookie.Menu
{
    public delegate void StatusBarEventHandler(StatusBarEventArgs args);

    public interface IAssemblyInstance
    {
        void Initialize(SqlConnection SqlConnection, long? foreignKeyExternal);
        SqlConnection SqlConnection { get; }
        XtraUserControl UserControl { get; }
        long? ForeignKeyExternal { get; }  
        Image Image { get; set; }
        String Caption { get; set; }
        event StatusBarEventHandler StatusBarChanged;        
    }

    public class StatusBarEventArgs : EventArgs
    {
        public StatusBarEventArgs(string text)
        {
            this.Text = text;
        }

        public string Text { get; set; } 
    }
}