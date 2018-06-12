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
using Wookie.Employee.Contact;
using DevExpress.XtraBars.Ribbon;

namespace Wookie.Employee.Contact.Control
{
    public partial class ucContact : DevExpress.XtraEditors.XtraUserControl
    {
        private Database.ContactDataContext dataContext = null;

        public ucContact()
        {
            InitializeComponent();
            
            LoadData();            
        }

        private void LoadData()
        {
            dataContext = new Database.ContactDataContext(ModulData.SqlConnectionClientDB);

            tlkpCityBindingSource.DataSource = dataContext.tlkpCity;
            tlkpCityBindingSource1.DataSource = dataContext.tlkpCity;
            tlkpContactPrefixBindingSource.DataSource = dataContext.tlkpContactPrefix;
            tlkpFederalStateBindingSource.DataSource = dataContext.tlkpFederalState;
            tlkpCountryBindingSource.DataSource = dataContext.tlkpCountry;

            LoadImageComboBoxItems();

            tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.FKContactData == ModulData.FKContactData
                                                 select row;
            gridView1.BestFitColumns(true);
            tblContactBindingSource.MoveFirst();
        }

        private void LoadImageComboBoxItems()
        {
            // Prefix
            this.imgCollectionPrefix.Images.Clear();
            this.riLookupPrefix.Items.Clear();
            foreach (Database.tlkpContactPrefix prefix in tlkpContactPrefixBindingSource)
            {
                int index = this.imgCollectionPrefix.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(prefix.Picture));
                this.riLookupPrefix.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
            }

            // Country
            this.imgCollectionCountry.Images.Clear();
            this.riLookupCountry2.Items.Clear();
            foreach (Database.tlkpCountry country in tlkpCountryBindingSource)
            {
                int index = this.imgCollectionCountry.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(country.Picture));
                this.riLookupCountry2.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(country.Name, ((long)country.PKCountry), index));
            }
        }

        public RibbonControl RibbonControl
        {
            get { return this.ribbonControl1; }
        }

        private void biRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
               
                popupMenu1.ShowPopup(e.HitInfo.HitPoint);
            }
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (((PictureEdit)sender).EditValue is Image)
            {
                Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;
                c.Picture = Wookie.Tools.Image.Converter.GetBinaryFromImage(((PictureEdit)sender).EditValue as Image);
            }
        }

        private void tblContactBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;

            this.lblName.Text = ((string)(c.Surname + " " + c.Middlename)).Trim() + " " + c.Name;
            this.lblTitel.Text = ((string)(c.Title));
        }
    }
}
