namespace Wookie.Employee.MasterData.ContactPrefix
{
    partial class ucMasterData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMasterData));
            this.ucDefault1 = new Wookie.Tools.Controls.ucDefault();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tlkpContactPrefixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPKContactPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueIdentifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.PicturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).BeginInit();
            this.ucDefault1.WorkingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkpContactPrefixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDefault1
            // 
            this.ucDefault1.Caption = "";
            this.ucDefault1.DataContext = null;
            this.ucDefault1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDefault1.Image = null;
            this.ucDefault1.Location = new System.Drawing.Point(0, 0);
            this.ucDefault1.Name = "ucDefault1";
            this.ucDefault1.Size = new System.Drawing.Size(741, 428);
            this.ucDefault1.TabIndex = 0;
            // 
            // 
            // 
            this.ucDefault1.ValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // ucDefault1.WorkingArea
            // 
            this.ucDefault1.WorkingArea.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ucDefault1.WorkingArea.Controls.Add(this.splitContainerControl1);
            this.ucDefault1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDefault1.WorkingArea.Location = new System.Drawing.Point(2, 37);
            this.ucDefault1.WorkingArea.Name = "WorkingArea";
            this.ucDefault1.WorkingArea.Padding = new System.Windows.Forms.Padding(5);
            this.ucDefault1.WorkingArea.Size = new System.Drawing.Size(737, 389);
            this.ucDefault1.WorkingArea.TabIndex = 0;
            this.ucDefault1.BeforeDataLoad += new System.EventHandler(this.ucDefault1_BeforeDataLoad);
            this.ucDefault1.DataRefresh += new System.EventHandler(this.ucDefault1_DataRefresh);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(5, 5);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.dataLayoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(727, 379);
            this.splitContainerControl1.SplitterPosition = 211;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(727, 211);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Anrede";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tlkpContactPrefixBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 182);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tlkpContactPrefixBindingSource
            // 
            this.tlkpContactPrefixBindingSource.DataSource = typeof(Wookie.Employee.MasterData.Database.tlkpContactPrefix);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPKContactPrefix,
            this.colName,
            this.colPicture,
            this.colFKUserCreated,
            this.colCreatedOn,
            this.colFKUserChanged,
            this.colChangedOn,
            this.colUniqueIdentifier});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPKContactPrefix
            // 
            this.colPKContactPrefix.FieldName = "PKContactPrefix";
            this.colPKContactPrefix.Name = "colPKContactPrefix";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 1325;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 0;
            this.colPicture.Width = 54;
            // 
            // colFKUserCreated
            // 
            this.colFKUserCreated.FieldName = "FKUserCreated";
            this.colFKUserCreated.Name = "colFKUserCreated";
            // 
            // colCreatedOn
            // 
            this.colCreatedOn.FieldName = "CreatedOn";
            this.colCreatedOn.Name = "colCreatedOn";
            // 
            // colFKUserChanged
            // 
            this.colFKUserChanged.FieldName = "FKUserChanged";
            this.colFKUserChanged.Name = "colFKUserChanged";
            // 
            // colChangedOn
            // 
            this.colChangedOn.FieldName = "ChangedOn";
            this.colChangedOn.Name = "colChangedOn";
            // 
            // colUniqueIdentifier
            // 
            this.colUniqueIdentifier.FieldName = "UniqueIdentifier";
            this.colUniqueIdentifier.Name = "colUniqueIdentifier";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PicturePictureEdit);
            this.dataLayoutControl1.DataSource = this.tlkpContactPrefixBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(727, 158);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkpContactPrefixBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(48, 12);
            this.NameTextEdit.MenuManager = this.barManager1;
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(667, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete});
            this.barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(741, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 428);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(741, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 428);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(741, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 428);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Neu";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Löschen";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // PicturePictureEdit
            // 
            this.PicturePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkpContactPrefixBindingSource, "Picture", true));
            this.PicturePictureEdit.Location = new System.Drawing.Point(48, 36);
            this.PicturePictureEdit.MenuManager = this.barManager1;
            this.PicturePictureEdit.Name = "PicturePictureEdit";
            this.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PicturePictureEdit.Size = new System.Drawing.Size(667, 110);
            this.PicturePictureEdit.StyleController = this.dataLayoutControl1;
            this.PicturePictureEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(727, 158);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForPicture});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(707, 138);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(707, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(33, 13);
            // 
            // ItemForPicture
            // 
            this.ItemForPicture.Control = this.PicturePictureEdit;
            this.ItemForPicture.Location = new System.Drawing.Point(0, 24);
            this.ItemForPicture.Name = "ItemForPicture";
            this.ItemForPicture.Size = new System.Drawing.Size(707, 114);
            this.ItemForPicture.StartNewLine = true;
            this.ItemForPicture.Text = "Picture";
            this.ItemForPicture.TextSize = new System.Drawing.Size(33, 13);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.popupMenu.Manager = this.barManager1;
            this.popupMenu.Name = "popupMenu";
            // 
            // ucMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDefault1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucMasterData";
            this.Size = new System.Drawing.Size(741, 428);
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).EndInit();
            this.ucDefault1.WorkingArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkpContactPrefixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tools.Controls.ucDefault ucDefault1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tlkpContactPrefixBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPKContactPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueIdentifier;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.PictureEdit PicturePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPicture;
    }
}
