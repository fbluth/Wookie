namespace Wookie.Tools.Controls
{
    partial class ucDefault
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDefault));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true, typeof(System.Windows.Forms.UserControl));
            this.gcMain = new DevExpress.XtraEditors.GroupControl();
            this.pnlWorkingArea = new DevExpress.XtraEditors.PanelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            this.gcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkingArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gcMain
            // 
            this.gcMain.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcMain.AppearanceCaption.Options.UseFont = true;
            this.gcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.gcMain.Controls.Add(this.pnlWorkingArea);
            buttonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonImageOptions1.SvgImage")));
            buttonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonImageOptions2.SvgImage")));
            buttonImageOptions3.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("buttonImageOptions3.SvgImage")));
            this.gcMain.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Speichern", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Abbrechen", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Aktualisieren", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.gcMain.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(0, 0);
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(487, 375);
            this.gcMain.TabIndex = 0;
            this.gcMain.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gcMain_CustomButtonClick);
            // 
            // pnlWorkingArea
            // 
            this.pnlWorkingArea.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlWorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkingArea.Location = new System.Drawing.Point(2, 37);
            this.pnlWorkingArea.Name = "pnlWorkingArea";
            this.pnlWorkingArea.Padding = new System.Windows.Forms.Padding(5);
            this.pnlWorkingArea.Size = new System.Drawing.Size(483, 336);
            this.pnlWorkingArea.TabIndex = 0;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ucDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcMain);
            this.Name = "ucDefault";
            this.Size = new System.Drawing.Size(487, 375);
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            this.gcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlWorkingArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcMain;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.PanelControl pnlWorkingArea;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}
