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

                menuManager.AddClients(this.btnClient);

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
            this.Text = Application.ProductName + " - " + sender.Name;
        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            flyoutPanel1.ShowPopup();
        }

        public void Duplicate(XtraForm parent)
        {
            XtraForm1 XtraForm1 = new XtraForm1(parent);
            XtraForm1.Show();
        }

        private void biDuplicate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (parent != null)
            {
                ((XtraForm1)this.parent).Duplicate(parent);
            }
            else
            {
                XtraForm1 XtraForm1 = new XtraForm1(this);
                XtraForm1.Show();
            }
        }       

        private void btnStyle_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (SvgSkinPaletteSelector svgSkinPaletteSelector = new SvgSkinPaletteSelector(this))
            {
                svgSkinPaletteSelector.ShowDialog();
            }
        }        

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Wookie.Tools.ImagePicker.ImagePicker imagePicker = new Tools.ImagePicker.ImagePicker();
            imagePicker.ShowDialog();
        }

        private void XtraForm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.parent == null)
            {
                if (XtraMessageBox.Show("Hauptfenster. Alle anderen Fenster werden ebenfalls geschlossen. Fortfahren?", "Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}