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
using System.IO;
using DevExpress.XtraPrinting;
using System.Diagnostics;

namespace Wookie.Project.Contract.Control
{
    public partial class ucProjectContract : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.ProjectContractDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public event StatusBarEventHandler StatusBarChanged;
        #endregion

        #region Constructor
        public ucProjectContract(Wookie.Tools.Controls.ModulData modulData)
        {
            InitializeComponent();

            this.modulData = modulData;

            this.ucDefault1.Connect(
                this.groupControl1,
                this.gridView1,
                this.popupMenu1,
                this.tblProjectContractBindingSource);

            //this.ucDefault1.PreparePictureEdit(this.PicturePictureEdit);
            this.ucDefault1.Initialize(modulData);

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
        #endregion

        private Database.tblProjectContract SelectedProjectContract
        {
            get { return this.tblProjectContractBindingSource.Current as Database.tblProjectContract; }
        }

        private void SetValidationRules()
        {

        }

        private void Remove()
        {
            this.ucDefault1.PostEditor();

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedProjectContract.ContractName);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.tblProjectContractBindingSource.Remove(this.SelectedProjectContract);
            }
        }

        private void Add()
        {
            this.ucDefault1.PostEditor();
            Database.tblProjectContract projectContract = new Database.tblProjectContract();
            int datasourceindex = this.tblProjectContractBindingSource.Add(projectContract);
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(datasourceindex);
        }

        private void Export()
        {
            var options = new XlsxExportOptionsEx();
            // Specify a name of the sheet in the created XLSX file.
            options.SheetName = "Leistungsvereinbarungen";
            gridControl1.ExportToXlsx("C:\\Temp\\grid-export.xlsx", options);
            Process.Start("C:\\Temp\\grid-export.xlsx");
        }


        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.ProjectContractDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tlkpProjectContractStatusBindingSource.DataSource = this.dataContext.tlkpProjectContractStatus;
            this.tlkpProjectContractTypeBindingSource.DataSource = this.dataContext.tlkpProjectContractType;
            this.tblClusterContractBindingSource.DataSource = this.dataContext.tblClusterContract;
            this.tblProjectContractBindingSource.DataSource = this.dataContext.tblProjectContract;
            this.gridView1.BestFitColumns();
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
            pdfViewer1.CloseDocument();
            
            if (this.SelectedProjectContract != null && this.SelectedProjectContract.ContractFile != null)
            {
                using (MemoryStream ms = new MemoryStream(this.SelectedProjectContract.ContractFile.ToArray()))
                {
                    
                    pdfViewer1.LoadDocument(ms);
                }
            }

            pdfViewer1.Refresh();
        }

        private void ContractFileButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (this.xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fsSource = new FileStream(this.xtraOpenFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {

                    // Read the source file into a byte array.
                    byte[] bytes = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        // Read may return anything from 0 to numBytesToRead.
                        int n = fsSource.Read(bytes, numBytesRead, numBytesToRead);

                        // Break when the end of the file is reached.
                        if (n == 0)
                            break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    this.SelectedProjectContract.ContractFile = new System.Data.Linq.Binary(bytes);
                }
            }
        }

        private void btnExportToExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Export();
        }
    }
}
