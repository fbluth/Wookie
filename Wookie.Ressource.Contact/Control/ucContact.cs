using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using Wookie.Menu;
using Wookie.Ressource;

namespace Wookie.Ressource.Contact.Control
{
    public partial class ucContact : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.ContactDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        private const string BingKey = "AqimjY1KQFxu9mGbYVY4bI7_l8-zyog7hKyTLbrQgxVcBxgS_6Dby16EgWwJQTVC";
        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;

        #endregion

        #region Constructor
        public ucContact(Wookie.Tools.Controls.ModulData modulData)
        {
            InitializeComponent();

            this.modulData = modulData;

            this.ucDefault1.Connect(
                this.groupControl1,
                this.gridView2,
                this.popupMenu1,
                this.tblContactBindingSource);

            this.ucDefault1.Connect(
                this.goupControlCommunication,
                this.gridView4,
                this.popupMenu2,
                this.tblContactCommunicationBindingSource);

            //this.ucDefault1.RegisterBindingSource(this.tblContactCommunicationBindingSource);

            this.ucDefault1.PreparePictureEdit(this.picID);         
            this.ucDefault1.Initialize(modulData,true);

            this.SetValidationRules();
        }
        #endregion
       
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

        private Database.tblContact SelectedContact
        {
            get { return this.tblContactBindingSource.Current as Database.tblContact; }
        }

        private Database.tblContactCommunication SelectedContactCommunication
        {
            get { return this.tblContactCommunicationBindingSource.Current as Database.tblContactCommunication; }
        }

        private void SetValidationRules()
        {

        }

        private void LoadImageComboBoxItems()
        {
            // Prefix
            this.imgCollectionPrefix.Images.Clear();
            this.riLookupPrefix.Items.Clear();
            //this.cboPrefix.Properties.Items.Clear();
            foreach (Database.tlkpContactPrefix prefix in tlkpContactPrefixBindingSource)
            {
                int index = this.imgCollectionPrefix.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(prefix.Picture));
                this.riLookupPrefix.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
                //this.cboPrefix.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
            }

