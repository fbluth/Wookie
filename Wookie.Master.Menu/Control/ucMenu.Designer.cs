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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tsysClientBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSortOrder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatasource = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInitialCatalog = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPersistSecurityInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.repositoryItemImageEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colFKExternal = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colSortOrder1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colName1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colImage1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colAssemblyname = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tsysClientElementBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientElementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tsysClientBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1,
            this.repositoryItemImageEdit1});
            this.gridControl1.Size = new System.Drawing.Size(1019, 122);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tsysClientBindingSource
            // 
            this.tsysClientBindingSource.DataSource = typeof(Wookie.Master.Menu.Database.tsysClient);
            this.tsysClientBindingSource.CurrentChanged += new System.EventHandler(this.tsysClientBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSortOrder,
            this.colDatasource,
            this.colInitialCatalog,
            this.colPersistSecurityInfo,
            this.colUserID,
            this.colPassword,
            this.colImage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            this.colName.Width = 85;
            // 
            // colSortOrder
            // 
            this.colSortOrder.FieldName = "SortOrder";
            this.colSortOrder.Name = "colSortOrder";
            this.colSortOrder.Visible = true;
            this.colSortOrder.VisibleIndex = 1;
            this.colSortOrder.Width = 69;
            // 
            // colDatasource
            // 
            this.colDatasource.FieldName = "Datasource";
            this.colDatasource.Name = "colDatasource";
            this.colDatasource.Visible = true;
            this.colDatasource.VisibleIndex = 3;
            this.colDatasource.Width = 160;
            // 
            // colInitialCatalog
            // 
            this.colInitialCatalog.FieldName = "InitialCatalog";
            this.colInitialCatalog.Name = "colInitialCatalog";
            this.colInitialCatalog.Visible = true;
            this.colInitialCatalog.VisibleIndex = 4;
            this.colInitialCatalog.Width = 160;
            // 
            // colPersistSecurityInfo
            // 
            this.colPersistSecurityInfo.FieldName = "PersistSecurityInfo";
            this.colPersistSecurityInfo.Name = "colPersistSecurityInfo";
            this.colPersistSecurityInfo.Visible = true;
            this.colPersistSecurityInfo.VisibleIndex = 7;
            this.colPersistSecurityInfo.Width = 165;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 5;
            this.colUserID.Width = 160;
            // 
            // colPassword
            // 
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 6;
            this.colPassword.Width = 164;
            // 
            // colImage
            // 
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 0;
            this.colImage.Width = 54;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // repositoryItemImageEdit1
            // 
            this.repositoryItemImageEdit1.AutoHeight = false;
            this.repositoryItemImageEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageEdit1.Name = "repositoryItemImageEdit1";
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 122);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1019, 10);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colFKExternal,
            this.colSortOrder1,
            this.colName1,
            this.colImage1,
            this.colAssemblyname});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeList1.DataSource = this.tsysClientElementBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.KeyFieldName = "PKClientElement";
            this.treeList1.Location = new System.Drawing.Point(0, 132);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsDragAndDrop.DragNodesMode = DevExpress.XtraTreeList.DragNodesMode.Single;
            this.treeList1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.treeList1.ParentFieldName = "FKClientElement";
            this.treeList1.Size = new System.Drawing.Size(1019, 594);
            this.treeList1.TabIndex = 2;
            this.treeList1.AfterDragNode += new DevExpress.XtraTreeList.AfterDragNodeEventHandler(this.treeList1_AfterDragNode);
            // 
            // colFKExternal
            // 
            this.colFKExternal.FieldName = "FKExternal";
            this.colFKExternal.Name = "colFKExternal";
            this.colFKExternal.Visible = true;
            this.colFKExternal.VisibleIndex = 4;
            // 
            // colSortOrder1
            // 
            this.colSortOrder1.FieldName = "SortOrder";
            this.colSortOrder1.Name = "colSortOrder1";
            this.colSortOrder1.Visible = true;
            this.colSortOrder1.VisibleIndex = 1;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 2;
            // 
            // colImage1
            // 
            this.colImage1.FieldName = "Image";
            this.colImage1.Name = "colImage1";
            this.colImage1.Visible = true;
            this.colImage1.VisibleIndex = 0;
            // 
            // colAssemblyname
            // 
            this.colAssemblyname.FieldName = "Assemblyname";
            this.colAssemblyname.Name = "colAssemblyname";
            this.colAssemblyname.Visible = true;
            this.colAssemblyname.VisibleIndex = 3;
            // 
            // tsysClientElementBindingSource
            // 
            this.tsysClientElementBindingSource.DataMember = "tsysClientElement";
            this.tsysClientElementBindingSource.DataSource = this.tsysClientBindingSource;
            // 
            // ucMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ucMenu";
            this.Size = new System.Drawing.Size(1019, 726);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsysClientElementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource tsysClientBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit repositoryItemImageEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSortOrder;
        private DevExpress.XtraGrid.Columns.GridColumn colDatasource;
        private DevExpress.XtraGrid.Columns.GridColumn colInitialCatalog;
        private DevExpress.XtraGrid.Columns.GridColumn colPersistSecurityInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFKExternal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colSortOrder1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colImage1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colAssemblyname;
        private System.Windows.Forms.BindingSource tsysClientElementBindingSource;
    }
}
