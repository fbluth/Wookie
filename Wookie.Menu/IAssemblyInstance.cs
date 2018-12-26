using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Drawing;
using System;
using System.Collections.Generic;

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
        public string Text { get; set; } = null;

        public StatusBarEventArgs(string text)
        {
            this.Text = text;
        }        
    }

    public class SelectionEventArgs : EventArgs
    {
        public string Sender { get; set; } = null;
        public string Caption { get; set; } = null;
        public long? ForeignKeyExternal { get; set; } = null;
        public List<long?> ForeignKeys { get; set; } = null;
        public XtraUserControl XtraUserControl { get; set; } = null;

        public SelectionEventArgs(string sender, string caption, long? foreignKeyExternal)
        {
            this.Sender = sender;            
            this.Caption = caption;
            this.ForeignKeyExternal = foreignKeyExternal;
        }
        public SelectionEventArgs(string sender, string caption, long? foreignKeyExternal, List<long?> foreignKeys):this(sender, caption, foreignKeyExternal)
        {
            this.ForeignKeys = foreignKeys;
        }
        public SelectionEventArgs(string sender, string caption, long? foreignKeyExternal, List<long?> foreignKeys, XtraUserControl userControl) : this(sender, caption, foreignKeyExternal, foreignKeys)
        {
            this.XtraUserControl = userControl;
        }
    }
}