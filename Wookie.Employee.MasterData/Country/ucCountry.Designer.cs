namespace Wookie.Employee.MasterData.Country
{
    partial class ucCountry
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
            this.ucDefault1 = new Wookie.Tools.Controls.ucDefault();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tlkpCountryBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPKCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserCreated = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKUserChanged = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChangedOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUniqueIdentifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ShortnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PicturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForShortname = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).BeginInit();
            this.ucDefault1.WorkingArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkpCountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
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
            this.ucDefault1.Size = new System.Drawing.Size(819, 497);
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
            this.ucDefault1.WorkingArea.Size = new System.Drawing.Size(815, 458);
            this.ucDefault1.WorkingArea.TabIndex = 0;
            this.ucDefault1.BeforeDataLoad += new System.EventHandler(this.ucDefault1_BeforeDataLoad);
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
            this.splitContainerControl1.Size = new System.Drawing.Size(805, 448);
            this.splitContainerControl1.SplitterPosition = 186;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(805, 186);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tlkpCountryBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 27);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(801, 157);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tlkpCountryBindingSource
            // 
            this.tlkpCountryBindingSource.DataSource = typeof(Wookie.Employee.MasterData.Database.tlkpCountry);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPKCountry,
            this.colName,
            this.colShortname,
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
            // colPKCountry
            // 
            this.colPKCountry.FieldName = "PKCountry";
            this.colPKCountry.Name = "colPKCountry";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 666;
            // 
            // colShortname
            // 
            this.colShortname.FieldName = "Shortname";
            this.colShortname.Name = "colShortname";
            this.colShortname.Visible = true;
            this.colShortname.VisibleIndex = 2;
            this.colShortname.Width = 670;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 0;
            this.colPicture.Width = 43;
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
            this.dataLayoutControl1.Controls.Add(this.ShortnameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PicturePictureEdit);
            this.dataLayoutControl1.DataSource = this.tlkpCountryBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(805, 252);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkpCountryBindingSource, "Name", true));
            this.NameTextEdit.Location = new System.Drawing.Point(67, 12);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(726, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 4;
            // 
            // ShortnameTextEdit
            // 
            this.ShortnameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkpCountryBindingSource, "Shortname", true));
            this.ShortnameTextEdit.Location = new System.Drawing.Point(67, 36);
            this.ShortnameTextEdit.Name = "ShortnameTextEdit";
            this.ShortnameTextEdit.Size = new System.Drawing.Size(726, 20);
            this.ShortnameTextEdit.StyleController = this.dataLayoutControl1;
            this.ShortnameTextEdit.TabIndex = 5;
            // 
            // PicturePictureEdit
            // 
            this.PicturePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tlkpCountryBindingSource, "Picture", true));
            this.PicturePictureEdit.Location = new System.Drawing.Point(67, 60);
            this.PicturePictureEdit.Name = "PicturePictureEdit";
            this.PicturePictureEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.PicturePictureEdit.Size = new System.Drawing.Size(726, 180);
            this.PicturePictureEdit.StyleController = this.dataLayoutControl1;
            this.PicturePictureEdit.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(805, 252);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName,
            this.ItemForShortname,
            this.ItemForPicture});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(785, 232);
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 0);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(785, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForShortname
            // 
            this.ItemForShortname.Control = this.ShortnameTextEdit;
            this.ItemForShortname.Location = new System.Drawing.Point(0, 24);
            this.ItemForShortname.Name = "ItemForShortname";
            this.ItemForShortname.Size = new System.Drawing.Size(785, 24);
            this.ItemForShortname.Text = "Shortname";
            this.ItemForShortname.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForPicture
            // 
            this.ItemForPicture.Control = this.PicturePictureEdit;
            this.ItemForPicture.Location = new System.Drawing.Point(0, 48);
            this.ItemForPicture.Name = "ItemForPicture";
            this.ItemForPicture.Size = new System.Drawing.Size(785, 184);
            this.ItemForPicture.StartNewLine = true;
            this.ItemForPicture.Text = "Picture";
            this.ItemForPicture.TextSize = new System.Drawing.Size(52, 13);
            // 
            // popupMenu1
            // 
            this.popupMenu1.Name = "popupMenu1";
            // 
            // ucCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDefault1);
            this.Name = "ucCountry";
            this.Size = new System.Drawing.Size(819, 497);
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucDefault1.WorkingArea)).EndInit();
            this.ucDefault1.WorkingArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlkpCountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForShortname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tools.Controls.ucDefault ucDefault1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tlkpCountryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPKCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colShortname;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserCreated;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colFKUserChanged;
        private DevExpress.XtraGrid.Columns.GridColumn colChangedOn;
        private DevExpress.XtraGrid.Columns.GridColumn colUniqueIdentifier;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraEditors.TextEdit ShortnameTextEdit;
        private DevExpress.XtraEditors.PictureEdit PicturePictureEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForShortname;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPicture;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}
