using System;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using Wookie.Menu;

namespace Wookie.Employee.Contact.Control
{
    public partial class ucContact2 : DevExpress.XtraEditors.XtraUserControl
    {
        private Database.ContactDataContext dataContext = null;
        private ucContactEdit ucContactEdit = null;
        private Wookie.Tools.Controls.ModulData modulData = null;
        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;

        public ucContact2(Wookie.Tools.Controls.ModulData modulData)
        {
            InitializeComponent();
            this.modulData = modulData;
            this.ucContactEdit = new ucContactEdit(modulData) {Dock = DockStyle.Fill};
            this.ucContactEdit.StatusChanged += new EventHandler(this.ucContactEdit_StatusChanged);
            this.navEdit.Controls.Add(this.ucContactEdit);

            this.LoadData();
            this.LoadImageComboBoxItems();

            this.navigationFrame1.SelectedPage = this.navSelect;
        }

        private void LoadData()
        {
            dataContext = new Database.ContactDataContext(modulData.SqlConnection);
            
            tlkpCityBindingSource.DataSource = dataContext.tlkpCity;
            tlkpContactPrefixBindingSource.DataSource = dataContext.tlkpContactPrefix;
            tlkpFederalStateBindingSource.DataSource = dataContext.tlkpFederalState;
            tlkpCountryBindingSource.DataSource = dataContext.tlkpCountry;
            tlkpContactCommunicationTypeBindingSource.DataSource = dataContext.tlkpContactCommunicationType;
            tlkpContactCommunicationCategoryBindingSource.DataSource = dataContext.tlkpContactCommunicationCategory;

            //tblContactCommunicationBindingSource.DataSource = dataContext.tblContact;

            tblContactBindingSource.DataSource = from row in dataContext.tblContact
                                                 where row.FKContactData == modulData.FKExternal
                                                 select row;

           // gridView1.BestFitColumns(true);
            //gridView2.BestFitColumns(true);
            tblContactBindingSource.MoveFirst();            
        }

        #region Public properties
        public Image Image
        {
            get { return null; }
            set {  }
        }

        public String Caption
        {
            get { return this.splitContainerControl1.Text; }
            set { this.splitContainerControl1.Text = value; }
        }

        public String CaptionDetail
        {
            get { return null; }
            set {  }
        }
        #endregion

        private void LoadImageComboBoxItems()
        {
            // Prefix
            this.imgCollectionPrefix.Images.Clear();
            this.riLookupPrefix.Items.Clear();
            this.cboPrefix.Properties.Items.Clear();
            foreach (Database.tlkpContactPrefix prefix in tlkpContactPrefixBindingSource)
            {
                int index = this.imgCollectionPrefix.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(prefix.Picture));
                this.riLookupPrefix.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
                this.cboPrefix.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(prefix.Name, ((long)prefix.PKContactPrefix), index));
            }

            // Country
            this.imgCollectionCountry.Images.Clear();
            this.riLookupCountry.Items.Clear();
            this.cboCountry.Properties.Items.Clear();
            foreach (Database.tlkpCountry country in tlkpCountryBindingSource)
            {
                int index = this.imgCollectionCountry.Images.Add(Wookie.Tools.Image.Converter.GetImageFromBinary(country.Picture));
                this.riLookupCountry.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(country.Name, ((long)country.PKCountry), index));
                this.cboCountry.Properties.Items.Add(new DevExpress.XtraEditors.Controls.ImageComboBoxItem(country.Name, ((long)country.PKCountry), index));
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

        private void RefreshDataOnScreen()
        {
            Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;
            if (c != null)
            {
                if (this.gridView1.GetSelectedRows().Count() > 0)
                    this.gridView1.RefreshRow(this.gridView1.GetSelectedRows()[0]);

                this.lblName.Text = ((string)(c.Surname + " " + c.Middlename)).Trim() + " " + c.Name;
                this.lblTitel.Text = ((string)(c.Title));

                tblContactCommunicationBindingSource.DataSource = c;
                gridView2.BestFitColumns(true);
            }
            else
            {
                this.lblName.Text = "Name";
                this.lblTitel.Text = "Title";

                tblContactCommunicationBindingSource.DataSource = null;
            }
        }

        private void btnContactEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditContact();            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            EditContact();            
        }

        private void EditContact()
        {
            Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;
            if (c == null) return;

            navigationFrame1.SelectedPage = navEdit;
            ucContactEdit.Edit(c);
        }

        private void NewContact()
        {
            navigationFrame1.SelectedPage = navEdit;
            ucContactEdit.New();
        }

        private void ucContactEdit_StatusChanged(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = navSelect;
            LoadData();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnContactDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            try
            {
                Database.tblContact c = (Database.tblContact)tblContactBindingSource.Current;
                if (c != null)
                {
                    dataContext.tblContact.DeleteOnSubmit(c);
                    dataContext.SubmitChanges(System.Data.Linq.ConflictMode.FailOnFirstConflict);
                }
            }
            catch (SqlException exception)
            {
                if (exception.Number == 547)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Datensatz wird noch von anderer Stelle referenziert und kann daher nicht gelöscht werden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show(exception.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                LoadData();
            }
        }

        private void btnContactNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewContact();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            switch (e.MenuType) 
            {
                case DevExpress.XtraGrid.Views.Grid.GridMenuType.Row:
                    popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                    break;
                case DevExpress.XtraGrid.Views.Grid.GridMenuType.User:
                    popupMenu1.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                    break;
            }
        }

        private void tblContactBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshDataOnScreen();
        }
    }
}