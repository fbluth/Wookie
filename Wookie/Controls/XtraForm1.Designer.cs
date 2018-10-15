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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraForm1));
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navPageWelcome = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flyoutPanel1 = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.accordionControl2 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.aceMandant = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceClient = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceSettings = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.aceDuplicateWindow = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager();
            this.barStatus = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.itmSkin = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.itmColorSwatch = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.itemSkin = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.itemColorSwatch = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.accordionControl1 = new Wookie.Tools.Controls.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navPageWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).BeginInit();
            this.flyoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.fluentDesignFormContainer1.Appearance.Options.UseBackColor = true;
            this.fluentDesignFormContainer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fluentDesignFormContainer1.Controls.Add(this.navigationFrame1);
            this.fluentDesignFormContainer1.Controls.Add(this.barDockControlLeft);
            this.fluentDesignFormContainer1.Controls.Add(this.barDockControlRight);
            this.fluentDesignFormContainer1.Controls.Add(this.barDockControlBottom);
            this.fluentDesignFormContainer1.Controls.Add(this.barDockControlTop);
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(248, 30);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(769, 683);
            this.fluentDesignFormContainer1.TabIndex = 10;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navPageWelcome);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(0);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navPageWelcome});
            this.navigationFrame1.SelectedPage = this.navPageWelcome;
            this.navigationFrame1.Size = new System.Drawing.Size(769, 657);
            this.navigationFrame1.TabIndex = 6;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navPageWelcome
            // 
            this.navPageWelcome.Controls.Add(this.flyoutPanel1);
            this.navPageWelcome.Name = "navPageWelcome";
            this.navPageWelcome.Size = new System.Drawing.Size(769, 657);
            // 
            // flyoutPanel1
            // 
            this.flyoutPanel1.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanel1.Location = new System.Drawing.Point(462, 90);
            this.flyoutPanel1.Name = "flyoutPanel1";
            this.flyoutPanel1.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanel1.Options.CloseOnOuterClick = true;
            this.flyoutPanel1.OwnerControl = this.fluentDesignFormContainer1;
            this.flyoutPanel1.Size = new System.Drawing.Size(214, 436);
            this.flyoutPanel1.TabIndex = 0;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.accordionControl2);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanel1;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(214, 436);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // accordionControl2
            // 
            this.accordionControl2.AllowHorizontalResizing = DevExpress.Utils.DefaultBoolean.False;
            this.accordionControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceMandant,
            this.aceSettings});
            this.accordionControl2.Location = new System.Drawing.Point(2, 2);
            this.accordionControl2.Name = "accordionControl2";
            this.accordionControl2.OptionsHamburgerMenu.DisplayMode = DevExpress.XtraBars.Navigation.AccordionControlDisplayMode.Overlay;
            this.accordionControl2.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl2.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl2.Size = new System.Drawing.Size(210, 432);
            this.accordionControl2.TabIndex = 0;
            this.accordionControl2.Text = "accordionControl2";
            // 
            // aceMandant
            // 
            this.aceMandant.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceClient});
            this.aceMandant.Expanded = true;
            this.aceMandant.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceMandant.ImageOptions.SvgImage")));
            this.aceMandant.Name = "aceMandant";
            this.aceMandant.Text = "Mandanten";
            // 
            // aceClient
            // 
            this.aceClient.Expanded = true;
            this.aceClient.Name = "aceClient";
            this.aceClient.Text = "Mandanten";
            // 
            // aceSettings
            // 
            this.aceSettings.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceGeneral});
            this.aceSettings.Expanded = true;
            this.aceSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceSettings.ImageOptions.SvgImage")));
            this.aceSettings.Name = "aceSettings";
            this.aceSettings.Text = "Settings";
            // 
            // aceGeneral
            // 
            this.aceGeneral.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.aceDuplicateWindow});
            this.aceGeneral.Expanded = true;
            this.aceGeneral.Name = "aceGeneral";
            this.aceGeneral.Text = "Allgemein";
            // 
            // aceDuplicateWindow
            // 
            this.aceDuplicateWindow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("aceDuplicateWindow.ImageOptions.SvgImage")));
            this.aceDuplicateWindow.Name = "aceDuplicateWindow";
            this.aceDuplicateWindow.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.aceDuplicateWindow.Text = "Fenster duplizieren";
            this.aceDuplicateWindow.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 657);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barStatus});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this.fluentDesignFormContainer1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.itemSkin,
            this.itemColorSwatch,
            this.barStaticItem1,
            this.barSubItem1,
            this.itmSkin,
            this.itmColorSwatch});
            this.barManager1.MaxItemId = 22;
            this.barManager1.StatusBar = this.barStatus;
            // 
            // barStatus
            // 
            this.barStatus.BarName = "Benutzerdefiniert 2";
            this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStatus.DockCol = 0;
            this.barStatus.DockRow = 0;
            this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStatus.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.barStatus.OptionsBar.AllowQuickCustomization = false;
            this.barStatus.OptionsBar.DisableClose = true;
            this.barStatus.OptionsBar.DisableCustomization = true;
            this.barStatus.OptionsBar.DrawBorder = false;
            this.barStatus.OptionsBar.DrawDragBorder = false;
            this.barStatus.OptionsBar.UseWholeRow = true;
            this.barStatus.Text = "Benutzerdefiniert 2";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "mnuDesign";
            this.barSubItem1.Id = 17;
            this.barSubItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem1.ImageOptions.SvgImage")));
            this.barSubItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.itmSkin),
            new DevExpress.XtraBars.LinkPersistInfo(this.itmColorSwatch)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // itmSkin
            // 
            this.itmSkin.Id = 18;
            this.itmSkin.Name = "itmSkin";
            // 
            // itmColorSwatch
            // 
            this.itmColorSwatch.Caption = "Color Swatch";
            this.itmColorSwatch.Id = 19;
            this.itmColorSwatch.Name = "itmColorSwatch";
            this.itmColorSwatch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.itmColorSwatch_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(769, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 657);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(769, 26);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(769, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 657);
            // 
            // itemSkin
            // 
            this.itemSkin.Id = 1;
            this.itemSkin.Name = "itemSkin";
            // 
            // itemColorSwatch
            // 
            this.itemColorSwatch.Caption = "Color Swatch";
            this.itemColorSwatch.Id = 2;
            this.itemColorSwatch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("itemColorSwatch.ImageOptions.Image")));
            this.itemColorSwatch.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("itemColorSwatch.ImageOptions.LargeImage")));
            this.itemColorSwatch.Name = "itemColorSwatch";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 16;
            this.barStaticItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barStaticItem1.ImageOptions.LargeImage")));
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowHorizontalResizing = DevExpress.Utils.DefaultBoolean.True;
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.ExpandGroupOnHeaderClick = false;
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.NavigationFrame = null;
            this.accordionControl1.OptionsMinimizing.NormalWidth = 150;
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Auto;
            this.accordionControl1.Size = new System.Drawing.Size(248, 683);
            this.accordionControl1.TabIndex = 11;
            this.accordionControl1.Text = "T-Systems";
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Element1";
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.barManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(1017, 30);
            this.fluentDesignFormControl1.TabIndex = 12;
            this.fluentDesignFormControl1.TabStop = false;
            this.fluentDesignFormControl1.TitleItemLinks.Add(this.barStaticItem1);
            // 
            // XtraForm1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 713);
            this.ControlContainer = this.fluentDesignFormContainer1;
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Name = "XtraForm1";
            this.NavigationControl = this.accordionControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Name";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XtraForm1_FormClosing);
            this.fluentDesignFormContainer1.ResumeLayout(false);
            this.fluentDesignFormContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navPageWelcome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanel1)).EndInit();
            this.flyoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private Wookie.Tools.Controls.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinDropDownButtonItem itemSkin;
        private DevExpress.XtraBars.BarButtonItem itemColorSwatch;
        private DevExpress.XtraBars.Bar barStatus;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navPageWelcome;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem itmSkin;
        private DevExpress.XtraBars.BarButtonItem itmColorSwatch;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.Utils.FlyoutPanel flyoutPanel1;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceMandant;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceClient;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceSettings;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceDuplicateWindow;
        private DevExpress.XtraBars.Navigation.AccordionControlElement aceGeneral;
    }
}