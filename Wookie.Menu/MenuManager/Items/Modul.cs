using DevExpress.Utils.Svg;
using DevExpress.XtraBars.Navigation;
using System;
using System.Data.Linq;
using System.Drawing;
using Wookie.Tools.Image;

namespace Wookie.Menu.MenuManager
{
    public class Modul : IDisposable
    {
        private AccordionControlElement accordionControlElement = null;
        private MenuManager menuManager = null;
        private string caption = null;
        private Image image = null;
        private CategoryCollection categories = null;

        public Modul(string caption)
        {
            this.categories = new CategoryCollection(this.MenuManager, this);
            this.caption = caption;
        }

        public Modul(string caption, Image image) : this(caption)
        {
            this.image = image;
        }

        public Modul(string caption, Binary binary) : this(caption)
        {
            this.image = Converter.GetImageFromBinary(binary);
        }

        public string Caption
        {
            get { return this.caption; }
            set { if (accordionControlElement != null) accordionControlElement.Text = value; this.caption = value; }
        }

        public Image Image
        {
            get { return this.image; }
            set { if (this.accordionControlElement != null) accordionControlElement.ImageOptions.Image = value; this.image = value; }
        }

        public MenuManager MenuManager
        {
            get { return this.menuManager; }
            set { this.menuManager = value; }
        }

        public CategoryCollection Categories
        {
            get { return this.categories; }
        }

        public AccordionControlElement AccordionControlElement
        {
            get
            {
                if (accordionControlElement == null)
                {
                    accordionControlElement = new AccordionControlElement();
                    accordionControlElement.Text = this.caption;
                    accordionControlElement.Expanded = false;
                    accordionControlElement.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
                        new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
                    accordionControlElement.ImageOptions.Image = this.image;
                    

                    DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
                    DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
                    DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
                    toolTipTitleItem1.ImageOptions.Image = this.image;
                    toolTipTitleItem1.Text = caption;
                    //toolTipTitleItem1.ImageOptions.ImageSize = new System.Drawing.Size(25, 25);

                    toolTipItem1.LeftIndent = 6;
                    toolTipItem1.Text = caption;
                    
                    superToolTip1.Items.Add(toolTipTitleItem1);
                    superToolTip1.Items.Add(toolTipItem1);
                    accordionControlElement.SuperTip = superToolTip1;
                }
                return accordionControlElement;
            }
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
                    this.accordionControlElement.Dispose();
                    this.categories.Clear();
                }

                // TODO: nicht verwaltete Ressourcen (nicht verwaltete Objekte) freigeben und Finalizer weiter unten überschreiben.
                // TODO: große Felder auf Null setzen.
                this.accordionControlElement = null;
                this.categories = null;
                this.image = null;
                this.caption = null;
                this.menuManager = null;
                disposedValue = true;
            }
        }

        // TODO: Finalizer nur überschreiben, wenn Dispose(bool disposing) weiter oben Code für die Freigabe nicht verwalteter Ressourcen enthält.
        // ~Modul() {
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
