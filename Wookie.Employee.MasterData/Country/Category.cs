using System;
using System.Data.SqlClient;
using System.Drawing;
using Wookie.Menu;
using DevExpress.XtraEditors;
using System.Collections.Generic;

namespace Wookie.Employee.MasterData.Country
{
    public class Category : Wookie.Menu.IAssemblyInstance, IDisposable
    {
        #region Variables
        private Country.ucCountry userControl = null;
        private Wookie.Tools.Controls.ModulData modulData = null;
        #endregion

        #region Constructor
        public Category()
        {
            this.modulData = new Wookie.Tools.Controls.ModulData();
            this.userControl = new Country.ucCountry();
        }
        #endregion

        #region Public Functions
        public void Activate()
        {
            this.userControl.Activate(this.modulData);
        }
        #endregion

        #region Events
        public event StatusBarEventHandler StatusBarChanged
        {
            add { this.userControl.StatusBarChanged += value; }
            remove { this.userControl.StatusBarChanged -= value; }
        }

        public event SelectionEventHandler SelectionChanged
        {
            add { this.userControl.SelectionChanged += value; }
            remove { this.userControl.SelectionChanged -= value; }
        }
        #endregion

        #region Public Properties
        public String UniqueIdentifier
        {
            get { return this.modulData.UniqueIdentifier; }
            set { this.modulData.UniqueIdentifier = value; }
        }

        public SqlConnection SqlConnection
        {
            get { return this.modulData.SqlConnection; }
            set { this.modulData.SqlConnection = value; }
        }

        public XtraUserControl UserControl
        {
            get { return this.userControl; }
        }

        public long? FKExternal
        {
            get { return this.modulData.FKExternal; }
            set { this.modulData.FKExternal = value; }
        }

        public List<long?> FKSelected
        {
            get { return this.modulData.FKSelected; }
            set { this.modulData.FKSelected = value; }
        }

        public Image Image
        {
            get { return userControl.Image; }
            set { this.userControl.Image = value; }
        }

        public String Caption
        {
            get { return userControl.Caption; }
            set { this.userControl.Caption = value; }
        }

        public String CaptionDetail
        {
            get { return userControl.CaptionDetail; }
            set { this.userControl.CaptionDetail = value; }
        }

        public XtraUserControl DetailUserControl
        {
            get { return this.modulData.DetailUserControl; }
            set { this.modulData.DetailUserControl = value; }
        }

        #endregion

        #region IDisposable Support
        private bool disposedValue = false; // Dient zur Erkennung redundanter Aufrufe.

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: verwalteten Zustand (verwaltete Objekte) entsorgen.
                    this.userControl.Dispose();
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.
                this.userControl = null;
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
}
