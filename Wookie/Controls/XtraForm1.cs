using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Reflection;
using Wookie.Menu.MenuManager;
using System.Data.SqlClient;
using DevExpress.Customization;
using DevExpress.XtraBars;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars.Navigation;
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

        public XtraForm1()
        {
            InitializeComponent();
            SplashScreenManager.ShowImage(Image.FromFile(".\\Images\\Splash.png"), true, true, SplashImagePainter.Painter);
                        
            SetSplashScreenInfo("Check connection to master database", 25);
            
            if (MasterDatabase.KeyFileExists && MasterDatabase.Connected)
            {
                SetSplashScreenInfo("Building menu",50);
               
                menuManager = new MenuManager(MasterDatabase.SqlConnection, this.navigationFrame1, this.accordionControl1);
                menuManager.ClientChanged += MenuManager_ClientChanged;
                menuManager.SettingsClicked += new EventHandler(this.SettingsClicked);

                SetSplashScreenInfo("Adding registered clients", 75);

                menuManager.AddClients(this.aceClientList);

                SetSplashScreenInfo("Done", 100);                
            }            
        }

       
        public XtraForm1(XtraForm parent):this()
        {
            this.parent = parent;
        }

        private void SetSplashScreenInfo(string text, int counter)
        {
            SplashImagePainter.Painter.ViewInfo.Stage = text;
            SplashImagePainter.Painter.ViewInfo.Counter = counter;
            SplashScreenManager.Default.Invalidate();
        }
        
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);           
            SplashScreenManager.HideImage();
        }


        private void MenuManager_ClientChanged(Menu.Client sender)
        {
            menuManager.LoadMenu(sender);
            menuManager.AddSettings();

            this.navigationFrame1.SelectedPage = navPageWelcome;
            this.HtmlText = "<b>" + Application.ProductName + "</b>" + " - <i>" + sender.Name + "</i>";
        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            flyoutPanel1.ShowPopup();
        }

        public void Duplicate(XtraForm parent)
        {
            ((XtraForm1)parent).FormCounter++;
            XtraForm1 XtraForm1 = new XtraForm1(parent);
            XtraForm1.Show();
        }

        private void btnStyle_ItemClick(object sender, ItemClickEventArgs e)
        {

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
            if (parent != null)
            {
                ((XtraForm1)this.parent).Duplicate(parent);
            }
            else
            {
                Duplicate(this);
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector(this))
            {
                svgSkinPaletteSelector.ShowDialog();
            }
        }
    }
}