            // Country
            this.imgCollectionCountry.Images.Clear();
            this.riLookupCountry.Items.Clear();
            //this.cboCountry.Properties.Items.Clear();
            foreach (Database.tlkpCountry country in this.tlkpCountryBindingSource)
            {
                int index = this.imgCollectionCountry.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(country.Picture));
                this.riLookupCountry.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(country.Name, ((long)country.PKCountry), index));
                //this.cboCountry.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(country.Name, ((long)country.PKCountry), index));
            }

            // CommuicationType
            this.imgCollectionCommunicationType.Images.Clear();
            this.riContactCommunicationType.Items.Clear();            
            foreach (Database.tlkpContactCommunicationType type in this.tlkpContactCommunicationTypeBindingSource)
            {
                int index = this.imgCollectionCommunicationType.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(type.Picture));
                this.riContactCommunicationType.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(type.Description, ((long)type.PKContactCommunicationType), index));                
            }
        }

        private void Remove()
        { 
            this.ucDefault1.PostEditor();

            string msg = string.Format("Soll der Eintrag <b>\"{0}\"</b> gelöscht werden?", this.GetFullName());

            if (XtraMessageBox.Show(msg, "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblContactBindingSource.Remove(this.SelectedContact);
            }
        }

        private void Add()
        {
            this.ucDefault1.PostEditor();
            Database.tblContact contact = new Database.tblContact();
            contact.FKContactData = this.modulData.FKExternal;

            int datasourceindex = this.tblContactBindingSource.Add(contact);
            gridView2.FocusedRowHandle = gridView2.GetRowHandle(datasourceindex);
        }

        private void AddCommunication()
        {
            this.ucDefault1.PostEditor();
            Database.tblContactCommunication communication = new Database.tblContactCommunication();
            communication.FKContact = this.SelectedContact.PKContact;

            int datasourceindex = this.tblContactCommunicationBindingSource.Add(communication);
            gridView4.FocusedRowHandle = gridView4.GetRowHandle(datasourceindex);
        }

        private void RemoveCommunication()
        {
            this.ucDefault1.PostEditor();

            if (this.SelectedContactCommunication == null) return;

            string msg = string.Format("Soll der Eintrag <b>\"{0}\"</b> gelöscht werden?", this.SelectedContactCommunication.Communication);

            if (XtraMessageBox.Show(msg, "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblContactCommunicationBindingSource.Remove(this.SelectedContactCommunication);
            }
        }

        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.ContactDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tlkpCityBindingSource.DataSource = this.dataContext.tlkpCity;
            this.tlkpContactAddressTypeBindingSource.DataSource = this.dataContext.tlkpContactAddressType;
            this.tlkpContactPrefixBindingSource.DataSource = this.dataContext.tlkpContactPrefix;
            this.tlkpFederalStateBindingSource.DataSource = this.dataContext.tlkpFederalState;
            this.tlkpCountryBindingSource.DataSource = this.dataContext.tlkpCountry;
            this.tlkpContactCommunicationCategoryBindingSource.DataSource = this.dataContext.tlkpContactCommunicationCategory;
            this.tlkpContactCommunicationTypeBindingSource.DataSource = this.dataContext.tlkpContactCommunicationType;

            this.tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.FKContactData == modulData.FKExternal
                                                 select row;

            
            this.LoadImageComboBoxItems();

            this.gridControl2.DataSource = this.tblContactBindingSource;

            this.gridView2.BestFitColumns();

            StatusBarChanged?.Invoke(new StatusBarEventArgs(System.String.Format("{0} Datensätze geladen", this.tblContactBindingSource.Count)));
            
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
            if (this.SelectedContact == null) return;

            if (this.SelectedContact.tlkpCity != null)
                bingSearchDataProvider1.Search(this.SelectedContact.tlkpCity.Zipcode.ToString() + " " + this.SelectedContact.tlkpCity.Name + " " + this.SelectedContact.Street);

            if (this.SelectedContact.tlkpContactPrefix != null)
                this.lblPrefix.Text = this.SelectedContact.tlkpContactPrefix.Name;

            this.lblFullname.Text = this.GetFullName();

            this.tblContactCommunicationBindingSource.DataSource = this.SelectedContact;

        }

        private string GetFullName()
        {
            string fullname = null;
            fullname = this.SelectedContact.Surname != null ? this.SelectedContact.Surname.Trim() : "";
            fullname += this.SelectedContact.Middlename != null ? (" " + this.SelectedContact.Middlename.Trim()) : "";
            fullname += this.SelectedContact.Name != null ? (" " + this.SelectedContact.Name.Trim()) : "";

            return fullname;
        }

        private void bingSearchDataProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e)
        {
            GeoPoint topLeft = e.RequestResult.SearchResults[0].Location;
            mapControl1.ZoomToRegion(topLeft, topLeft, 0.4);
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SelectionChanged?.Invoke(new SelectionEventArgs("6a8de51f-1903-40cf-82c7-fdff9c3d704a", this.SelectedContact.PKContact, this.GetFullName()));
        }

        private void ucDefault1_BeforeDataSave(object sender, EventArgs e)
        {
            Guid businessWoman = new Guid("0dde9ad1-52f7-47df-8a21-ad793be1f9d9");
            Guid businessMan = new Guid("2b00c30e-4d97-4a74-bdfb-894f77b3b56c");
            Guid intersex = new Guid("d9593747-5848-440b-9d8c-f3dfaee43651");

            if (this.SelectedContact.Picture == null)
            {
                if (this.SelectedContact.tlkpContactPrefix.UniqueIdentifier.Value == businessWoman)
                    this.SelectedContact.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(ImageResource.businesswoman);
                if (this.SelectedContact.tlkpContactPrefix.UniqueIdentifier.Value == businessMan)
                    this.SelectedContact.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(ImageResource.businessman);
                if (this.SelectedContact.tlkpContactPrefix.UniqueIdentifier.Value == intersex)
                    this.SelectedContact.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(ImageResource.intersex);
            }
        }

        private void btnNewComm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddCommunication();
        }

        private void btnDeleteComm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.RemoveCommunication();
        }
    }
}