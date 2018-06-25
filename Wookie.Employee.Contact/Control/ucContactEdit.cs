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

        public long? PKContact
        {
            get { return this.pkContact; }
            set { this.pkContact = value; this.LoadData(value); }
        }

        public ucContactEdit()
        {
            InitializeComponent();            
        }

        private void LoadData(long? pkContact)
        {
            dataContext = new Database.ContactDataContext(ModulData.SqlConnectionClientDB);

            tlkpContactPrefixBindingSource.DataSource = dataContext.tlkpContactPrefix;
            tlkpContactCommunicationTypeBindingSource.DataSource = dataContext.tlkpContactCommunicationType;
            tblContactCommunicationBindingSource.DataSource = dataContext.tblContactCommunication;

            LoadImageComboBoxItems();

            /*tlkpCityBindingSource.DataSource = dataContext.tlkpCity;
            tlkpFederalStateBindingSource.DataSource = dataContext.tlkpFederalState;
            tlkpCountryBindingSource.DataSource = dataContext.tlkpCountry;
            
            */

            tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.PKContact == PKContact
                                                 select row;

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

    }
}
