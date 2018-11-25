using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Drawing;
using System;

namespace Wookie.Menu
{
    public delegate void StatusBarEventHandler(StatusBarEventArgs args);
    public delegate void SelectionEventHandler(SelectionEventArgs args);

    public interface IAssemblyInstance
    {
        void Initialize(SqlConnection SqlConnection, long? foreignKeyExternal);
        SqlConnection SqlConnection { get; }
        XtraUserControl UserControl { get; }
        long? ForeignKeyExternal { get; set; }  
        Image Image { get; set; }
        String Caption { get; set; }
        String CaptionDetail { get; set; }
        event StatusBarEventHandler StatusBarChanged;
        event SelectionEventHandler SelectionChanged;
    }

    public class StatusBarEventArgs : EventArgs
    {
        public StatusBarEventArgs(string text)
        {
            this.Text = text;
        }

        public string Text { get; set; } 
    }

    public class SelectionEventArgs : EventArgs
    {
        public string Uniqueidentifer { get; set; } = null;
        public string Caption { get; set; } = null;
        public long? ForeignKeyExternal { get; set; } = null;

        public SelectionEventArgs(string uniqueidentifier, long? foreignKeyExternal, string caption)
        {
            this.Uniqueidentifer = uniqueidentifier;
            this.ForeignKeyExternal = foreignKeyExternal;
            this.Caption = caption;
        }        
    }
}