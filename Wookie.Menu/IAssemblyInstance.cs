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
        void Activate();
        SqlConnection SqlConnection { get; set; }
        XtraUserControl UserControl { get; }
        XtraUserControl DetailUserControl { get; set; }
        long? FKExternal { get; set; }
        List<long?> FKSelected { get; set; }
        Image Image { get; set; }
        String Caption { get; set; }
        String UniqueIdentifier { get; set; }

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
        public string Sender { get; set; } = null;
        public string Caption { get; set; } = null;
        public long? FKExternal { get; set; } = null;
        public List<long?> FKSelected { get; set; } = null;
        public XtraUserControl DetailUserControl { get; set; } = null;

        public SelectionEventArgs(string sender, string caption, long? fKExternal)
        {
            this.Sender = sender;
            this.Caption = caption;
            this.FKExternal = fKExternal;
        }
        public SelectionEventArgs(string sender, string caption, long? fkExternal, List<long?> fkSelected) : this(sender, caption, fkExternal)
        {
            this.FKSelected = fkSelected;
        }
        public SelectionEventArgs(string sender, string caption, long? fkExternal, List<long?> fkSelected, XtraUserControl userControl) : this(sender, caption, fkExternal, fkSelected)
        {
            this.DetailUserControl = userControl;
        }
    }
}