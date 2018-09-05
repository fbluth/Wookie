using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wookie.Tools.Validation
{

    public class RangeValidationRule : ValidationRule
    {
        private int _min;
        private int _max;

        public int Min { get { return _min; } set { _min = value; this.ErrorText = System.String.Format("Please enter a value between {0} and {1} or leave field empty.", this._min, this._max); } }
        public int Max { get { return _max; } set { _max = value; this.ErrorText = System.String.Format("Please enter a value between {0} and {1} or leave field empty.", this._min, this._max); } }

        public RangeValidationRule()
        {
            this.ErrorText = System.String.Format("Please enter a value between {0} and {1} or leave field empty.", Int32.MinValue, Int32.MaxValue);
        }

        public RangeValidationRule(int min, int max)
        {
            this.Min = min;
            this.Max = max;
        }

        public override bool Validate(Control control, object value)
        {
            if (value == null) return true;

            if (value is System.DBNull) return true;

            if (value is int)
            {
                if ((int)value >= Min && (int)value <= Max) return true;
            }

            return false;


        }
    }

}
