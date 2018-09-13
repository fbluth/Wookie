using System;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraTreeList.Nodes.Operations;
using System.Collections.Generic;

namespace Wookie.Master.Menu.Control
{
    public partial class ucMenu : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.MenuDataContext dataContext = null;
        private ModulData modulData = null;
        private bool ignoreCurrentClientItemChanged = false;
        private bool ignoreCurrentClientElementItemChanged = false;
        private DevExpress.Utils.Menu.DXMenuItem item = new DevExpress.Utils.Menu.DXMenuItem("Predefined Icons");
        private DevExpress.Utils.Menu.DXMenuItem item2 = new DevExpress.Utils.Menu.DXMenuItem("Predefined Icons");        
        private enum Mode { Default = 0, Edit = 1};        
        #endregion

        #region Constructor
        public ucMenu(ModulData modulData)
        {
            InitializeComponent();

            if (modulData != null)
            {
                this.modulData = modulData;
                this.item.Click += Item_Click;
                this.item2.Click += Item2_Click;

                this.SetMode(Mode.Default);
                this.LoadData();
                this.SetValidationRules();

                this.gridView1.BestFitColumns();
                this.treeMenu.BestFitColumns();
            }
        }

        public ucMenu(ModulData modulData, Image image):this(modulData)
        {
            this.groupControl1.CaptionImageOptions.Image = image;            
        }
        #endregion

