using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraMap;
using Wookie.Menu;

namespace Wookie.Ressource.Contact.Control
{
    public partial class ucContact : XtraUserControl
    {
        #region Variables
        private Database.ContactDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;

        private static class IdPicture
        {
            public const string BusinessWoman = "0dde9ad1-52f7-47df-8a21-ad793be1f9d9";
            public const string BusinessMan = "2b00c30e-4d97-4a74-bdfb-894f77b3b56c";
            public const string InterSex = "d9593747-5848-440b-9d8c-f3dfaee43651";
        }
        private const string BingKey = "AqimjY1KQFxu9mGbYVY4bI7_l8-zyog7hKyTLbrQgxVcBxgS_6Dby16EgWwJQTVC";
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

            this.ucDefault1.PreparePictureEdit(this.picID);         
            this.ucDefault1.Initialize(this.modulData, true);

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

        #region Private properties
        /// <summary>
        /// Returns the database object from the binding source for the current selected contact. 
        /// </summary>
        private Database.tblContact SelectedContact
        {
            get { return this.tblContactBindingSource.Current as Database.tblContact; }
        }

        /// <summary>
        /// Returns the database object from the binding source for the current selected communication.
        /// </summary>
        private Database.tblContactCommunication SelectedContactCommunication
        {
            get { return this.tblContactCommunicationBindingSource.Current as Database.tblContactCommunication; }
        }

        /// <summary>
        /// Returns the concated name (Surname + Middlename + Name) from the current selected contact.        
        /// </summary>
        private string FullName
        {
            get
            {
                if (this.SelectedContact == null) return null;

                string fullname = null;

                fullname = this.SelectedContact.Surname != null ? this.SelectedContact.Surname.Trim() : "";
                fullname += this.SelectedContact.Middlename != null ? (" " + this.SelectedContact.Middlename.Trim()) : "";
                fullname += this.SelectedContact.Name != null ? (" " + this.SelectedContact.Name.Trim()) : "";

                return fullname;
            }
        }

        /// <summary>
        /// Returns the concated address (Zipcode + City + Street) from the current selected contact.        
        /// </summary>
        private string Address
        {
            get
            {
                if (this.SelectedContact == null) return "";

                string address = null;

                address = this.SelectedContact.tlkpCity.Zipcode.ToString() + ", ";
                address += this.SelectedContact.tlkpCity.Name + ", ";
                address += this.SelectedContact.Street;

                return address;
            }
        }

        /// <summary>
        /// Returns a default picture for a contact. The default picture will be from the assigned prefix. 
        /// If no prefix is selected the default picture will be from type business man.
        /// </summary>
        private System.Drawing.Bitmap DefaultIdPicture
        {
            get
            {
                if (this.SelectedContact == null) return ImageResource.businessman;

                System.Drawing.Bitmap picture = null;

                if (this.SelectedContact.tlkpContactPrefix != null &&
                        this.SelectedContact.tlkpContactPrefix.UniqueIdentifier.HasValue)
                {
                    switch (this.SelectedContact.tlkpContactPrefix.UniqueIdentifier.ToString().ToLower())
                    {
                        case IdPicture.BusinessWoman:
                            picture = ImageResource.businesswoman;
                            break;
                        case IdPicture.BusinessMan:
                            picture = ImageResource.businessman;
                            break;
                        case IdPicture.InterSex:
                            picture = ImageResource.intersex;
                            break;
                        default:
                            picture = ImageResource.businessman;
                            break;
                    }
                }
                else
                {
                    picture = ImageResource.businessman;
                }

                return picture;
            }
        }
        #endregion

        #region Private functions
        /// <summary>
        /// Sets validation rules for input fields.
        /// </summary>
        private void SetValidationRules()
        {

        }

        /// <summary>
        /// Load combobox items from database.
        /// </summary>
        private void SetImageComboBoxItems()
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

