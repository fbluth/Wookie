using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Wookie.Menu;

namespace Wookie.Employee.MasterData.ContactPrefix
{
    public partial class ucMasterData : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.MasterDataDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;
        #endregion

        #region Constructor
        public ucMasterData()
        {
            InitializeComponent();

            this.ucDefault1.Connect(
                this.groupControl1,
                this.gridView1,
                this.popupMenu,
                this.tlkpContactPrefixBindingSource);

            this.ucDefault1.RegisterPictureEdit(this.PicturePictureEdit);

            this.SetValidationRules();
        }
        #endregion

        public void Activate(Wookie.Tools.Controls.ModulData modulData)
        {
            this.modulData = modulData;
            this.ucDefault1.Initialize(modulData);
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


        private Database.tlkpContactPrefix SelectedContactPrefix
        {
            get { return this.tlkpContactPrefixBindingSource.Current as Database.tlkpContactPrefix; }
        }

        private void SetValidationRules()
        {

        }

        private void RemoveClient()
        {
            this.ucDefault1.PostEditor();

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", SelectedContactPrefix.Name);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tlkpContactPrefixBindingSource.Remove(this.SelectedContactPrefix);
            }
        }

        private void AddClient()
        {
            this.ucDefault1.PostEditor();
            Database.tlkpContactPrefix prefix = new Database.tlkpContactPrefix();
            int datasourceindex = this.tlkpContactPrefixBindingSource.Add(prefix);
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(datasourceindex);
        }

        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.MasterDataDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tlkpContactPrefixBindingSource.DataSource = this.dataContext.tlkpContactPrefix;            
        }

        private void ucDefault1_DataRefresh(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.AddClient();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.RemoveClient();
        }
    }
}
