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
using System.Data.SqlClient;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraGrid.Views.Grid;
using Wookie.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Svg;

namespace Wookie.Master.Menu.Control
{
    public partial class ucMenu : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.MenuDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;
        private DevExpress.Utils.Menu.DXMenuItem item = new DevExpress.Utils.Menu.DXMenuItem("Icons");
        private DevExpress.Utils.Menu.DXMenuItem item2 = new DevExpress.Utils.Menu.DXMenuItem("Icons");

        public event StatusBarEventHandler StatusBarChanged;
        #endregion

        #region Constructor
        public ucMenu(Wookie.Tools.Controls.ModulData modulData)
        {
            InitializeComponent();
            this.modulData = modulData;
            this.ucDefault1.RegisterGridView(this.gridViewClient);
            this.ucDefault1.RegisterTreeList(this.treeMenu);
            this.ucDefault1.RegisterBindingSource(this.tsysClientBindingSource);
            this.ucDefault1.RegisterBindingSource(this.tsysClientElementBindingSource);
            this.ucDefault1.ConnectGroupControlWithGridView(groupControlClient, gridViewClient);
            this.ucDefault1.ConnectGroupControlWithTreeList(groupControlMenu, treeMenu);
            this.ucDefault1.Initialize(modulData);
            this.SetValidationRules();

            this.item.Click += Item_Click;
            this.item2.Click += Item2_Click;
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

        #region Private properties
        private Database.tsysClient SelectedClient
        {
            get { return this.tsysClientBindingSource.Current as Database.tsysClient; }
        }

        private Database.tsysClientElement SelectedClientElement
        {
            get { return this.tsysClientElementBindingSource.Current as Database.tsysClientElement; }
        }

        private SqlConnectionStringBuilder SqlConnectionStringBuilder
        {
            get
            {
                SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();

                if (this.SelectedClient != null)
                {

                    if (this.SelectedClient.Datasource != null) connBuilder.DataSource = this.SelectedClient.Datasource;
                    if (this.SelectedClient.UserID != null) connBuilder.UserID = this.SelectedClient.UserID;
                    if (this.SelectedClient.Password != null) connBuilder.Password = this.SelectedClient.Password;
                    if (this.SelectedClient.InitialCatalog != null) connBuilder.InitialCatalog = this.SelectedClient.InitialCatalog;
                    if (this.SelectedClient.FailoverPartner != null) connBuilder.FailoverPartner = this.SelectedClient.FailoverPartner;

                    if (this.SelectedClient.Encrypt.HasValue) connBuilder.Encrypt = this.SelectedClient.Encrypt.Value;
                    if (this.SelectedClient.PersistSecurityInfo.HasValue) connBuilder.PersistSecurityInfo = this.SelectedClient.PersistSecurityInfo.Value;
                    if (this.SelectedClient.ConnectTimeout.HasValue) connBuilder.ConnectTimeout = this.SelectedClient.ConnectTimeout.Value;
                    if (this.SelectedClient.ConnectRetryCount.HasValue) connBuilder.ConnectRetryCount = this.SelectedClient.ConnectRetryCount.Value;
                    if (this.SelectedClient.ConnectRetryInterval.HasValue) connBuilder.ConnectRetryInterval = this.SelectedClient.ConnectRetryInterval.Value;
                    if (this.SelectedClient.PacketSize.HasValue) connBuilder.PacketSize = this.SelectedClient.PacketSize.Value;
                    if (this.SelectedClient.Pooling.HasValue) connBuilder.Pooling = this.SelectedClient.Pooling.Value;
                }

                return connBuilder;
            }
        }
        #endregion

        #region Private functions
        private void SetValidationRules()
        {
            this.ucDefault1.ValidationProvider.SetValidationRule(PacketSizeTextEdit, new Wookie.Tools.Validation.RangeValidationRule(512, 32678));
            this.ucDefault1.ValidationProvider.SetValidationRule(ConnectRetryCountTextEdit, new Wookie.Tools.Validation.RangeValidationRule(0, 255));
            this.ucDefault1.ValidationProvider.SetValidationRule(ConnectRetryIntervalTextEdit, new Wookie.Tools.Validation.RangeValidationRule(0, 60));
        }

        private void TestConnection()
        {
            try
            {
                this.ucDefault1.PostEditor();

                if (dxValidationProvider1.Validate())
                {
                    //this.ChangeStatusBarText("Please wait. Testing connection.");

                    this.splashScreenManager1.ShowWaitForm();
                    this.splashScreenManager1.SetWaitFormCaption("Teste Verbindung zu Datenbank");
                    this.splashScreenManager1.SetWaitFormDescription("Bitte warten");

                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlConnectionStringBuilder.ConnectionString))
                    {
                        // Überprüfe ob eine Verbindung zur Datenbank möglich ist.
                        sqlConnection.Open();
                        sqlConnection.Close();

                        //this.ChangeStatusBarText("Connection successfull.");

                        if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();

                        XtraMessageBox.Show("Connection successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
                //this.ChangeStatusBarText("Connection not successful.");
                XtraMessageBox.Show("Connection not successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveClient()
        {
            if (this.SelectedClient == null) return;

            this.ucDefault1.PostEditor();

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedClient.Name);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                foreach (Database.tsysClientElement element in this.SelectedClient.tsysClientElement)
                    if (this.dataContext.tsysClientElement.Contains(element))
                        this.dataContext.tsysClientElement.DeleteOnSubmit(element);

                this.tsysClientBindingSource.Remove(this.SelectedClient);
            }
        }

        private void AddClient()
        {
            this.ucDefault1.PostEditor();
            Database.tsysClient client = new Database.tsysClient();
            int datasourceindex = this.tsysClientBindingSource.Add(client);
            gridViewClient.FocusedRowHandle = gridViewClient.GetRowHandle(datasourceindex);
        }

        private void RemoveNode()
        {
            if (this.SelectedClientElement == null) return;

            this.ucDefault1.PostEditor();

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedClientElement.Name);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                using (CustomNodeOperation operation = new CustomNodeOperation(treeMenu.FocusedNode))
                {
                    this.treeMenu.NodesIterator.DoLocalOperation(operation, treeMenu.Nodes);
                    operation.ClientElements.Add(this.SelectedClientElement);

                    this.treeMenu.BeginUpdate();
                    this.treeMenu.SuspendLayout();

                    foreach (Database.tsysClientElement element in operation.ClientElements)
                    {
                        this.tsysClientElementBindingSource.Remove(element);

                        if (this.dataContext.tsysClientElement.Contains(element))
                            this.dataContext.tsysClientElement.DeleteOnSubmit(element);
                    }

                    this.treeMenu.EndUpdate();
                    this.treeMenu.ResumeLayout();
                }
            }
        }

        private void AddNode()
        {
            if (this.SelectedClient == null) return;

            this.ucDefault1.PostEditor();

            Database.tsysClientElement element = new Database.tsysClientElement();
            element.ID = Guid.NewGuid();
            this.tsysClientElementBindingSource.Add(element);
        }
        #endregion

        #region Events
        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.MenuDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tsysClientBindingSource.DataSource = this.dataContext.tsysClient;
            this.tsysClientElementBindingSource.DataSource = this.SelectedClient;
        }

