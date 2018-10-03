using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Wookie.Menu.MenuManager;
using DevExpress.Customization;
using DevExpress.XtraBars;
using Wookie.Tools.Database;
using DevExpress.XtraSplashScreen;

namespace Wookie.Controls
{
    public partial class XtraForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        #region Variables
        private MenuManager menuManager = null;
        private XtraForm parent = null;
        public int FormCounter = 0;
        #endregion

        #region Constructor
        public XtraForm1()
        {
            InitializeComponent();

            this.accordionControl1.NavigationFrame = this.navigationFrame1;

            SplashScreenManager.ShowImage(Image.FromFile(".\\Images\\Splash.png"), true, true, SplashImagePainter.Painter);
                        
            this.SetSplashScreenInfo("Checking connection to master database", 25);
            
            if (MasterDatabase.KeyFileExists && MasterDatabase.Connected)
            {
                this.SetSplashScreenInfo("Building menu",50);               
                this.menuManager = new MenuManager(MasterDatabase.SqlConnection, this.navigationFrame1, this.accordionControl1, this.barStatus);
                this.menuManager.ClientChanged += new MenuManager.ClientChangeEventHandler(MenuManager_ClientChanged);
                this.menuManager.SettingsClicked += new EventHandler(this.SettingsClicked);
                this.menuManager.CategoryChanged += MenuManager_CategoryChanged;
                this.SetSplashScreenInfo("Adding registered clients", 75);
                this.menuManager.AddClients(this.aceClient);
                this.SetSplashScreenInfo("Done", 100);                
            }            
        }

        public XtraForm1(XtraForm parent):this()
        {
            this.parent = parent;
        }
        #endregion

        #region Private Functions
        private void SetSplashScreenInfo(string text, int counter)
        {
            SplashImagePainter.Painter.ViewInfo.Stage = text;
            SplashImagePainter.Painter.ViewInfo.Counter = counter;
            SplashScreenManager.Default.Invalidate();
        }

        private void SetTitle(string caption, Image image)
        {
            this.barStaticItem1.Caption = caption;
            if (image != null && image.Size.Width > 16)
                this.barStaticItem1.ImageOptions.Image = Wookie.Tools.Image.Converter.ResizeImage(image, 16, 16);
            else
                this.barStaticItem1.ImageOptions.Image = null;
        }
        #endregion

        #region Public Functions
        public void Duplicate(XtraForm parent)
        {
            ((XtraForm1)parent).FormCounter++;
            XtraForm1 XtraForm1 = new XtraForm1(parent);
            XtraForm1.Show();
        }
        #endregion

        #region Events
        private void MenuManager_ClientChanged(Menu.Client sender)
        {
            if (sender == null) return;

            this.navigationFrame1.SelectedPage = navPageWelcome;
            this.HtmlText = "<b>" + Application.ProductName + "</b>" + " - " + sender.Name;
            this.SetTitle(null, null);
        }

        private void MenuManager_CategoryChanged(string caption, Image image)
        {

        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            this.flyoutPanel1.ShowPopup();
        }

        private void XtraForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.parent == null && this.FormCounter > 0)
            {
                if (XtraMessageBox.Show("Hauptfenster. Alle anderen Fenster werden ebenfalls geschlossen. Fortfahren?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
            else if (this.parent != null) ((XtraForm1)parent).FormCounter--;
        }

        private void btnDuplicate_Click(object sender, EventArgs e)
        {
            if (this.parent != null)
            {
                ((XtraForm1)this.parent).Duplicate(this.parent);
            }
            else
            {
                this.Duplicate(this);
            }
        }

        private void itmColorSwatch_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector(this))
            {
                svgSkinPaletteSelector.ShowDialog();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SplashScreenManager.HideImage();
        }
        #endregion
    }
}