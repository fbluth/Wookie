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
using DevExpress.XtraGrid.Views.Grid;

namespace Wookie.Employee.Contact.Control
{
    public partial class ucContactEdit : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler StatusChanged;
        private Database.ContactDataContext dataContext = null;
        public long? pkContact;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public ucContactEdit(Wookie.Tools.Controls.ModulData modulData)
        {
            this.modulData = modulData;
            InitializeComponent();            
        }

        public void Edit(Database.tblContact contact)
        {
            if (contact == null) return;

            dataContext = new Database.ContactDataContext(modulData.SqlConnection);

            tlkpContactPrefixBindingSource.DataSource = dataContext.tlkpContactPrefix;
            tlkpContactCommunicationTypeBindingSource.DataSource = dataContext.tlkpContactCommunicationType;
            tlkpCityBindingSource.DataSource = dataContext.tlkpCity;
            tlkpFederalStateBindingSource.DataSource = dataContext.tlkpFederalState;
            tlkpCountryBindingSource.DataSource = dataContext.tlkpCountry;
            tlkpContactCommunicationCategoryBindingSource.DataSource = dataContext.tlkpContactCommunicationCategory;

            tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.PKContact == contact.PKContact
                                                 select row;

            tblContactCommunicationBindingSource.DataSource = dataContext.tblContactCommunication;

            LoadImageComboBoxItems();
            gridView1.BestFitColumns(true);
            
            tblContactBindingSource.MoveFirst();
        }

        public void New()
        {
            dataContext = new Database.ContactDataContext(modulData.SqlConnection);

            tlkpContactPrefixBindingSource.DataSource = dataContext.tlkpContactPrefix;
            tlkpContactCommunicationTypeBindingSource.DataSource = dataContext.tlkpContactCommunicationType;
            tblContactCommunicationBindingSource.DataSource = dataContext.tblContactCommunication;
            tlkpCityBindingSource.DataSource = dataContext.tlkpCity;
            tlkpFederalStateBindingSource.DataSource = dataContext.tlkpFederalState;
            tlkpCountryBindingSource.DataSource = dataContext.tlkpCountry;

            LoadImageComboBoxItems();

            Database.tblContact c = new Database.tblContact();
            c.FKContactData = modulData.FKExternal;

            tblContactBindingSource.DataSource = c;
            dataContext.tblContact.InsertOnSubmit(c);

            gridView1.BestFitColumns(true);
            tblContactBindingSource.MoveFirst();
        }


        private void LoadImageComboBoxItems()
        {
            // Prefix
            this.imgCollectionPrefix.Images.Clear();
            this.cboPrefix.Properties.Items.Clear();
            foreach (Database.tlkpContactPrefix prefix in tlkpContactPrefixBindingSource)
            {
                int index = this.imgCollectionPrefix.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(prefix.Picture));
                this.cboPrefix.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
            }

            // CommunicationyType
            this.imgCollectionCommunicationType.Images.Clear();
            this.riCommunicationType.Items.Clear();
            foreach (Database.tlkpContactCommunicationType commType in tlkpContactCommunicationTypeBindingSource)
            {
                int index = this.imgCollectionCommunicationType.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(commType.Picture));
                this.riCommunicationType.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(commType.Description, ((long)commType.PKContactCommunicationType), index));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StatusChanged?.Invoke(this, new EventArgs());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dataContext.SubmitChanges();
            StatusChanged?.Invoke(this, new EventArgs());
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (((PictureEdit)sender).EditValue is Image) 
            {
                Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;
                c.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(((PictureEdit)sender).EditValue as Image);
            }
        }

        private void gridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) !=
                  DialogResult.Yes)
                    return;
                GridView view = sender as GridView;
                view.DeleteRow(view.FocusedRowHandle);                
            }
        }

        

        

        private void tlkpCitytlkpFederalStatePKFederalStateLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            //Federal State
            
            //Database.tlkpFederalState tlkpFederalState = (Database.tlkpFederalState)cboFederalstate.EditValue;
            //tlkpCityBindingSource.DataSource = from row in dataContext.tlkpCity
            //                                   where row.FKFederalState == tlkpFederalState.PKFederalState
            //                                   select row;
            //this.cboZipCode.Properties.DataSource = tlkpCityBindingSource.DataSource;
            //this.cboCity.Properties.DataSource = tlkpCityBindingSource.DataSource;
        }

        private void cboCountry_EditValueChanged(object sender, EventArgs e)
        {
            //Country
            
            //Database.tlkpCountry tlkpCountry = (Database.tlkpCountry)cboCountry.EditValue;
            //tlkpFederalStateBindingSource.DataSource = from row in dataContext.tlkpFederalState
            //                                   where row.FKCountry == tlkpCountry.PKCountry
            //                                   select row;
            //this.cboFederalstate.Properties.DataSource = tlkpFederalStateBindingSource.DataSource;
        }
    }
}
