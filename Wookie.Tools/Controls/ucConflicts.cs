using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Wookie.Tools.Controls
{
    public partial class ucConflicts : DevExpress.XtraEditors.XtraUserControl
    {
        public ucConflicts()
        {
            InitializeComponent();           
        }   
        
        public BindingSource Conflicts
        {
            get { return this.bindingSourceConflicts; }
            set { this.bindingSourceConflicts = value; }
        }
    }

    public class Conflict
    {
       
        public Conflict()
        {
        }

        public string Message { get; set; } = null;
        public System.Data.Linq.RefreshMode RefreshMode { get; set; } = System.Data.Linq.RefreshMode.OverwriteCurrentValues;
    }
}
