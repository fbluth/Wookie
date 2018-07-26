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

namespace Wookie.Controls
{
    public partial class XtraForm1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {

        private SqlConnection SqlConnection = new SqlConnection("Data Source=localhost;Initial Catalog=BS_PM_Mandant1;Persist Security Info=True;User ID=sa;Password=19theta#01");
        private MenuManager menuManager = null;
        private XtraForm parent = null;

        public XtraForm1()
        {
            InitializeComponent();

            menuManager = new MenuManager(Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB, this.navigationFrame1, this.accordionControl1);
            menuManager.ClientChanged += new ClientChangeEventHandler(this.ClientChange);
            menuManager.SettingsClicked += new EventHandler(this.SettingsClicked);
            menuManager.AddClients(this.btnClient);
            
        }

        

        public XtraForm1(XtraForm parent):this()
        {
            this.parent = parent;
        }

        private void ClientChange(object sender, ClientChangeEventArgs e)
        {            
            menuManager.LoadData(e.Client.PKClient,false);
            menuManager.AddSettings();

            this.navigationFrame1.SelectedPage = navPageWelcome;
            this.Text = "Wookie - " + e.Client.Name;
        }

        private void SettingsClicked(object sender, EventArgs e)
        {            
         
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

        private void btnSettings_ItemClick(object sender, ItemClickEventArgs e)
        {
            flyoutPanel1.ShowPopup();
        }

       

        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            if (
                accordionControl1.OptionsMinimizing.State == AccordionControlState.Minimized)
            {
                AccordionFlyoutForm a = accordionControl1.FlyoutForm;

            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Wookie.Tools.ImagePicker.ImagePicker imagePicker = new Tools.ImagePicker.ImagePicker();
            imagePicker.ShowDialog();
        }
    }
}