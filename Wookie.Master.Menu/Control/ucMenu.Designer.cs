namespace Wookie.Master.Menu.Control
{
    partial class ucMenu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenu));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ucDefault1 = new Wookie.Tools.Controls.ucDefault();
            this.splitControlMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitControlClient = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlClient = new DevExpress.XtraEditors.GroupControl();
            this.gridControlClient = new DevExpress.XtraGrid.GridControl();
            this.tsysClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPKClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSortOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInitialCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersistSecurityInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConnectRetryCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConnectRetryInterval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConnectTimeout = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEncrypt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFailoverPartner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntegratedSecurity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPooling = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPacketSize = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserChangedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueIdentifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SortOrderTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DatasourceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.InitialCatalogTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PersistSecurityInfoCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.UserIDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConnectRetryCountTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConnectRetryIntervalTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConnectTimeoutTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.EncryptCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.FailoverPartnerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.IntegratedSecurityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.PoolingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.PacketSizeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ImagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgDatabase = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSortOrder = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDatasource = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForInitialCatalog = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForFailoverPartner = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgCredentials = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForUserID = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgSettings = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPacketSize = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConnectRetryCount = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConnectRetryInterval = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForConnectTimeout = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPersistSecurityInfo = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIntegratedSecurity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPooling = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEncrypt = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.splitControlMenu = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlMenu = new DevExpress.XtraEditors.GroupControl();
            this.treeMenu = new DevExpress.XtraTreeList.TreeList();
            this.colPKClientElement = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFKExternal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSortOrder1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImage1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAssemblyname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colCreatedOn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFKUserCreated1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colChangedOn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFKUserChangedOn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colUniqueIdentifier1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNamespace = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tsysClientElementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.AssemblynameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup6 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgMenuDetails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAssemblyname = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.popupMenuClient = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveClient = new DevExpress.XtraBars.BarButtonItem();
            this.btnTestClientConnection = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAddMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnRemoveMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenuTree = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).BeginInit();
            this.ucDefault1.WorkingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControlMain)).BeginInit();
            this.splitControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitControlClient)).BeginInit();
            this.splitControlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlClient)).BeginInit();
            this.groupControlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortOrderTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasourceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialCatalogTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersistSecurityInfoCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectRetryCountTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectRetryIntervalTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectTimeoutTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailoverPartnerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedSecurityCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoolingCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacketSizeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSortOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDatasource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInitialCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFailoverPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCredentials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPacketSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectRetryCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectRetryInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPersistSecurityInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIntegratedSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPooling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEncrypt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitControlMenu)).BeginInit();
            this.splitControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMenu)).BeginInit();
            this.groupControlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientElementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssemblynameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMenuDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssemblyname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTree)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDefault1
            // 
            this.ucDefault1.Caption = "";
            this.ucDefault1.DataContext = null;
            this.ucDefault1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDefault1.Image = null;
            this.ucDefault1.Location = new System.Drawing.Point(0, 0);
            this.ucDefault1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucDefault1.Name = "ucDefault1";
            this.ucDefault1.Size = new System.Drawing.Size(1200, 897);
            this.ucDefault1.TabIndex = 0;
            // 
            // ucDefault1.WorkingArea
            // 
            this.ucDefault1.WorkingArea.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ucDefault1.WorkingArea.Controls.Add(this.splitControlMain);
            this.ucDefault1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDefault1.WorkingArea.Location = new System.Drawing.Point(2, 45);
            this.ucDefault1.WorkingArea.Name = "WorkingArea";
            this.ucDefault1.WorkingArea.Size = new System.Drawing.Size(1196, 850);
            this.ucDefault1.WorkingArea.TabIndex = 0;
            this.ucDefault1.BeforeDataLoad += new System.EventHandler(this.ucDefault1_BeforeDataLoad);
            this.ucDefault1.DataRefresh += new System.EventHandler(this.ucDefault1_DataRefresh);
            // 
            // splitControlMain
            // 
            this.splitControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControlMain.Location = new System.Drawing.Point(0, 0);
            this.splitControlMain.Name = "splitControlMain";
            this.splitControlMain.Panel1.Controls.Add(this.splitControlClient);
            this.splitControlMain.Panel2.Controls.Add(this.splitControlMenu);
            this.splitControlMain.Size = new System.Drawing.Size(1196, 850);
            this.splitControlMain.SplitterPosition = 544;
            this.splitControlMain.TabIndex = 0;
            // 
            // splitControlClient
            // 
            this.splitControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControlClient.Horizontal = false;
            this.splitControlClient.Location = new System.Drawing.Point(0, 0);
            this.splitControlClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitControlClient.Name = "splitControlClient";
            this.splitControlClient.Panel1.Controls.Add(this.groupControlClient);
            this.splitControlClient.Panel1.Text = "Panel1";
            this.splitControlClient.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitControlClient.Panel2.Text = "Panel2";
            this.splitControlClient.Size = new System.Drawing.Size(544, 850);
            this.splitControlClient.SplitterPosition = 208;
            this.splitControlClient.TabIndex = 0;
            // 
            // groupControlClient
            // 
            this.groupControlClient.Controls.Add(this.gridControlClient);
            this.groupControlClient.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlClient.Location = new System.Drawing.Point(0, 0);
            this.groupControlClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlClient.Name = "groupControlClient";
            this.groupControlClient.Size = new System.Drawing.Size(544, 208);
            this.groupControlClient.TabIndex = 0;
            this.groupControlClient.Text = "Client";
            // 
            // gridControlClient
            // 
            this.gridControlClient.DataSource = this.tsysClientBindingSource;
            this.gridControlClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClient.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlClient.Location = new System.Drawing.Point(2, 33);
            this.gridControlClient.MainView = this.gridViewClient;
            this.gridControlClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControlClient.Name = "gridControlClient";
            this.gridControlClient.Size = new System.Drawing.Size(540, 173);
            this.gridControlClient.TabIndex = 0;
            this.gridControlClient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClient});
            // 
            // tsysClientBindingSource
            // 
            this.tsysClientBindingSource.DataSource = typeof(Wookie.Master.Menu.Database.tsysClient);
            // 
            // gridViewClient
            // 
            this.gridViewClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPKClient,
            this.colImage,
            this.colSortOrder,
            this.colName,
            this.colDatasource,
            this.colInitialCatalog,
            this.colPersistSecurityInfo,
            this.colUserID,
            this.colPassword,
            this.colConnectRetryCount,
            this.colConnectRetryInterval,
            this.colConnectTimeout,
            this.colEncrypt,
            this.colFailoverPartner,
            this.colIntegratedSecurity,
            this.colPooling,
            this.colPacketSize,
            this.colCreatedOn,
            this.colFKUserCreated,
            this.colChangedOn,
            this.colFKUserChangedOn,
            this.colUniqueIdentifier});
            this.gridViewClient.DetailHeight = 431;
            this.gridViewClient.GridControl = this.gridControlClient;
            this.gridViewClient.Name = "gridViewClient";
            this.gridViewClient.OptionsDetail.EnableMasterViewMode = false;
            this.gridViewClient.OptionsNavigation.AutoFocusNewRow = true;
            this.gridViewClient.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewClient.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridViewClient.OptionsView.ShowGroupPanel = false;
            this.gridViewClient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridClient_KeyDown);
            // 
            // colPKClient
            // 
            this.colPKClient.FieldName = "PKClient";
            this.colPKClient.MinWidth = 23;
            this.colPKClient.Name = "colPKClient";
            this.colPKClient.Width = 87;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.MinWidth = 23;
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 87;
            // 
            // colSortOrder
            // 
            this.colSortOrder.FieldName = "SortOrder";
            this.colSortOrder.MinWidth = 23;
            this.colSortOrder.Name = "colSortOrder";
            this.colSortOrder.Width = 87;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 23;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 87;
            // 
            // colDatasource
            // 
            this.colDatasource.FieldName = "Datasource";
            this.colDatasource.MinWidth = 23;
            this.colDatasource.Name = "colDatasource";
            this.colDatasource.Visible = true;
            this.colDatasource.VisibleIndex = 2;
            this.colDatasource.Width = 87;
            // 
            // colInitialCatalog
            // 
            this.colInitialCatalog.FieldName = "InitialCatalog";
            this.colInitialCatalog.MinWidth = 23;
            this.colInitialCatalog.Name = "colInitialCatalog";
            this.colInitialCatalog.Visible = true;
            this.colInitialCatalog.VisibleIndex = 3;
            this.colInitialCatalog.Width = 87;
            // 
            // colPersistSecurityInfo
            // 
            this.colPersistSecurityInfo.FieldName = "PersistSecurityInfo";
            this.colPersistSecurityInfo.MinWidth = 23;
            this.colPersistSecurityInfo.Name = "colPersistSecurityInfo";
            this.colPersistSecurityInfo.Width = 87;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.MinWidth = 23;
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 4;
            this.colUserID.Width = 87;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.MinWidth = 23;
            this.colPassword.Name = "colPassword";
            this.colPassword.Width = 87;
            // 
            // colConnectRetryCount
            // 
            this.colConnectRetryCount.FieldName = "ConnectRetryCount";
            this.colConnectRetryCount.MinWidth = 23;
            this.colConnectRetryCount.Name = "colConnectRetryCount";
            this.colConnectRetryCount.Width = 87;
            // 
            // colConnectRetryInterval
            // 
            this.colConnectRetryInterval.FieldName = "ConnectRetryInterval";
            this.colConnectRetryInterval.MinWidth = 23;
            this.colConnectRetryInterval.Name = "colConnectRetryInterval";
            this.colConnectRetryInterval.Width = 87;
            // 
            // colConnectTimeout
            // 
            this.colConnectTimeout.FieldName = "ConnectTimeout";
            this.colConnectTimeout.MinWidth = 23;
            this.colConnectTimeout.Name = "colConnectTimeout";
            this.colConnectTimeout.Width = 87;
            // 
            // colEncrypt
            // 
            this.colEncrypt.FieldName = "Encrypt";
            this.colEncrypt.MinWidth = 23;
            this.colEncrypt.Name = "colEncrypt";
            this.colEncrypt.Width = 87;
            // 
            // colFailoverPartner
            // 
            this.colFailoverPartner.FieldName = "FailoverPartner";
            this.colFailoverPartner.MinWidth = 23;
            this.colFailoverPartner.Name = "colFailoverPartner";
            this.colFailoverPartner.Width = 87;
            // 
            // colIntegratedSecurity
            // 
            this.colIntegratedSecurity.FieldName = "IntegratedSecurity";
            this.colIntegratedSecurity.MinWidth = 23;
            this.colIntegratedSecurity.Name = "colIntegratedSecurity";
            this.colIntegratedSecurity.Width = 87;
            // 
            // colPooling
            // 
            this.colPooling.FieldName = "Pooling";
            this.colPooling.MinWidth = 23;
            this.colPooling.Name = "colPooling";
            this.colPooling.Width = 87;
            // 
            // colPacketSize
            // 
            this.colPacketSize.FieldName = "PacketSize";
            this.colPacketSize.MinWidth = 23;
            this.colPacketSize.Name = "colPacketSize";
            this.colPacketSize.Width = 87;
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.FieldName = "CreatedOn";
            this.colCreatedOn.MinWidth = 23;
            this.colCreatedOn.Name = "colCreatedOn";
            this.colCreatedOn.Width = 87;
            // 
            // colFKUserCreated
            // 
            this.colFKUserCreated.FieldName = "FKUserCreated";
            this.colFKUserCreated.MinWidth = 23;
            this.colFKUserCreated.Name = "colFKUserCreated";
            this.colFKUserCreated.Width = 87;
            // 
            // colChangedOn
            // 
            this.colChangedOn.FieldName = "ChangedOn";
            this.colChangedOn.MinWidth = 23;
            this.colChangedOn.Name = "colChangedOn";
            this.colChangedOn.Width = 87;
            // 
            // colFKUserChangedOn
            // 
            this.colFKUserChangedOn.FieldName = "FKUserChangedOn";
            this.colFKUserChangedOn.MinWidth = 23;
            this.colFKUserChangedOn.Name = "colFKUserChangedOn";
            this.colFKUserChangedOn.Width = 87;
            // 
            // colUniqueIdentifier
            // 
            this.colUniqueIdentifier.FieldName = "UniqueIdentifier";
            this.colUniqueIdentifier.MinWidth = 23;
            this.colUniqueIdentifier.Name = "colUniqueIdentifier";
            this.colUniqueIdentifier.Width = 87;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SortOrderTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DatasourceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.InitialCatalogTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PersistSecurityInfoCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.UserIDTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ConnectRetryCountTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ConnectRetryIntervalTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ConnectTimeoutTextEdit);
            this.dataLayoutControl1.Controls.Add(this.EncryptCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.FailoverPartnerTextEdit);
            this.dataLayoutControl1.Controls.Add(this.IntegratedSecurityCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.PoolingCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.PacketSizeTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ImagePictureEdit);
            this.dataLayoutControl1.Controls.Add(this.PasswordTextEdit);
            this.dataLayoutControl1.DataSource = this.tsysClientBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(544, 630);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(254, 45);
            this.NameTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(71, 22);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // SortOrderTextEdit
            // 
            this.SortOrderTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "SortOrder", true));
            this.SortOrderTextEdit.Location = new System.Drawing.Point(459, 45);
            this.SortOrderTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SortOrderTextEdit.Name = "SortOrderTextEdit";
            this.SortOrderTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.SortOrderTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.SortOrderTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.SortOrderTextEdit.Properties.Mask.EditMask = "N0";
            this.SortOrderTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.SortOrderTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.SortOrderTextEdit.Size = new System.Drawing.Size(71, 22);
            this.SortOrderTextEdit.StyleController = this.dataLayoutControl1;
            this.SortOrderTextEdit.TabIndex = 5;
            // 
            // DatasourceTextEdit
            // 
            this.DatasourceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Datasource", true));
            this.DatasourceTextEdit.Location = new System.Drawing.Point(254, 71);
            this.DatasourceTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatasourceTextEdit.Name = "DatasourceTextEdit";
            this.DatasourceTextEdit.Size = new System.Drawing.Size(276, 22);
            this.DatasourceTextEdit.StyleController = this.dataLayoutControl1;
            this.DatasourceTextEdit.TabIndex = 6;
            // 
            // InitialCatalogTextEdit
            // 
            this.InitialCatalogTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "InitialCatalog", true));
            this.InitialCatalogTextEdit.Location = new System.Drawing.Point(254, 97);
            this.InitialCatalogTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InitialCatalogTextEdit.Name = "InitialCatalogTextEdit";
            this.InitialCatalogTextEdit.Size = new System.Drawing.Size(276, 22);
            this.InitialCatalogTextEdit.StyleController = this.dataLayoutControl1;
            this.InitialCatalogTextEdit.TabIndex = 7;
            // 
            // PersistSecurityInfoCheckEdit
            // 
            this.PersistSecurityInfoCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "PersistSecurityInfo", true));
            this.PersistSecurityInfoCheckEdit.Location = new System.Drawing.Point(284, 325);
            this.PersistSecurityInfoCheckEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PersistSecurityInfoCheckEdit.Name = "PersistSecurityInfoCheckEdit";
            this.PersistSecurityInfoCheckEdit.Properties.AllowGrayed = true;
            this.PersistSecurityInfoCheckEdit.Properties.Caption = "Persist Security Info";
            this.PersistSecurityInfoCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.PersistSecurityInfoCheckEdit.Size = new System.Drawing.Size(246, 24);
            this.PersistSecurityInfoCheckEdit.StyleController = this.dataLayoutControl1;
            this.PersistSecurityInfoCheckEdit.TabIndex = 8;
            // 
            // UserIDTextEdit
            // 
            this.UserIDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "UserID", true));
            this.UserIDTextEdit.Location = new System.Drawing.Point(144, 218);
            this.UserIDTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserIDTextEdit.Name = "UserIDTextEdit";
            this.UserIDTextEdit.Size = new System.Drawing.Size(386, 22);
            this.UserIDTextEdit.StyleController = this.dataLayoutControl1;
            this.UserIDTextEdit.TabIndex = 9;
            // 
            // ConnectRetryCountTextEdit
            // 
            this.ConnectRetryCountTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "ConnectRetryCount", true));
            this.ConnectRetryCountTextEdit.Location = new System.Drawing.Point(144, 351);
            this.ConnectRetryCountTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectRetryCountTextEdit.Name = "ConnectRetryCountTextEdit";
            this.ConnectRetryCountTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ConnectRetryCountTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ConnectRetryCountTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ConnectRetryCountTextEdit.Properties.Mask.EditMask = "N0";
            this.ConnectRetryCountTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ConnectRetryCountTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ConnectRetryCountTextEdit.Size = new System.Drawing.Size(124, 22);
            this.ConnectRetryCountTextEdit.StyleController = this.dataLayoutControl1;
            this.ConnectRetryCountTextEdit.TabIndex = 11;
            // 
            // ConnectRetryIntervalTextEdit
            // 
            this.ConnectRetryIntervalTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "ConnectRetryInterval", true));
            this.ConnectRetryIntervalTextEdit.Location = new System.Drawing.Point(144, 377);
            this.ConnectRetryIntervalTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectRetryIntervalTextEdit.Name = "ConnectRetryIntervalTextEdit";
            this.ConnectRetryIntervalTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ConnectRetryIntervalTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ConnectRetryIntervalTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ConnectRetryIntervalTextEdit.Properties.Mask.EditMask = "N0";
            this.ConnectRetryIntervalTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ConnectRetryIntervalTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ConnectRetryIntervalTextEdit.Size = new System.Drawing.Size(124, 22);
            this.ConnectRetryIntervalTextEdit.StyleController = this.dataLayoutControl1;
            this.ConnectRetryIntervalTextEdit.TabIndex = 12;
            // 
            // ConnectTimeoutTextEdit
            // 
            this.ConnectTimeoutTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "ConnectTimeout", true));
            this.ConnectTimeoutTextEdit.Location = new System.Drawing.Point(144, 403);
            this.ConnectTimeoutTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ConnectTimeoutTextEdit.Name = "ConnectTimeoutTextEdit";
            this.ConnectTimeoutTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.ConnectTimeoutTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.ConnectTimeoutTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.ConnectTimeoutTextEdit.Properties.Mask.EditMask = "N0";
            this.ConnectTimeoutTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.ConnectTimeoutTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.ConnectTimeoutTextEdit.Size = new System.Drawing.Size(124, 22);
            this.ConnectTimeoutTextEdit.StyleController = this.dataLayoutControl1;
            this.ConnectTimeoutTextEdit.TabIndex = 13;
            // 
            // EncryptCheckEdit
            // 
            this.EncryptCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Encrypt", true));
            this.EncryptCheckEdit.Location = new System.Drawing.Point(284, 409);
            this.EncryptCheckEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EncryptCheckEdit.Name = "EncryptCheckEdit";
            this.EncryptCheckEdit.Properties.AllowGrayed = true;
            this.EncryptCheckEdit.Properties.Caption = "Encrypt";
            this.EncryptCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.EncryptCheckEdit.Size = new System.Drawing.Size(246, 24);
            this.EncryptCheckEdit.StyleController = this.dataLayoutControl1;
            this.EncryptCheckEdit.TabIndex = 14;
            // 
            // FailoverPartnerTextEdit
            // 
            this.FailoverPartnerTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "FailoverPartner", true));
            this.FailoverPartnerTextEdit.Location = new System.Drawing.Point(254, 123);
            this.FailoverPartnerTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FailoverPartnerTextEdit.Name = "FailoverPartnerTextEdit";
            this.FailoverPartnerTextEdit.Size = new System.Drawing.Size(276, 22);
            this.FailoverPartnerTextEdit.StyleController = this.dataLayoutControl1;
            this.FailoverPartnerTextEdit.TabIndex = 15;
            // 
            // IntegratedSecurityCheckEdit
            // 
            this.IntegratedSecurityCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "IntegratedSecurity", true));
            this.IntegratedSecurityCheckEdit.Location = new System.Drawing.Point(284, 353);
            this.IntegratedSecurityCheckEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IntegratedSecurityCheckEdit.Name = "IntegratedSecurityCheckEdit";
            this.IntegratedSecurityCheckEdit.Properties.AllowGrayed = true;
            this.IntegratedSecurityCheckEdit.Properties.Caption = "Integrated Security";
            this.IntegratedSecurityCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IntegratedSecurityCheckEdit.Size = new System.Drawing.Size(246, 24);
            this.IntegratedSecurityCheckEdit.StyleController = this.dataLayoutControl1;
            this.IntegratedSecurityCheckEdit.TabIndex = 16;
            // 
            // PoolingCheckEdit
            // 
            this.PoolingCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Pooling", true));
            this.PoolingCheckEdit.Location = new System.Drawing.Point(284, 381);
            this.PoolingCheckEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PoolingCheckEdit.Name = "PoolingCheckEdit";
            this.PoolingCheckEdit.Properties.AllowGrayed = true;
            this.PoolingCheckEdit.Properties.Caption = "Pooling";
            this.PoolingCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.PoolingCheckEdit.Size = new System.Drawing.Size(246, 24);
            this.PoolingCheckEdit.StyleController = this.dataLayoutControl1;
            this.PoolingCheckEdit.TabIndex = 17;
            // 
            // PacketSizeTextEdit
            // 
            this.PacketSizeTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "PacketSize", true));
            this.PacketSizeTextEdit.Location = new System.Drawing.Point(144, 325);
            this.PacketSizeTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PacketSizeTextEdit.Name = "PacketSizeTextEdit";
            this.PacketSizeTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.PacketSizeTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.PacketSizeTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.PacketSizeTextEdit.Properties.Mask.EditMask = "N0";
            this.PacketSizeTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.PacketSizeTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.PacketSizeTextEdit.Size = new System.Drawing.Size(124, 22);
            this.PacketSizeTextEdit.StyleController = this.dataLayoutControl1;
            this.PacketSizeTextEdit.TabIndex = 18;
            // 
            // ImagePictureEdit
            // 
            this.ImagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Image", true));
            this.ImagePictureEdit.Location = new System.Drawing.Point(14, 45);
            this.ImagePictureEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImagePictureEdit.Name = "ImagePictureEdit";
            this.ImagePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.ImagePictureEdit.Size = new System.Drawing.Size(106, 114);
            this.ImagePictureEdit.StyleController = this.dataLayoutControl1;
            this.ImagePictureEdit.TabIndex = 19;
            this.ImagePictureEdit.PopupMenuShowing += new DevExpress.XtraEditors.Events.PopupMenuShowingEventHandler(this.picMenu1_PopupMenuShowing);
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientBindingSource, "Password", true));
            this.PasswordTextEdit.Location = new System.Drawing.Point(144, 244);
            this.PasswordTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            this.PasswordTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.PasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.PasswordTextEdit.Size = new System.Drawing.Size(386, 22);
            this.PasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.PasswordTextEdit.TabIndex = 10;
            this.PasswordTextEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEditPassword_ButtonClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(544, 630);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgDatabase,
            this.lcgCredentials,
            this.lcgSettings});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(544, 630);
            // 
            // lcgDatabase
            // 
            this.lcgDatabase.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForSortOrder,
            this.ItemForDatasource,
            this.ItemForInitialCatalog,
            this.ItemForImage,
            this.ItemForFailoverPartner});
            this.lcgDatabase.Location = new System.Drawing.Point(0, 0);
            this.lcgDatabase.Name = "lcgDatabase";
            this.lcgDatabase.Size = new System.Drawing.Size(544, 173);
            this.lcgDatabase.Text = "Datenbank";
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(110, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(205, 26);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForSortOrder
            // 
            this.ItemForSortOrder.Control = this.SortOrderTextEdit;
            this.ItemForSortOrder.Location = new System.Drawing.Point(315, 0);
            this.ItemForSortOrder.Name = "ItemForSortOrder";
            this.ItemForSortOrder.Size = new System.Drawing.Size(205, 26);
            this.ItemForSortOrder.Text = "Sort Order";
            this.ItemForSortOrder.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForDatasource
            // 
            this.ItemForDatasource.Control = this.DatasourceTextEdit;
            this.ItemForDatasource.Location = new System.Drawing.Point(110, 26);
            this.ItemForDatasource.Name = "ItemForDatasource";
            this.ItemForDatasource.Size = new System.Drawing.Size(410, 26);
            this.ItemForDatasource.Text = "Datasource";
            this.ItemForDatasource.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForInitialCatalog
            // 
            this.ItemForInitialCatalog.Control = this.InitialCatalogTextEdit;
            this.ItemForInitialCatalog.Location = new System.Drawing.Point(110, 52);
            this.ItemForInitialCatalog.Name = "ItemForInitialCatalog";
            this.ItemForInitialCatalog.Size = new System.Drawing.Size(410, 26);
            this.ItemForInitialCatalog.Text = "Initial Catalog";
            this.ItemForInitialCatalog.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForImage
            // 
            this.ItemForImage.Control = this.ImagePictureEdit;
            this.ItemForImage.Location = new System.Drawing.Point(0, 0);
            this.ItemForImage.MaxSize = new System.Drawing.Size(110, 118);
            this.ItemForImage.MinSize = new System.Drawing.Size(110, 118);
            this.ItemForImage.Name = "ItemForImage";
            this.ItemForImage.Size = new System.Drawing.Size(110, 118);
            this.ItemForImage.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.ItemForImage.StartNewLine = true;
            this.ItemForImage.Text = "Image";
            this.ItemForImage.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForImage.TextVisible = false;
            // 
            // ItemForFailoverPartner
            // 
            this.ItemForFailoverPartner.Control = this.FailoverPartnerTextEdit;
            this.ItemForFailoverPartner.Location = new System.Drawing.Point(110, 78);
            this.ItemForFailoverPartner.Name = "ItemForFailoverPartner";
            this.ItemForFailoverPartner.Size = new System.Drawing.Size(410, 40);
            this.ItemForFailoverPartner.Text = "Failover Partner";
            this.ItemForFailoverPartner.TextSize = new System.Drawing.Size(127, 16);
            // 
            // lcgCredentials
            // 
            this.lcgCredentials.CustomizationFormText = "Zugangsdaten";
            this.lcgCredentials.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForUserID,
            this.ItemForPassword});
            this.lcgCredentials.Location = new System.Drawing.Point(0, 173);
            this.lcgCredentials.Name = "lcgCredentials";
            this.lcgCredentials.Size = new System.Drawing.Size(544, 107);
            this.lcgCredentials.Text = "Zugangsdaten";
            // 
            // ItemForUserID
            // 
            this.ItemForUserID.Control = this.UserIDTextEdit;
            this.ItemForUserID.Location = new System.Drawing.Point(0, 0);
            this.ItemForUserID.Name = "ItemForUserID";
            this.ItemForUserID.Size = new System.Drawing.Size(520, 26);
            this.ItemForUserID.Text = "User ID";
            this.ItemForUserID.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 26);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(520, 26);
            this.ItemForPassword.Text = "Password";
            this.ItemForPassword.TextSize = new System.Drawing.Size(127, 16);
            // 
            // lcgSettings
            // 
            this.lcgSettings.CustomizationFormText = "Datenbankeinstellungen";
            this.lcgSettings.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPacketSize,
            this.ItemForConnectRetryCount,
            this.ItemForConnectRetryInterval,
            this.ItemForConnectTimeout,
            this.ItemForPersistSecurityInfo,
            this.ItemForIntegratedSecurity,
            this.ItemForPooling,
            this.ItemForEncrypt,
            this.splitterItem1});
            this.lcgSettings.Location = new System.Drawing.Point(0, 280);
            this.lcgSettings.Name = "lcgSettings";
            this.lcgSettings.Size = new System.Drawing.Size(544, 350);
            this.lcgSettings.Text = "Datenbankeinstellungen";
            // 
            // ItemForPacketSize
            // 
            this.ItemForPacketSize.Control = this.PacketSizeTextEdit;
            this.ItemForPacketSize.Location = new System.Drawing.Point(0, 0);
            this.ItemForPacketSize.Name = "ItemForPacketSize";
            this.ItemForPacketSize.Size = new System.Drawing.Size(258, 26);
            this.ItemForPacketSize.Text = "Packet Size";
            this.ItemForPacketSize.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForConnectRetryCount
            // 
            this.ItemForConnectRetryCount.Control = this.ConnectRetryCountTextEdit;
            this.ItemForConnectRetryCount.Location = new System.Drawing.Point(0, 26);
            this.ItemForConnectRetryCount.Name = "ItemForConnectRetryCount";
            this.ItemForConnectRetryCount.Size = new System.Drawing.Size(258, 26);
            this.ItemForConnectRetryCount.Text = "Connect Retry Count";
            this.ItemForConnectRetryCount.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForConnectRetryInterval
            // 
            this.ItemForConnectRetryInterval.Control = this.ConnectRetryIntervalTextEdit;
            this.ItemForConnectRetryInterval.Location = new System.Drawing.Point(0, 52);
            this.ItemForConnectRetryInterval.Name = "ItemForConnectRetryInterval";
            this.ItemForConnectRetryInterval.Size = new System.Drawing.Size(258, 26);
            this.ItemForConnectRetryInterval.Text = "Connect Retry Interval";
            this.ItemForConnectRetryInterval.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForConnectTimeout
            // 
            this.ItemForConnectTimeout.Control = this.ConnectTimeoutTextEdit;
            this.ItemForConnectTimeout.Location = new System.Drawing.Point(0, 78);
            this.ItemForConnectTimeout.Name = "ItemForConnectTimeout";
            this.ItemForConnectTimeout.Size = new System.Drawing.Size(258, 217);
            this.ItemForConnectTimeout.Text = "Connect Timeout";
            this.ItemForConnectTimeout.TextSize = new System.Drawing.Size(127, 16);
            // 
            // ItemForPersistSecurityInfo
            // 
            this.ItemForPersistSecurityInfo.Control = this.PersistSecurityInfoCheckEdit;
            this.ItemForPersistSecurityInfo.Location = new System.Drawing.Point(270, 0);
            this.ItemForPersistSecurityInfo.Name = "ItemForPersistSecurityInfo";
            this.ItemForPersistSecurityInfo.Size = new System.Drawing.Size(250, 28);
            this.ItemForPersistSecurityInfo.Text = "Persist Security Info";
            this.ItemForPersistSecurityInfo.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPersistSecurityInfo.TextVisible = false;
            // 
            // ItemForIntegratedSecurity
            // 
            this.ItemForIntegratedSecurity.Control = this.IntegratedSecurityCheckEdit;
            this.ItemForIntegratedSecurity.Location = new System.Drawing.Point(270, 28);
            this.ItemForIntegratedSecurity.Name = "ItemForIntegratedSecurity";
            this.ItemForIntegratedSecurity.Size = new System.Drawing.Size(250, 28);
            this.ItemForIntegratedSecurity.Text = "Integrated Security";
            this.ItemForIntegratedSecurity.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIntegratedSecurity.TextVisible = false;
            // 
            // ItemForPooling
            // 
            this.ItemForPooling.Control = this.PoolingCheckEdit;
            this.ItemForPooling.Location = new System.Drawing.Point(270, 56);
            this.ItemForPooling.Name = "ItemForPooling";
            this.ItemForPooling.Size = new System.Drawing.Size(250, 28);
            this.ItemForPooling.Text = "Pooling";
            this.ItemForPooling.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForPooling.TextVisible = false;
            // 
            // ItemForEncrypt
            // 
            this.ItemForEncrypt.Control = this.EncryptCheckEdit;
            this.ItemForEncrypt.Location = new System.Drawing.Point(270, 84);
            this.ItemForEncrypt.Name = "ItemForEncrypt";
            this.ItemForEncrypt.Size = new System.Drawing.Size(250, 211);
            this.ItemForEncrypt.Text = "Encrypt";
            this.ItemForEncrypt.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForEncrypt.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(258, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(12, 295);
            // 
            // splitControlMenu
            // 
            this.splitControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitControlMenu.Horizontal = false;
            this.splitControlMenu.Location = new System.Drawing.Point(0, 0);
            this.splitControlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitControlMenu.Name = "splitControlMenu";
            this.splitControlMenu.Panel1.Controls.Add(this.groupControlMenu);
            this.splitControlMenu.Panel1.Text = "Panel1";
            this.splitControlMenu.Panel2.Controls.Add(this.dataLayoutControl2);
            this.splitControlMenu.Panel2.Text = "Panel2";
            this.splitControlMenu.Size = new System.Drawing.Size(640, 850);
            this.splitControlMenu.SplitterPosition = 508;
            this.splitControlMenu.TabIndex = 0;
            // 
            // groupControlMenu
            // 
            this.groupControlMenu.Controls.Add(this.treeMenu);
            this.groupControlMenu.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMenu.Location = new System.Drawing.Point(0, 0);
            this.groupControlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControlMenu.Name = "groupControlMenu";
            this.groupControlMenu.Size = new System.Drawing.Size(640, 508);
            this.groupControlMenu.TabIndex = 0;
            this.groupControlMenu.Text = "Menüstruktur";
            // 
            // treeMenu
            // 
            this.treeMenu.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colPKClientElement,
            this.colFKExternal,
            this.colSortOrder1,
            this.colName1,
            this.colImage1,
            this.colAssemblyname,
            this.colCreatedOn1,
            this.colFKUserCreated1,
            this.colChangedOn1,
            this.colFKUserChangedOn1,
            this.colUniqueIdentifier1,
            this.colNamespace});
            this.treeMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeMenu.DataSource = this.tsysClientElementBindingSource;
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.Location = new System.Drawing.Point(2, 33);
            this.treeMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeMenu.MinWidth = 23;
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.OptionsBehavior.AutoNodeHeight = false;
            this.treeMenu.OptionsBehavior.PopulateServiceColumns = true;
            this.treeMenu.OptionsDragAndDrop.CanCloneNodesOnDrop = true;
            this.treeMenu.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.treeMenu.PreviewFieldName = "ParentID";
            this.treeMenu.Size = new System.Drawing.Size(636, 473);
            this.treeMenu.TabIndex = 0;
            this.treeMenu.TreeLevelWidth = 21;
            this.treeMenu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeMenu_KeyDown);
            // 
            // colPKClientElement
            // 
            this.colPKClientElement.FieldName = "PKClientElement";
            this.colPKClientElement.MinWidth = 27;
            this.colPKClientElement.Name = "colPKClientElement";
            this.colPKClientElement.Width = 101;
            // 
            // colFKExternal
            // 
            this.colFKExternal.FieldName = "FKExternal";
            this.colFKExternal.MinWidth = 27;
            this.colFKExternal.Name = "colFKExternal";
            this.colFKExternal.Visible = true;
            this.colFKExternal.VisibleIndex = 4;
            this.colFKExternal.Width = 101;
            // 
            // colSortOrder1
            // 
            this.colSortOrder1.FieldName = "SortOrder";
            this.colSortOrder1.MinWidth = 27;
            this.colSortOrder1.Name = "colSortOrder1";
            this.colSortOrder1.Width = 101;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.MinWidth = 27;
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 1;
            this.colName1.Width = 101;
            // 
            // colImage1
            // 
            this.colImage1.FieldName = "Image";
            this.colImage1.MinWidth = 27;
            this.colImage1.Name = "colImage1";
            this.colImage1.Visible = true;
            this.colImage1.VisibleIndex = 0;
            this.colImage1.Width = 101;
            // 
            // colAssemblyname
            // 
            this.colAssemblyname.FieldName = "Assemblyname";
            this.colAssemblyname.MinWidth = 27;
            this.colAssemblyname.Name = "colAssemblyname";
            this.colAssemblyname.Visible = true;
            this.colAssemblyname.VisibleIndex = 2;
            this.colAssemblyname.Width = 101;
            // 
            // colCreatedOn1
            // 
            this.colCreatedOn1.FieldName = "CreatedOn";
            this.colCreatedOn1.MinWidth = 27;
            this.colCreatedOn1.Name = "colCreatedOn1";
            this.colCreatedOn1.Width = 101;
            // 
            // colFKUserCreated1
            // 
            this.colFKUserCreated1.FieldName = "FKUserCreated";
            this.colFKUserCreated1.MinWidth = 27;
            this.colFKUserCreated1.Name = "colFKUserCreated1";
            this.colFKUserCreated1.Width = 101;
            // 
            // colChangedOn1
            // 
            this.colChangedOn1.FieldName = "ChangedOn";
            this.colChangedOn1.MinWidth = 27;
            this.colChangedOn1.Name = "colChangedOn1";
            this.colChangedOn1.Width = 101;
            // 
            // colFKUserChangedOn1
            // 
            this.colFKUserChangedOn1.FieldName = "FKUserChangedOn";
            this.colFKUserChangedOn1.MinWidth = 27;
            this.colFKUserChangedOn1.Name = "colFKUserChangedOn1";
            this.colFKUserChangedOn1.Width = 101;
            // 
            // colUniqueIdentifier1
            // 
            this.colUniqueIdentifier1.FieldName = "UniqueIdentifier";
            this.colUniqueIdentifier1.MinWidth = 27;
            this.colUniqueIdentifier1.Name = "colUniqueIdentifier1";
            this.colUniqueIdentifier1.Width = 101;
            // 
            // colNamespace
            // 
            this.colNamespace.Caption = "Namespace";
            this.colNamespace.FieldName = "Namespace";
            this.colNamespace.MinWidth = 23;
            this.colNamespace.Name = "colNamespace";
            this.colNamespace.Visible = true;
            this.colNamespace.VisibleIndex = 3;
            this.colNamespace.Width = 87;
            // 
            // tsysClientElementBindingSource
            // 
            this.tsysClientElementBindingSource.DataMember = "tsysClientElement";
            this.tsysClientElementBindingSource.DataSource = typeof(Wookie.Master.Menu.Database.tsysClient);
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.textEdit1);
            this.dataLayoutControl2.Controls.Add(this.textEdit2);
            this.dataLayoutControl2.Controls.Add(this.pictureEdit1);
            this.dataLayoutControl2.Controls.Add(this.AssemblynameTextEdit);
            this.dataLayoutControl2.DataSource = this.tsysClientElementBindingSource;
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.layoutControlGroup3;
            this.dataLayoutControl2.Size = new System.Drawing.Size(640, 330);
            this.dataLayoutControl2.TabIndex = 0;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientElementBindingSource, "SortOrder", true));
            this.textEdit1.Location = new System.Drawing.Point(531, 45);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.textEdit1.Properties.Mask.EditMask = "N0";
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.textEdit1.Size = new System.Drawing.Size(95, 22);
            this.textEdit1.StyleController = this.dataLayoutControl2;
            this.textEdit1.TabIndex = 4;
            // 
            // textEdit2
            // 
            this.textEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientElementBindingSource, "Name", true));
            this.textEdit2.Location = new System.Drawing.Point(228, 45);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(210, 22);
            this.textEdit2.StyleController = this.dataLayoutControl2;
            this.textEdit2.TabIndex = 5;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientElementBindingSource, "Image", true));
            this.pictureEdit1.Location = new System.Drawing.Point(14, 45);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pictureEdit1.Size = new System.Drawing.Size(121, 128);
            this.pictureEdit1.StyleController = this.dataLayoutControl2;
            this.pictureEdit1.TabIndex = 6;
            this.pictureEdit1.PopupMenuShowing += new DevExpress.XtraEditors.Events.PopupMenuShowingEventHandler(this.picMenu_PopupMenuShowing);
            // 
            // AssemblynameTextEdit
            // 
            this.AssemblynameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tsysClientElementBindingSource, "Assemblyname", true));
            this.AssemblynameTextEdit.Location = new System.Drawing.Point(228, 71);
            this.AssemblynameTextEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AssemblynameTextEdit.Name = "AssemblynameTextEdit";
            this.AssemblynameTextEdit.Size = new System.Drawing.Size(398, 22);
            this.AssemblynameTextEdit.StyleController = this.dataLayoutControl2;
            this.AssemblynameTextEdit.TabIndex = 7;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup6});
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup3.Size = new System.Drawing.Size(640, 330);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlGroup6
            // 
            this.layoutControlGroup6.AllowDrawBackground = false;
            this.layoutControlGroup6.GroupBordersVisible = false;
            this.layoutControlGroup6.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgMenuDetails});
            this.layoutControlGroup6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup6.Name = "autoGeneratedGroup0";
            this.layoutControlGroup6.Size = new System.Drawing.Size(640, 330);
            // 
            // lcgMenuDetails
            // 
            this.lcgMenuDetails.CustomizationFormText = "Details";
            this.lcgMenuDetails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.ItemForAssemblyname,
            this.layoutControlItem3,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
            this.lcgMenuDetails.Location = new System.Drawing.Point(0, 0);
            this.lcgMenuDetails.Name = "lcgMenuDetails";
            this.lcgMenuDetails.Size = new System.Drawing.Size(640, 330);
            this.lcgMenuDetails.Text = "Details";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(428, 0);
            this.layoutControlItem1.Name = "ItemForSortOrder";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 26);
            this.layoutControlItem1.Text = "Sort Order";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit2;
            this.layoutControlItem2.Location = new System.Drawing.Point(125, 0);
            this.layoutControlItem2.Name = "ItemForName";
            this.layoutControlItem2.Size = new System.Drawing.Size(303, 26);
            this.layoutControlItem2.Text = "Name";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 16);
            // 
            // ItemForAssemblyname
            // 
            this.ItemForAssemblyname.Control = this.AssemblynameTextEdit;
            this.ItemForAssemblyname.Location = new System.Drawing.Point(125, 26);
            this.ItemForAssemblyname.Name = "ItemForAssemblyname";
            this.ItemForAssemblyname.Size = new System.Drawing.Size(491, 26);
            this.ItemForAssemblyname.Text = "Assemblyname";
            this.ItemForAssemblyname.TextSize = new System.Drawing.Size(86, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.pictureEdit1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(125, 132);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(125, 132);
            this.layoutControlItem3.Name = "ItemForImage";
            this.layoutControlItem3.Size = new System.Drawing.Size(125, 132);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.StartNewLine = true;
            this.layoutControlItem3.Text = "Image";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(125, 52);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(491, 80);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 132);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(616, 143);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // popupMenuClient
            // 
            this.popupMenuClient.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTestClientConnection)});
            this.popupMenuClient.Manager = this.barManager1;
            this.popupMenuClient.Name = "popupMenuClient";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Caption = "Neu";
            this.btnAddClient.Id = 0;
            this.btnAddClient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddClient.ImageOptions.SvgImage")));
            this.btnAddClient.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddClient_ItemClick);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Caption = "Löschen";
            this.btnRemoveClient.Id = 1;
            this.btnRemoveClient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveClient.ImageOptions.SvgImage")));
            this.btnRemoveClient.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveClient_ItemClick);
            // 
            // btnTestClientConnection
            // 
            this.btnTestClientConnection.Caption = "Verbindungstest";
            this.btnTestClientConnection.Id = 2;
            this.btnTestClientConnection.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTestClientConnection.ImageOptions.SvgImage")));
            this.btnTestClientConnection.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T));
            this.btnTestClientConnection.Name = "btnTestClientConnection";
            this.btnTestClientConnection.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTestClientConnection_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddClient,
            this.btnRemoveClient,
            this.btnTestClientConnection,
            this.btnAddMenu,
            this.btnRemoveMenu,
            this.barSubItem1,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 897);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1200, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 897);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1200, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 897);
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Caption = "Add";
            this.btnAddMenu.Id = 3;
            this.btnAddMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddMenu.ImageOptions.SvgImage")));
            this.btnAddMenu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add));
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddMenu_ItemClick);
            // 
            // btnRemoveMenu
            // 
            this.btnRemoveMenu.Caption = "Remove";
            this.btnRemoveMenu.Id = 4;
            this.btnRemoveMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemoveMenu.ImageOptions.SvgImage")));
            this.btnRemoveMenu.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract));
            this.btnRemoveMenu.Name = "btnRemoveMenu";
            this.btnRemoveMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRemoveMenu_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Test";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Test 2";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenuTree
            // 
            this.popupMenuTree.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAddMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRemoveMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.popupMenuTree.Manager = this.barManager1;
            this.popupMenuTree.Name = "popupMenuTree";
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDefault1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(1200, 897);
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).EndInit();
            this.ucDefault1.WorkingArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitControlMain)).EndInit();
            this.splitControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitControlClient)).EndInit();
            this.splitControlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlClient)).EndInit();
            this.groupControlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SortOrderTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatasourceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InitialCatalogTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersistSecurityInfoCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectRetryCountTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectRetryIntervalTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectTimeoutTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FailoverPartnerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedSecurityCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoolingCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacketSizeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSortOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDatasource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForInitialCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForFailoverPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgCredentials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForUserID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPacketSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectRetryCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectRetryInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForConnectTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPersistSecurityInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIntegratedSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPooling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEncrypt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitControlMenu)).EndInit();
            this.splitControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMenu)).EndInit();
            this.groupControlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientElementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssemblynameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMenuDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAssemblyname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenuTree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.Controls.ucDefault ucDefault1;
        private DevExpress.XtraEditors.SplitContainerControl splitControlMain;
        private DevExpress.XtraEditors.SplitContainerControl splitControlClient;
        private DevExpress.XtraEditors.GroupControl groupControlClient;
        private DevExpress.XtraGrid.GridControl gridControlClient;
        private System.Windows.Forms.BindingSource tsysClientBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClient;
        private DevExpress.XtraGrid.Columns.GridColumn colPKClient;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSortOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasource;
        private DevExpress.XtraGrid.Columns.GridColumn colInitialCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn colPersistSecurityInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colConnectRetryCount;
        private DevExpress.XtraGrid.Columns.GridColumn colConnectRetryInterval;
        private DevExpress.XtraGrid.Columns.GridColumn colConnectTimeout;
        private DevExpress.XtraGrid.Columns.GridColumn colEncrypt;
        private DevExpress.XtraGrid.Columns.GridColumn colFailoverPartner;
        private DevExpress.XtraGrid.Columns.GridColumn colIntegratedSecurity;
        private DevExpress.XtraGrid.Columns.GridColumn colPooling;
        private DevExpress.XtraGrid.Columns.GridColumn colPacketSize;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserChangedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueIdentifier;
        private DevExpress.XtraEditors.SplitContainerControl splitControlMenu;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit SortOrderTextEdit;
        private DevExpress.XtraEditors.TextEdit DatasourceTextEdit;
        private DevExpress.XtraEditors.TextEdit InitialCatalogTextEdit;
        private DevExpress.XtraEditors.CheckEdit PersistSecurityInfoCheckEdit;
        private DevExpress.XtraEditors.TextEdit UserIDTextEdit;
        private DevExpress.XtraEditors.TextEdit ConnectRetryCountTextEdit;
        private DevExpress.XtraEditors.TextEdit ConnectRetryIntervalTextEdit;
        private DevExpress.XtraEditors.TextEdit ConnectTimeoutTextEdit;
        private DevExpress.XtraEditors.CheckEdit EncryptCheckEdit;
        private DevExpress.XtraEditors.TextEdit FailoverPartnerTextEdit;
        private DevExpress.XtraEditors.CheckEdit IntegratedSecurityCheckEdit;
        private DevExpress.XtraEditors.CheckEdit PoolingCheckEdit;
        private DevExpress.XtraEditors.TextEdit PacketSizeTextEdit;
        private DevExpress.XtraEditors.PictureEdit ImagePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDatabase;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSortOrder;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDatasource;
        private DevExpress.XtraLayout.LayoutControlItem ItemForInitialCatalog;
        private DevExpress.XtraLayout.LayoutControlItem ItemForImage;
        private DevExpress.XtraLayout.LayoutControlGroup lcgCredentials;
        private DevExpress.XtraLayout.LayoutControlItem ItemForUserID;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlGroup lcgSettings;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPacketSize;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConnectRetryCount;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConnectRetryInterval;
        private DevExpress.XtraLayout.LayoutControlItem ItemForConnectTimeout;
        private DevExpress.XtraLayout.LayoutControlItem ItemForFailoverPartner;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPersistSecurityInfo;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIntegratedSecurity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPooling;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEncrypt;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraEditors.GroupControl groupControlMenu;
        private DevExpress.XtraTreeList.TreeList treeMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPKClientElement;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFKExternal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSortOrder1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImage1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAssemblyname;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colCreatedOn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFKUserCreated1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colChangedOn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFKUserChangedOn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colUniqueIdentifier1;
        private System.Windows.Forms.BindingSource tsysClientElementBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit AssemblynameTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup6;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMenuDetails;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAssemblyname;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ButtonEdit PasswordTextEdit;
        private DevExpress.XtraBars.PopupMenu popupMenuClient;
        private DevExpress.XtraBars.BarButtonItem btnAddClient;
        private DevExpress.XtraBars.BarButtonItem btnRemoveClient;
        private DevExpress.XtraBars.BarButtonItem btnTestClientConnection;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnAddMenu;
        private DevExpress.XtraBars.BarButtonItem btnRemoveMenu;
        private DevExpress.XtraBars.PopupMenu popupMenuTree;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNamespace;
    }
}
