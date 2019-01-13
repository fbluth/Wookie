namespace Wookie.Ressource.Contact.Control{    partial class ucSelectedContact    {






        /// <summary>         /// Required designer variable.        /// </summary>        private System.ComponentModel.IContainer components = null;









        /// <summary>         /// Clean up any resources being used.        /// </summary>        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>        protected override void Dispose(bool disposing)        {            if (disposing && (components != null))            {                components.Dispose();            }            base.Dispose(disposing);        }











        #region Component Designer generated code
        /// <summary>         /// Required method for Designer support - do not modify         /// the contents of this method with the code editor.        /// </summary>        private void InitializeComponent()        {            this.picId = new DevExpress.XtraEditors.PictureEdit();
            this.pnlMain = new DevExpress.XtraEditors.SidePanel();
            this.pnlName = new DevExpress.XtraEditors.SidePanel();
            this.lblStreet = new DevExpress.XtraEditors.LabelControl();
            this.pnlPicture = new DevExpress.XtraEditors.SidePanel();
            this.lblTown = new DevExpress.XtraEditors.LabelControl();
            this.lblFederalState = new DevExpress.XtraEditors.LabelControl();
            this.lblCountry = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picId.Properties)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // picId
            // 
            this.picId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picId.Location = new System.Drawing.Point(0, 0);
            this.picId.Name = "picId";
            this.picId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picId.Properties.ReadOnly = true;
            this.picId.Properties.ShowMenu = false;
            this.picId.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picId.Size = new System.Drawing.Size(125, 79);
            this.picId.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BorderThickness = 0;
            this.pnlMain.Controls.Add(this.pnlName);
            this.pnlMain.Controls.Add(this.pnlPicture);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(125, 167);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlName
            // 
            this.pnlName.AllowResize = false;
            this.pnlName.BorderThickness = 0;
            this.pnlName.Controls.Add(this.lblCountry);
            this.pnlName.Controls.Add(this.lblFederalState);
            this.pnlName.Controls.Add(this.lblTown);
            this.pnlName.Controls.Add(this.lblStreet);
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlName.Location = new System.Drawing.Point(0, 79);
            this.pnlName.Name = "pnlName";
            this.pnlName.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlName.Size = new System.Drawing.Size(125, 88);
            this.pnlName.TabIndex = 1;
            // 
            // lblStreet
            // 
            this.lblStreet.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.Appearance.Options.UseFont = true;
            this.lblStreet.AutoEllipsis = true;
            this.lblStreet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStreet.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStreet.Location = new System.Drawing.Point(3, 16);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(119, 16);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Strasse";
            // 
            // pnlPicture
            // 
            this.pnlPicture.AllowResize = false;
            this.pnlPicture.BorderThickness = 0;
            this.pnlPicture.Controls.Add(this.picId);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 0);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(125, 79);
            this.pnlPicture.TabIndex = 0;
            // 
            // lblTown
            // 
            this.lblTown.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTown.Appearance.Options.UseFont = true;
            this.lblTown.AutoEllipsis = true;
            this.lblTown.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTown.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTown.Location = new System.Drawing.Point(3, 32);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(119, 16);
            this.lblTown.TabIndex = 3;
            this.lblTown.Text = "PLZ + Ort";
            // 
            // lblFederalState
            // 
            this.lblFederalState.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFederalState.Appearance.Options.UseFont = true;
            this.lblFederalState.AutoEllipsis = true;
            this.lblFederalState.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFederalState.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFederalState.Location = new System.Drawing.Point(3, 48);
            this.lblFederalState.Name = "lblFederalState";
            this.lblFederalState.Size = new System.Drawing.Size(119, 16);
            this.lblFederalState.TabIndex = 4;
            this.lblFederalState.Text = "Bundesland";
            // 
            // lblCountry
            // 
            this.lblCountry.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Appearance.Options.UseFont = true;
            this.lblCountry.AutoEllipsis = true;
            this.lblCountry.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCountry.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountry.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblCountry.Location = new System.Drawing.Point(3, 64);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(119, 18);
            this.lblCountry.TabIndex = 5;
            this.lblCountry.Text = "Land";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // ucSelectedContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlMain);
            this.Name = "ucSelectedContact";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(131, 173);
            ((System.ComponentModel.ISupportInitialize)(this.picId.Properties)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion
        private DevExpress.XtraEditors.PictureEdit picId;        private DevExpress.XtraEditors.SidePanel pnlMain;
        private DevExpress.XtraEditors.LabelControl lblStreet;
        private DevExpress.XtraEditors.SidePanel pnlName;
        private DevExpress.XtraEditors.SidePanel pnlPicture;
        private DevExpress.XtraEditors.LabelControl lblCountry;
        private DevExpress.XtraEditors.LabelControl lblFederalState;
        private DevExpress.XtraEditors.LabelControl lblTown;
        private DevExpress.XtraEditors.LabelControl lblName;
    }}