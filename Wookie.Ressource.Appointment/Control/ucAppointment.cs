using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wookie.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.XtraScheduler;

namespace Wookie.Ressource.Appointment.Control
{
    public partial class ucAppointment : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.ContactDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;
        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;
        #endregion

        #region Constructor
        public ucAppointment(Wookie.Tools.Controls.ModulData modulData)
        {
            InitializeComponent();

            this.ucDefault1.RegisterBindingSource(this.tblContactAppointmentBindingSource);

            this.Initialize(this.modulData);            
        }
        #endregion

        public void Initialize(Wookie.Tools.Controls.ModulData modulData)
        {
            this.modulData = modulData;
            this.ucDefault1.Initialize(modulData, true);
            this.SetValidationRules();            
        }

        #region Public properties
        public System.Drawing.Image Image
        {
            get { return this.ucDefault1.Image; }
            set { this.ucDefault1.Image = value; }
        }

        public String Caption
        {
            get { return this.ucDefault1.Caption; }
            set { this.ucDefault1.Caption = value; }
        }

        public String CaptionDetail
        {
            get { return this.ucDefault1.CaptionDetail; }
            set { this.ucDefault1.CaptionDetail = value; }
        }
        #endregion

        private Database.tblContactAppointment SelectedAppointment
        {
            get { return this.tblContactAppointmentBindingSource.Current as Database.tblContactAppointment; }
        }

        private void SetValidationRules()
        {

        }

        private void LoadImageComboBoxItems()
        {
            
        }

        private void Remove()
        {
            this.ucDefault1.PostEditor();

            string msg = string.Format("Soll der Eintrag <b>\"{0}\"</b> gelöscht werden?", this.SelectedAppointment.Subject);

            if (XtraMessageBox.Show(msg, "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblContactAppointmentBindingSource.Remove(this.SelectedAppointment);
            }
        }

        private void Add()
        {
            this.ucDefault1.PostEditor();
            Database.tblContactAppointment contactAppointment = new Database.tblContactAppointment();
            contactAppointment.FKContact = this.modulData.FKExternal;
            contactAppointment.StartDateTime = System.DateTime.Now;
            contactAppointment.StartDateTime = System.DateTime.Now.AddHours(1);
            int datasourceindex = this.tblContactAppointmentBindingSource.Add(contactAppointment);            
        }

        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.ContactDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            

            this.tblContactAppointmentBindingSource.DataSource = from row in dataContext.tblContactAppointment
                                                      where row.FKContact == modulData.FKExternal
                                                      select row;


            this.LoadImageComboBoxItems();

            StatusBarChanged?.Invoke(new StatusBarEventArgs(System.String.Format("{0} Datensätze geladen", this.tblContactAppointmentBindingSource.Count)));

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Remove();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Add();
        }

        private void ucDefault1_DataRefresh(object sender, EventArgs e)
        {
            if (this.SelectedAppointment == null) return; 
        }

        private void tblContactAppointmentBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                ((Database.tblContactAppointment)tblContactAppointmentBindingSource[e.NewIndex]).FKContact = this.modulData.FKExternal;
            }
        }

        private void tblContactAppointmentBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
           
        }
    }
}