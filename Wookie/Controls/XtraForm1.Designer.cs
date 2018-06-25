namespace Wookie.Controls
{
    partial class XtraForm1
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Wookie.Controls.MainSplashScreen), true, true, true);
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblRecords = new DevExpress.XtraBars.BarStaticItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnDuplicate = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnSkin = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnStyle = new DevExpress.XtraBars.BarButtonItem();
            this.btnClient = new DevExpress.XtraBars.BarSubItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Location = new System.Drawing.Point(0, 28);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 226;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(216, 677);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblRecords,
            this.skinBarSubItem1,
            this.btnDuplicate,
            this.btnMenu,
            this.btnSkin,
            this.btnStyle,
            this.btnClient});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 20;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Statusleiste";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblRecords)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Statusleiste";
            // 
            // lblRecords
            // 
            this.lblRecords.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.lblRecords.Caption = "Records: 4";
            this.lblRecords.Id = 0;
            this.lblRecords.Name = "lblRecords";
            // 
            // bar2
            // 
            this.bar2.BarName = "Benutzerdefiniert 3";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDuplicate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSkin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStyle),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClient, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Benutzerdefiniert 3";
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnDuplicate.Id = 7;
            this.btnDuplicate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDuplicate.ImageOptions.SvgImage")));
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDuplicate_ItemClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Id = 11;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnSkin
            // 
            this.btnSkin.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnSkin.Id = 16;
            this.btnSkin.Name = "btnSkin";
            // 
            // btnStyle
            // 
            this.btnStyle.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnStyle.Caption = "Style";
            this.btnStyle.Id = 17;
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // btnClient
            // 
            this.btnClient.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnClient.Id = 18;
            this.btnClient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClient.ImageOptions.SvgImage")));
            this.btnClient.Name = "btnClient";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 705);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 677);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1008, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 677);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 2;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(216, 28);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.SelectedPage = null;
            this.navigationFrame1.Size = new System.Drawing.Size(792, 677);
            this.navigationFrame1.TabIndex = 5;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // XtraForm1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "XtraForm1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wookie";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarStaticItem lblRecords;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnDuplicate;
        private DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.SkinDropDownButtonItem btnSkin;
        private DevExpress.XtraBars.BarButtonItem btnStyle;
        private DevExpress.XtraBars.BarSubItem btnClient;
    }
}