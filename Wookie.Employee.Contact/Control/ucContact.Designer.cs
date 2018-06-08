namespace Wookie.Employee.Contact.Control
{
    partial class ucContact
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
            this.tblContactBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFKContactData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFKContactPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddlename = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPicture = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStreet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSkype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltlkpCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltlkpContactPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltblDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblContactBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1079, 535);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tblContactBindingSource
            // 
            this.tblContactBindingSource.DataSource = typeof(Wookie.Employee.Contact.Database.tblContact);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFKContactData,
            this.colFKDepartment,
            this.colFKCity,
            this.colFKContactPrefix,
            this.colTitle,
            this.colName,
            this.colSurname,
            this.colMiddlename,
            this.colPicture,
            this.colBirthdate,
            this.colStreet,
            this.colLogin,
            this.colHomePhone,
            this.colMobilePhone,
            this.colSkype,
            this.colEMail,
            this.coltlkpCity,
            this.coltlkpContactPrefix,
            this.coltblDepartment});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colFKContactData
            // 
            this.colFKContactData.FieldName = "FKContactData";
            this.colFKContactData.Name = "colFKContactData";
            this.colFKContactData.Visible = true;
            this.colFKContactData.VisibleIndex = 0;
            // 
            // colFKDepartment
            // 
            this.colFKDepartment.FieldName = "FKDepartment";
            this.colFKDepartment.Name = "colFKDepartment";
            this.colFKDepartment.Visible = true;
            this.colFKDepartment.VisibleIndex = 1;
            // 
            // colFKCity
            // 
            this.colFKCity.FieldName = "FKCity";
            this.colFKCity.Name = "colFKCity";
            this.colFKCity.Visible = true;
            this.colFKCity.VisibleIndex = 2;
            // 
            // colFKContactPrefix
            // 
            this.colFKContactPrefix.FieldName = "FKContactPrefix";
            this.colFKContactPrefix.Name = "colFKContactPrefix";
            this.colFKContactPrefix.Visible = true;
            this.colFKContactPrefix.VisibleIndex = 3;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 4;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 5;
            // 
            // colSurname
            // 
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 6;
            // 
            // colMiddlename
            // 
            this.colMiddlename.FieldName = "Middlename";
            this.colMiddlename.Name = "colMiddlename";
            this.colMiddlename.Visible = true;
            this.colMiddlename.VisibleIndex = 7;
            // 
            // colPicture
            // 
            this.colPicture.FieldName = "Picture";
            this.colPicture.Name = "colPicture";
            this.colPicture.Visible = true;
            this.colPicture.VisibleIndex = 8;
            // 
            // colBirthdate
            // 
            this.colBirthdate.FieldName = "Birthdate";
            this.colBirthdate.Name = "colBirthdate";
            this.colBirthdate.Visible = true;
            this.colBirthdate.VisibleIndex = 9;
            // 
            // colStreet
            // 
            this.colStreet.FieldName = "Street";
            this.colStreet.Name = "colStreet";
            this.colStreet.Visible = true;
            this.colStreet.VisibleIndex = 10;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 11;
            // 
            // colHomePhone
            // 
            this.colHomePhone.FieldName = "HomePhone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.Visible = true;
            this.colHomePhone.VisibleIndex = 12;
            // 
            // colMobilePhone
            // 
            this.colMobilePhone.FieldName = "MobilePhone";
            this.colMobilePhone.Name = "colMobilePhone";
            this.colMobilePhone.Visible = true;
            this.colMobilePhone.VisibleIndex = 13;
            // 
            // colSkype
            // 
            this.colSkype.FieldName = "Skype";
            this.colSkype.Name = "colSkype";
            this.colSkype.Visible = true;
            this.colSkype.VisibleIndex = 14;
            // 
            // colEMail
            // 
            this.colEMail.FieldName = "EMail";
            this.colEMail.Name = "colEMail";
            this.colEMail.Visible = true;
            this.colEMail.VisibleIndex = 15;
            // 
            // coltlkpCity
            // 
            this.coltlkpCity.FieldName = "tlkpCity";
            this.coltlkpCity.Name = "coltlkpCity";
            this.coltlkpCity.Visible = true;
            this.coltlkpCity.VisibleIndex = 16;
            // 
            // coltlkpContactPrefix
            // 
            this.coltlkpContactPrefix.FieldName = "tlkpContactPrefix";
            this.coltlkpContactPrefix.Name = "coltlkpContactPrefix";
            this.coltlkpContactPrefix.Visible = true;
            this.coltlkpContactPrefix.VisibleIndex = 17;
            // 
            // coltblDepartment
            // 
            this.coltblDepartment.FieldName = "tblDepartment";
            this.coltblDepartment.Name = "coltblDepartment";
            this.coltblDepartment.Visible = true;
            this.coltblDepartment.VisibleIndex = 18;
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(1079, 535);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblContactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tblContactBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFKContactData;
        private DevExpress.XtraGrid.Columns.GridColumn colFKDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colFKCity;
        private DevExpress.XtraGrid.Columns.GridColumn colFKContactPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddlename;
        private DevExpress.XtraGrid.Columns.GridColumn colPicture;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthdate;
        private DevExpress.XtraGrid.Columns.GridColumn colStreet;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colHomePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn colSkype;
        private DevExpress.XtraGrid.Columns.GridColumn colEMail;
        private DevExpress.XtraGrid.Columns.GridColumn coltlkpCity;
        private DevExpress.XtraGrid.Columns.GridColumn coltlkpContactPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn coltblDepartment;
    }
}