        #region Public properties
        public Image Image
        {
            get { return this.groupControl1.CaptionImageOptions.Image; }
            set { this.groupControl1.CaptionImageOptions.Image = value; }
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

        private void SetMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Default:
                    this.groupControl1.CustomHeaderButtons[0].Properties.Visible = false; // Save
                    this.groupControl1.CustomHeaderButtons[1].Properties.Visible = false; // Cancel
                    this.groupControl1.CustomHeaderButtons[2].Properties.Visible = true; // Refresh
                    break;
                case Mode.Edit:
                    this.RefreshDataOnScreen();
                    this.groupControl1.CustomHeaderButtons[0].Properties.Visible = true; // Save
                    this.groupControl1.CustomHeaderButtons[1].Properties.Visible = true; // Cancel
                    this.groupControl1.CustomHeaderButtons[2].Properties.Visible = false; // Refresh
                    break;
            }
        }

        private void RefreshDataOnScreen()
        {
            if (this.SelectedClient != null)
            {
                this.tsysClientElementBindingSource.DataSource = this.SelectedClient;
                this.txtConnectionString.Control.Text = this.SqlConnectionStringBuilder.ConnectionString;
            }
        }

        private void SetValidationRules()
        {
            dxValidationProvider1.SetValidationRule(PacketSizeTextEdit, new Wookie.Tools.Validation.RangeValidationRule(512, 32678));
            dxValidationProvider1.SetValidationRule(ConnectRetryCountTextEdit, new Wookie.Tools.Validation.RangeValidationRule(0, 255));
            dxValidationProvider1.SetValidationRule(ConnectRetryIntervalTextEdit, new Wookie.Tools.Validation.RangeValidationRule(0, 60));            
        }

        private void LoadData()
        {
            try
            {
                this.splashScreenManager1.ShowWaitForm();
                this.splashScreenManager1.SetWaitFormCaption("Lade Daten");
                this.splashScreenManager1.SetWaitFormDescription("Bitte warten");
                
                if (this.dataContext != null) this.dataContext.Dispose();
                this.dataContext = new Database.MenuDataContext(this.modulData.SqlConnectionClientDB);

                this.tsysClientBindingSource.DataSource = this.dataContext.tsysClient;
                this.tsysClientElementBindingSource.DataSource = this.SelectedClient; //this.dataContext.tsysClient;

                this.SetMode(Mode.Default);

                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
            }
            catch
            {
                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Fehler beim laden der Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SaveData()
        {
            try
            {
                this.treeMenu.PostEditor();
                this.treeMenu.EndCurrentEdit();
                this.gridView1.PostEditor();

                if (dxValidationProvider1.Validate())
                {
                    this.splashScreenManager1.ShowWaitForm();
                    this.dataContext.SubmitChanges(ConflictMode.FailOnFirstConflict);
                    this.SetMode(Mode.Default);
                }
                return true;
            }
            catch (ChangeConflictException e)
            {

                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();

                if (dataContext.ChangeConflicts.Count > 0 && 
                    dataContext.ChangeConflicts[0].IsDeleted && 
                    dataContext.ChangeConflicts[0].Object is Database.tsysClient)
                {
                    Database.tsysClient client = dataContext.ChangeConflicts[0].Object as Database.tsysClient;
                    XtraMessageBox.Show(System.String.Format("Der Datensatz <b>\"{0}\"</b> existiert in der Datenbank nicht mehr.", client.Name), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, DevExpress.Utils.DefaultBoolean.True);
                }
                else if (dataContext.ChangeConflicts.Count > 0 &&
                    dataContext.ChangeConflicts[0].MemberConflicts.Count > 0 &&
                    dataContext.ChangeConflicts[0].MemberConflicts[0].IsModified && 
                    dataContext.ChangeConflicts[0].Object is Database.tsysClient)
                {
                    Database.tsysClient client = dataContext.ChangeConflicts[0].Object as Database.tsysClient;
                    XtraMessageBox.Show(
                        System.String.Format(
                            "Der Datensatz <b>\"{0}\"</b> wurde in der Datenbank geändert. Datenbankwert: {2}, Neuer Wert: {1}",
                            dataContext.ChangeConflicts[0].MemberConflicts[0].Member.Name,
                            dataContext.ChangeConflicts[0].MemberConflicts[0].CurrentValue,
                            dataContext.ChangeConflicts[0].MemberConflicts[0].DatabaseValue), 
                        "Fehler", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation, 
                        DevExpress.Utils.DefaultBoolean.True);
                }

                dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);

                return false;
            }
            catch (SqlException exception)
            {
                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();

                if (exception.Number == 547)
                    DevExpress.XtraEditors.XtraMessageBox.Show("Datensatz wird noch von anderer Stelle referenziert und kann daher nicht gelöscht werden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    DevExpress.XtraEditors.XtraMessageBox.Show(exception.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            finally
            {
                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
            }

        }

        private void TestConnection()
        {
            try
            {
                this.treeMenu.PostEditor();
                this.treeMenu.EndCurrentEdit();
                this.gridView1.PostEditor();
                if (dxValidationProvider1.Validate())
                {
                    this.splashScreenManager1.ShowWaitForm();
                    this.splashScreenManager1.SetWaitFormCaption("Teste Verbindung zu Datenbank");
                    this.splashScreenManager1.SetWaitFormDescription("Bitte warten");

                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlConnectionStringBuilder.ConnectionString))
                    {
                        // Überprüfe ob eine Verbindung zur Datenbank möglich ist.
                        sqlConnection.Open();
                        sqlConnection.Close();
                        if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
                        XtraMessageBox.Show("Connection successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                if (this.splashScreenManager1.IsSplashFormVisible) this.splashScreenManager1.CloseWaitForm();
                XtraMessageBox.Show("Connection not successful", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveClient()
        {
            if (this.SelectedClient == null) return;

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedClient.Name);

            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                this.dataContext.tsysClientElement.DeleteAllOnSubmit(this.SelectedClient.tsysClientElement);
                this.dataContext.tsysClient.DeleteOnSubmit(this.SelectedClient);

                this.tsysClientBindingSource.Remove(this.SelectedClient);

                this.SetMode(Mode.Edit);
            }
        }

        private void AddClient()
        {
            Database.tsysClient client = new Database.tsysClient();
            this.dataContext.tsysClient.InsertOnSubmit(client);
            int datasourceindex = this.tsysClientBindingSource.Add(client);
            gridView1.FocusedRowHandle = gridView1.GetRowHandle(datasourceindex);

            this.SetMode(Mode.Edit);            
        }

        private void RemoveNode()
        {
            if (this.treeMenu.FocusedNode == null) return;
            if (this.SelectedClientElement == null) return;

            string msg = string.Format("The node <b>\"{0}\"</b> is about to be deleted. Do you want to proceed?", this.SelectedClientElement.Name);
            if (XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo, DevExpress.Utils.DefaultBoolean.True) == DialogResult.Yes)
            {
                CustomNodeOperation operation = new CustomNodeOperation(treeMenu.FocusedNode);
                treeMenu.NodesIterator.DoLocalOperation(operation, treeMenu.Nodes);

                operation.TreeListNodes.Add(treeMenu.FocusedNode);
                Database.tsysClientElement parentElement = treeMenu.GetDataRecordByNode(treeMenu.FocusedNode.ParentNode) as Database.tsysClientElement;

                foreach (TreeListNode node in operation.TreeListNodes)
                {
                    Database.tsysClientElement test = treeMenu.GetDataRecordByNode(node) as Database.tsysClientElement;
                    if (test != null) 
                    {
                    
                    //this.dataContext.tsysClientElement.DeleteOnSubmit(test);
                        parentElement.tsysClientElement2.Remove(test);
                        this.SelectedClient.tsysClientElement.Remove(test);
                    this.tsysClientElementBindingSource.Remove(test);

                    }
                }
                
                this.SetMode(Mode.Edit);
            }
        }        

        private void AddNode()
        {
            if (this.SelectedClient == null) return;

            Database.tsysClientElement parentElement = treeMenu.GetDataRecordByNode(treeMenu.FocusedNode) as Database.tsysClientElement;
            Database.tsysClientElement element = new Database.tsysClientElement();
            parentElement.tsysClientElement2.Add(element);
            //this.SelectedClient.tsysClientElement.Add(element);
            //element.tsysClient = this.SelectedClient;
            //if (parentElement != null) element.tsysClientElement1 = parentElement;

            //this.dataContext.tsysClientElement.InsertOnSubmit(element);
            this.tsysClientElementBindingSource.Add(element);

            this.SetMode(Mode.Edit);
        }
        #endregion

        #region Events

        #region Binding Source
        private void tsysClientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.ignoreCurrentClientItemChanged = true;            
        }

        private void tsysClientBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (this.ignoreCurrentClientItemChanged) this.ignoreCurrentClientItemChanged = false;
            else this.SetMode(Mode.Edit);           
        }

        private void tsysClientElementBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            this.ignoreCurrentClientElementItemChanged = true;
        }

        private void tsysClientElementBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (this.ignoreCurrentClientElementItemChanged) this.ignoreCurrentClientElementItemChanged = false;
            else this.SetMode(Mode.Edit);
        }        
        #endregion

        #region TreeList
        private void treeList1_AfterDragNode(object sender, DevExpress.XtraTreeList.AfterDragNodeEventArgs e)
        {
            this.SetMode(Mode.Edit);
        }

        private void treeList1_PopupMenuShowing(object sender, DevExpress.XtraTreeList.PopupMenuShowingEventArgs e)
        {
            switch (e.Menu.MenuType)
            {
                case TreeListMenuType.Node:
                case TreeListMenuType.User:
                    //mnuMenu.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                    break;
            }
        }

        private void treeList1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveNode();
        }
        #endregion

        #region GridView
        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            switch (e.MenuType)
            {
                case GridMenuType.Row:
                case GridMenuType.User:
                    //mnuClient.ShowPopup(new Point(MousePosition.X, MousePosition.Y));
                    break;
            }
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) RemoveClient();            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            this.RefreshDataOnScreen();
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (!dxValidationProvider1.Validate()) e.Allow = false;
        }
        #endregion

        #region GroupControl
        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (groupControl1.CustomHeaderButtons.IndexOf(e.Button))
            {
                case 0: //Speichern
                    this.SaveData();
                    break;
                case 1: //Abbrechen
                case 2: //Reload
                    this.LoadData();
                    break;
            }
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
                case 2: //Test
                    this.TestConnection();
                    break;
                case 3: // Up
                    break;
                case 4: // Down
                    break;
                case 5: // Multiselect
                    this.gridView1.OptionsSelection.MultiSelect = !this.gridView1.OptionsSelection.MultiSelect;
                    this.gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
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
        #endregion

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
            e.Value = new System.Data.Linq.Binary((byte[])e.Value);
            e.Handled = true;
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

        private void btnEditPassword_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            btnEditPassword.Properties.UseSystemPasswordChar = !btnEditPassword.Properties.UseSystemPasswordChar;
        }
        #endregion
    }

    class CustomNodeOperation : TreeListOperation
    {
        TreeListNode selectedNode;
        List<TreeListNode> treeListNodes;

        public CustomNodeOperation(TreeListNode selectedNode) : base()
        {
            this.selectedNode = selectedNode;
            this.treeListNodes = new List<TreeListNode>();
            
        }

        public override void Execute(TreeListNode node)
        {
            if (node.HasAsParent(selectedNode)) this.treeListNodes.Add(node);
        }

        public List<TreeListNode> TreeListNodes
        {
            get { return this.treeListNodes; }
        }
    }
}