        /// <summary>
        /// Load data from database using a new data context.
        /// </summary>
        private void LoadDataFromDatabase()
        {
            this.dataContext = new Database.ContactDataContext(this.modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;

            this.tlkpCityBindingSource.DataSource = this.dataContext.tlkpCity;
            this.tlkpContactAddressTypeBindingSource.DataSource = this.dataContext.tlkpContactAddressType;
            this.tlkpContactPrefixBindingSource.DataSource = this.dataContext.tlkpContactPrefix;
            this.tlkpFederalStateBindingSource.DataSource = this.dataContext.tlkpFederalState;
            this.tlkpCountryBindingSource.DataSource = this.dataContext.tlkpCountry;
            this.tlkpContactCommunicationCategoryBindingSource.DataSource = this.dataContext.tlkpContactCommunicationCategory;
            this.tlkpContactCommunicationTypeBindingSource.DataSource = this.dataContext.tlkpContactCommunicationType;

            this.tblContactBindingSource.DataSource = from row in this.dataContext.tblContact
                                                      where row.FKContactData == this.modulData.FKExternal
                                                      select row;
        }

        /// <summary>
        /// Removes the currently selected contact from the datasource.
        /// </summary>
        private void RemoveContact()
        { 
            this.ucDefault1.PostEditor();

            string msg = string.Format("Soll der Eintrag <b>\"{0}\"</b> gelöscht werden?", this.FullName);

            if (XtraMessageBox.Show(msg, "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblContactBindingSource.Remove(this.SelectedContact);
            }
        }

        /// <summary>
        /// Adds a new contact to the datasource.
        /// </summary>
        private void AddContact()
        {
            this.ucDefault1.PostEditor();
            Database.tblContact contact = new Database.tblContact();
            contact.FKContactData = this.modulData.FKExternal;

            int datasourceindex = this.tblContactBindingSource.Add(contact);
            gridView2.FocusedRowHandle = gridView2.GetRowHandle(datasourceindex);
        }

        /// <summary>
        /// Adds a new communication object to the datasource.
        /// </summary>
        private void AddCommunication()
        {
            this.ucDefault1.PostEditor();
            Database.tblContactCommunication communication = new Database.tblContactCommunication();
            communication.FKContact = this.SelectedContact.PKContact;

            int datasourceindex = this.tblContactCommunicationBindingSource.Add(communication);
            gridView4.FocusedRowHandle = gridView4.GetRowHandle(datasourceindex);
        }

        /// <summary>
        /// Removes the currently selected communication object from the datasource.
        /// </summary>
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
        #endregion

        #region Events
        private void OnStatusBarChanged()
        {
            if (this.tblContactBindingSource == null) return;

            this.StatusBarChanged?.Invoke(new StatusBarEventArgs(
                System.String.Format("{0} Datensätze geladen", 
                this.tblContactBindingSource.Count)));
        }

        private void OnSelectionChanged()
        {
            List<long?> list = new List<long?>();
            list.Add(this.SelectedContact.PKContact);

            SelectionChanged?.Invoke(
                            new SelectionEventArgs(
                                "6a8de51f-1903-40cf-82c7-fdff9c3d704a",
                                this.FullName,
                                this.modulData.FKExternal,
                                list,
                                new Control.ucSelectedContact(this.SelectedContact)
                             ));
        }
        #endregion

        #region Handled events
        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.LoadDataFromDatabase();
            this.SetImageComboBoxItems();
            this.gridControl2.DataSource = this.tblContactBindingSource;
            this.gridView2.BestFitColumns();
            this.OnStatusBarChanged();
        }        

        private void ucDefault1_BeforeDataSave(object sender, EventArgs e)
        {
            if (this.SelectedContact != null && this.SelectedContact.Picture == null)
            {
                this.SelectedContact.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(DefaultIdPicture);
            }
        }

        private void ucDefault1_DataRefresh(object sender, EventArgs e)
        {
            if (this.SelectedContact == null) return;

            if (this.SelectedContact.tlkpCity != null)
                bingSearchDataProvider1.Search(this.Address);

            if (this.SelectedContact.tlkpContactPrefix != null)
                this.lblPrefix.Text = this.SelectedContact.tlkpContactPrefix.Name;

            this.lblFullname.Text = this.FullName;

            this.tblContactCommunicationBindingSource.DataSource = this.SelectedContact;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.RemoveContact();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddContact();
        }

        private void btnSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.OnSelectionChanged();
        }

        private void bingSearchDataProvider_SearchCompleted(object sender, BingSearchCompletedEventArgs e)
        {
            GeoPoint topLeft = e.RequestResult.SearchResults[0].Location;
            mapControl1.ZoomToRegion(topLeft, topLeft, 0.4);
        }
        
        private void btnNewComm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddCommunication();
        }

        private void btnDeleteComm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.RemoveCommunication();
        }
        #endregion
    }
}