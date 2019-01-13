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
using Wookie.Menu;

namespace Wookie.Project.Management.Control
{
    public partial class ucProjectManagement : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.ProjectManagementDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;
        #endregion

        #region Constructor
        public ucProjectManagement()
        {
            InitializeComponent();

            this.ucDefault1.Connect(
                this.groupControl1,
                this.gridView1,
                this.popupMenu1,
                this.tblProjectBindingSource);

            this.ucDefault1.RegisterPictureEdit(this.PicturePictureEdit);
            
            this.SetValidationRules();
        }
        #endregion

        public void Activate(Wookie.Tools.Controls.ModulData modulData)
        {
            this.modulData = modulData;
            this.ucDefault1.Initialize(modulData, true);
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
        private Database.tblProject SelectedProject
        {
            get { return this.tblProjectBindingSource.Current as Database.tblProject; }
        }
        private void SetValidationRules()
        {

        }

        private void Remove()
        {
            this.ucDefault1.PostEditor();

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedProject.Projectname);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblProjectBindingSource.Remove(this.SelectedProject);
            }
        }

        private void Add()
        {
            this.ucDefault1.PostEditor();
            Database.tblProject project = new Database.tblProject();
            int datasourceindex = this.tblProjectBindingSource.Add(project);
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(datasourceindex);
        }


        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.ProjectManagementDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tlkpProjectCategoryBindingSource.DataSource = this.dataContext.tlkpProjectCategory;
            this.tlkpProjectTypeBindingSource.DataSource = this.dataContext.tlkpProjectType;
            this.tblProjectBindingSource.DataSource = this.dataContext.tblProject;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Remove();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Add();
        }
    }
}