        private void ucDefault1_DataRefresh(object sender, EventArgs e)
        {
            if (this.SelectedClient != null)
                this.tsysClientElementBindingSource.DataSource = this.SelectedClient;
            else
                this.tsysClientElementBindingSource.Clear();            
        }

        private void groupControlClient_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (groupControlClient.CustomHeaderButtons.IndexOf(e.Button))
            {
                case 0: //Add
                    this.AddClient();
                    break;
                case 1: //Remove
                    this.RemoveClient();
                    break;
                case 2: //Up  
                    this.TestConnection();
                    break;
                case 3: // Down
                    break;
                case 4: // TestConnection
                    this.TestConnection();
                    break;
                case 5: // Multiselect
                    this.gridViewClient.OptionsSelection.MultiSelect = !this.gridViewClient.OptionsSelection.MultiSelect;
                    this.gridViewClient.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
                    break;
            }
        }

        private void groupControlMenu_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (groupControlMenu.CustomHeaderButtons.IndexOf(e.Button))
            {
                case 0: //Add
                    this.AddNode();
                    break;
                case 1: //Remove
                    this.RemoveNode();
                    break;
            }
        }

        private void gridClient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) this.RemoveClient();
        }

        private void treeMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) this.RemoveNode();
        }

        private void btnEditPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            PasswordTextEdit.Properties.UseSystemPasswordChar = !PasswordTextEdit.Properties.UseSystemPasswordChar;
        }

        private void picMenu_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var data = e.Value as System.Data.Linq.Binary;
            if (data != null)
            {
                e.Handled = true;
                e.Value = data;
            }
        }

        private void picMenu_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            if (e.Value is DBNull || e.Value is System.Data.Linq.Binary)
                return;
            
            if (e.Value is System.Drawing.Image)
            {
                //e.Value = new System.Data.Linq.Binary((byte[])e.Value);
                e.Value = Wookie.Tools.Image.Converter.GetBinaryFromImage((Image)e.Value);
                e.Handled = true;
            }
            else if (e.Value is SvgImage)
            {
                e.Value = Wookie.Tools.Image.Converter.GetBinaryFromSvgImage((SvgImage)e.Value);
                e.Handled = true;
            }
        }

        private void picMenu_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            if (!e.PopupMenu.Items.Contains(item))
                e.PopupMenu.Items.Add(item);
        }

        private void picMenu1_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
        {
            if (!e.PopupMenu.Items.Contains(item2))
                e.PopupMenu.Items.Add(item2);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            using (Wookie.Tools.ImagePicker.ImagePicker imagePicker = new Tools.ImagePicker.ImagePicker())
            {
                if (tsysClientElementBindingSource.Current != null && imagePicker.ShowDialog() == DialogResult.OK)
                {
                    Database.tsysClientElement element = (Database.tsysClientElement)tsysClientElementBindingSource.Current;
                    element.Image = Wookie.Tools.Image.Converter.GetBinaryFromImage(imagePicker.SelectedImage);
                }
            }
        }

        private void Item2_Click(object sender, EventArgs e)
        {
            using (Wookie.Tools.ImagePicker.ImagePicker imagePicker = new Tools.ImagePicker.ImagePicker())
            {
                if (tsysClientBindingSource.Current != null && imagePicker.ShowDialog() == DialogResult.OK)
                {
                    Database.tsysClient element = (Database.tsysClient)tsysClientBindingSource.Current;
                    element.Image = Wookie.Tools.Image.Converter.GetBinaryFromImage(imagePicker.SelectedImage);
                }
            }
        }
        #endregion
    }

    class CustomNodeOperation : TreeListOperation, IDisposable
    {
        TreeListNode selectedNode;
        List<Database.tsysClientElement> clientElements;

        public CustomNodeOperation(TreeListNode selectedNode) : base()
        {
            this.selectedNode = selectedNode;
            this.clientElements = new List<Database.tsysClientElement>();
        }

        public override void Execute(TreeListNode node)
        {
            if (node.HasAsParent(selectedNode)) this.clientElements.Add((Database.tsysClientElement)node.TreeList.GetDataRecordByNode(node));
        }

        void IDisposable.Dispose()
        {
            this.selectedNode = null;
            this.clientElements.Clear();
            this.clientElements = null;
        }

        public List<Database.tsysClientElement> ClientElements
        {
            get { return this.clientElements; }
        }
    }
}
