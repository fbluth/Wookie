using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wookie.Employee.Contact
{
    public class Category : Wookie.Menu.IAssemblyInstance, IDisposable
    {

        private XtraUserControl control = null;
        private ModulData modulData = null;

        public Category()
        {   
        }

        public void Initialize(SqlConnection sqlconnection, long? foreignKeyExternal)
        {
            this.modulData = new ModulData();
            this.modulData.SqlConnectionClientDB = sqlconnection;
            this.modulData.FKContactData = foreignKeyExternal;
        }

        
        public ModulData ModulData
        {
            get
            {
                return this.modulData;
            }
        }

        public SqlConnection SqlConnection
        {
            get
            {
                if (this.modulData != null)
                    return this.modulData.SqlConnectionClientDB;

                return null;
            }
        }

        public XtraUserControl UserControl
        {
            get
            {
                if (this.control == null)
                    control = new Control.ucContact2(modulData);
                return control;
            }
        }

        public long? ForeignKeyExternal
        {
            get
            {
                if (this.modulData != null)
                    return this.modulData.FKContactData;

                return null;
            }
        }

        public Image Image
        {
            get { return ((Control.ucContact2)this.UserControl).Image; }
            set { ((Control.ucContact2)this.UserControl).Image = value; }
        }


        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    this.control.Dispose();
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.
                this.control = null;
                this.modulData = null;
                disposedValue = true;
            }
        }

        // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
        // ~Category() {
        //   // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
        //   Dispose(false);
        // }

        // Dieser Code wird hinzugefügt, um das Dispose-Muster richtig zu implementieren.
        void IDisposable.Dispose()
        {
            // Ändern Sie diesen Code nicht. Fügen Sie Bereinigungscode in Dispose(bool disposing) weiter oben ein.
            Dispose(true);
            // TODO: Auskommentierung der folgenden Zeile aufheben, wenn der Finalizer weiter oben überschrieben wird.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }

    public class ModulData
    {
        public SqlConnection SqlConnectionClientDB;
        public long? FKContactData;
    }
}
