﻿using System;
using System.Data.SqlClient;
using System.Drawing;
using Wookie.Menu;
using DevExpress.XtraEditors;

namespace Wookie.Employee.MasterData.ContactPrefix
{
    public class Category : Wookie.Menu.IAssemblyInstance, IDisposable
    {
        #region Variables
        private XtraUserControl control = null;
        private Wookie.Tools.Controls.ModulData modulData = null;
        #endregion

        #region Constructor
        public Category()
        {
            this.modulData = new Wookie.Tools.Controls.ModulData();
        }
        #endregion

        #region Public Functions
        public void Initialize(SqlConnection sqlConnection, long? foreignKeyExternal)
        {
            this.modulData.SqlConnection = sqlConnection;
            this.modulData.FKExternal = foreignKeyExternal;
        }

        public event StatusBarEventHandler StatusBarChanged
        {
            add { ((ContactPrefix.ucMasterData)this.UserControl).StatusBarChanged += value; }
            remove { ((ContactPrefix.ucMasterData)this.UserControl).StatusBarChanged -= value; }
        }

        public event SelectionEventHandler SelectionChanged
        {
            add { ((ContactPrefix.ucMasterData)this.UserControl).SelectionChanged += value; }
            remove { ((ContactPrefix.ucMasterData)this.UserControl).SelectionChanged -= value; }
        }
        #endregion

        #region Public Properties

        public SqlConnection SqlConnection
        {
            get
            {
                if (this.modulData != null)
                    return this.modulData.SqlConnection;

                return null;
            }
        }

        public XtraUserControl UserControl
        {
            get
            {
                if (this.control == null)
                    control = new ContactPrefix.ucMasterData(modulData);
                return control;
            }
        }

        public long? ForeignKeyExternal
        {
            get
            {
                return this.modulData.FKExternal;
            }
            set
            {
                this.modulData.FKExternal = value;
            }
        }

        public Image Image
        {
            get { return ((ContactPrefix.ucMasterData)this.UserControl).Image; }
            set { ((ContactPrefix.ucMasterData)this.UserControl).Image = value; }
        }

        public String Caption
        {
            get { return ((ContactPrefix.ucMasterData)this.UserControl).Caption; }
            set { ((ContactPrefix.ucMasterData)this.UserControl).Caption = value; }
        }

        public String CaptionDetail
        {
            get { return ((ContactPrefix.ucMasterData)this.UserControl).CaptionDetail; }
            set { ((ContactPrefix.ucMasterData)this.UserControl).CaptionDetail = value; }
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
}