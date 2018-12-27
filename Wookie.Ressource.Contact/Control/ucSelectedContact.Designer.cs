namespace Wookie.Ressource.Contact.Control{    partial class ucSelectedContact    {






        /// <summary>         /// Required designer variable.        /// </summary>        private System.ComponentModel.IContainer components = null;









        /// <summary>         /// Clean up any resources being used.        /// </summary>        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>        protected override void Dispose(bool disposing)        {            if (disposing && (components != null))            {                components.Dispose();            }            base.Dispose(disposing);        }











        #region Component Designer generated code
        /// <summary>         /// Required method for Designer support - do not modify         /// the contents of this method with the code editor.        /// </summary>        private void InitializeComponent()        {            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSelectedContact));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions3 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.picId = new DevExpress.XtraEditors.PictureEdit();
            this.lblPrefix = new DevExpress.XtraEditors.LabelControl();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picId
            // 
            this.picId.Location = new System.Drawing.Point(4, 4);
            this.picId.Name = "picId";
            this.picId.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picId.Properties.ReadOnly = true;
            this.picId.Properties.ShowMenu = false;
            this.picId.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picId.Size = new System.Drawing.Size(125, 125);
            this.picId.TabIndex = 0;
            // 
            // lblPrefix
            // 
            this.lblPrefix.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrefix.Appearance.Options.UseFont = true;
            this.lblPrefix.Location = new System.Drawing.Point(136, 18);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(40, 19);
            this.lblPrefix.TabIndex = 1;
            this.lblPrefix.Text = "Prefix";
            // 
            // lblName
            // 
            this.lblName.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Location = new System.Drawing.Point(136, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 23);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            windowsUIButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions1.SvgImage")));
            windowsUIButtonImageOptions1.SvgImageSize = new System.Drawing.Size(16, 16);
            windowsUIButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions2.SvgImage")));
            windowsUIButtonImageOptions2.SvgImageSize = new System.Drawing.Size(16, 16);
            windowsUIButtonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("windowsUIButtonImageOptions3.SvgImage")));
            windowsUIButtonImageOptions3.SvgImageSize = new System.Drawing.Size(16, 16);
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Mail", false, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Mobil", false, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Privat", false, windowsUIButtonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(135, 88);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(238, 41);
            this.windowsUIButtonPanel1.TabIndex = 3;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // ucSelectedContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPrefix);
            this.Controls.Add(this.picId);
            this.Name = "ucSelectedContact";
            this.Size = new System.Drawing.Size(376, 150);
            ((System.ComponentModel.ISupportInitialize)(this.picId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private DevExpress.XtraEditors.PictureEdit picId;        private DevExpress.XtraEditors.LabelControl lblPrefix;        private DevExpress.XtraEditors.LabelControl lblName;        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;    }}