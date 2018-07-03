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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Wookie.Controls.MainSplashScreen), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.ToolTipSeparatorItem toolTipSeparatorItem1 = new DevExpress.Utils.ToolTipSeparatorItem();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barTool = new DevExpress.XtraBars.Bar();
            this.btnDuplicate = new DevExpress.XtraBars.BarButtonItem();
            this.btnClient = new DevExpress.XtraBars.BarSubItem();
            this.btnData = new DevExpress.XtraBars.BarSubItem();
            this.btnBelow = new DevExpress.XtraBars.BarButtonItem();
            this.btnRight = new DevExpress.XtraBars.BarButtonItem();
            this.btnOff = new DevExpress.XtraBars.BarButtonItem();
            this.btnDesign = new DevExpress.XtraBars.BarSubItem();
            this.btnSkin = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnStyle = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageWelcome = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barStatus,
            this.barTool});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnDuplicate,
            this.btnClient,
            this.btnData,
            this.btnBelow,
            this.btnRight,
            this.btnOff,
            this.btnDesign,
            this.btnSkin,
            this.btnStyle});
            this.barManager1.MainMenu = this.barTool;
            this.barManager1.MaxItemId = 34;
            this.barManager1.StatusBar = this.barStatus;
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Statusbar";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Statusbar";
            // 
            // barTool
            // 
            this.barTool.BarName = "Toolbar";
            this.barTool.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Right;
            this.barTool.DockCol = 0;
            this.barTool.DockRow = 0;
            this.barTool.DockStyle = DevExpress.XtraBars.BarDockStyle.Right;
            this.barTool.FloatLocation = new System.Drawing.Point(1045, 238);
            this.barTool.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDuplicate),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnData),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDesign)});
            this.barTool.OptionsBar.DrawDragBorder = false;
            this.barTool.OptionsBar.MultiLine = true;
            this.barTool.OptionsBar.UseWholeRow = true;
            this.barTool.Text = "Toolbar";
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Caption = "Fenster duplizieren";
            this.btnDuplicate.Id = 22;
            this.btnDuplicate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDuplicate.ImageOptions.SvgImage")));
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biDuplicate_ItemClick);
            // 
            // btnClient
            // 
            this.btnClient.Caption = "Mandant auswählen";
            this.btnClient.Id = 23;
            this.btnClient.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClient.ImageOptions.SvgImage")));
            this.btnClient.Name = "btnClient";
            this.btnClient.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btnData
            // 
            this.btnData.Caption = "Daten";
            this.btnData.Id = 24;
            this.btnData.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnData.ImageOptions.Image")));
            this.btnData.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnData.ImageOptions.LargeImage")));
            this.btnData.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBelow),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRight),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOff)});
            this.btnData.Name = "btnData";
            this.btnData.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btnBelow
            // 
            this.btnBelow.Caption = "Unten";
            this.btnBelow.Id = 25;
            this.btnBelow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBelow.ImageOptions.Image")));
            this.btnBelow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBelow.ImageOptions.LargeImage")));
            this.btnBelow.Name = "btnBelow";
            // 
            // btnRight
            // 
            this.btnRight.Caption = "Rechts";
            this.btnRight.Id = 26;
            this.btnRight.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.ImageOptions.Image")));
            this.btnRight.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRight.ImageOptions.LargeImage")));
            this.btnRight.Name = "btnRight";
            // 
            // btnOff
            // 
            this.btnOff.Caption = "Aus";
            this.btnOff.Id = 27;
            this.btnOff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOff.ImageOptions.Image")));
            this.btnOff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOff.ImageOptions.LargeImage")));
            this.btnOff.Name = "btnOff";
            // 
            // btnDesign
            // 
            this.btnDesign.Caption = "Design";
            this.btnDesign.Id = 31;
            this.btnDesign.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDesign.ImageOptions.Image")));
            this.btnDesign.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDesign.ImageOptions.LargeImage")));
            this.btnDesign.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSkin),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnStyle)});
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // btnSkin
            // 
            this.btnSkin.Id = 32;
            this.btnSkin.Name = "btnSkin";
            // 
            // btnStyle
            // 
            this.btnStyle.Caption = "Design";
            this.btnStyle.Id = 33;
            this.btnStyle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStyle.ImageOptions.Image")));
            this.btnStyle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnStyle.ImageOptions.LargeImage")));
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStyle_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 30);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1008, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 711);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1008, 18);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 681);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(970, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(38, 681);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Controls.Add(this.navigationFrame1);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(227, 30);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(743, 681);
            this.fluentDesignFormContainer1.TabIndex = 10;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navPageWelcome);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageWelcome});
            this.navigationFrame1.SelectedPage = this.navPageWelcome;
            this.navigationFrame1.Size = new System.Drawing.Size(743, 681);
            this.navigationFrame1.TabIndex = 1;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navPageWelcome
            // 
            this.navPageWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.navPageWelcome.Controls.Add(this.flyoutPanel1);
            this.navPageWelcome.Name = "navPageWelcome";
            this.navPageWelcome.Size = new System.Drawing.Size(743, 681);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(471, 186);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton(),
            new DevExpress.Utils.PeekFormButton()});
            this.flyoutPanel1.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanel1.OwnerControl = this.fluentDesignFormContainer1;
            this.flyoutPanel1.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.flyoutPanel1.ParentForm = this;
            this.flyoutPanel1.Size = new System.Drawing.Size(252, 373);
            this.flyoutPanel1.TabIndex = 16;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.accordionControl2);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 30);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(252, 343);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // accordionControl2
            // 
            this.accordionControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement6});
            this.accordionControl2.Location = new System.Drawing.Point(2, 2);
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.Size = new System.Drawing.Size(248, 339);
            this.accordionControl2.TabIndex = 0;
            this.accordionControl2.Text = "accordionControl2";
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "Settings";
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.MaximumTextHeight = 80;
            this.accordionControl1.OptionsMinimizing.NormalWidth = 200;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(227, 681);
            this.accordionControl1.TabIndex = 11;
            this.accordionControl1.Text = "T-Systems";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1008, 30);
            this.fluentDesignFormControl1.TabIndex = 12;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.ImageOptions.ImageLayoutMode = DevExpress.XtraBars.Navigation.ImageLayoutMode.Squeeze;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            toolTipTitleItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("resource.SvgImage")));
            toolTipTitleItem1.Text = "A";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "asfasd";
            toolTipTitleItem2.LeftIndent = 6;
            toolTipTitleItem2.Text = "TSystems";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            superToolTip1.Items.Add(toolTipSeparatorItem1);
            superToolTip1.Items.Add(toolTipTitleItem2);
            this.accordionControlElement2.SuperTip = superToolTip1;
            this.accordionControlElement2.Text = "Element2";
            // 
            // XtraForm1
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "XtraForm1";
            this.NavigationControl = this.accordionControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wookie";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navPageWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageWelcome;
        private DevExpress.XtraBars.BarButtonItem btnDuplicate;
        private DevExpress.XtraBars.BarSubItem btnClient;
        private DevExpress.XtraBars.BarSubItem btnData;
        private DevExpress.XtraBars.BarButtonItem btnBelow;
        private DevExpress.XtraBars.BarButtonItem btnRight;
        private DevExpress.XtraBars.BarButtonItem btnOff;
        private DevExpress.XtraBars.Bar barTool;
        private DevExpress.XtraBars.BarSubItem btnDesign;
        private DevExpress.XtraBars.SkinDropDownButtonItem btnSkin;
        private DevExpress.XtraBars.BarButtonItem btnStyle;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    }
}