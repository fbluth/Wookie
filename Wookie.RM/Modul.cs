using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Wookie.Menu.MenuManager;

namespace Wookie.RM
{
    public class Modul 
    {
        private System.Data.SqlClient.SqlConnection sqlConnectionClientDB = null;
        private long? FKContactData = null;
        private Control.ucNavigation ucNavigation = null;

        public Modul()
        {
            ucNavigation = new Control.ucNavigation();
        }

        public void SetConnection(SqlConnection sqlconnection, long? fkExternal)
        {
            this.sqlConnectionClientDB = sqlconnection;
            this.FKContactData = fkExternal;
        }

        public AccordionControl AccordionControl
        {
            get { return this.ucNavigation.AccordionControl; }
        }
    }
}
