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
            //SetMinHeight(1); 
            menuManager = new MenuManager(Wookie.Tools.Database.MasterDatabase.SqlConnectionMasterDB, this.navigationFrame1,this.accordionControl1);
            menuManager.ClientChanged += new ClientChangeEventHandler(this.ClientChange);
            menuManager.SettingsClicked += new EventHandler(this.SettingsClicked);
            menuManager.AddClients(this.btnClient);

            
        }

        private void SetMinHeight(int min)
        {
            SkinElement element = AccordionControlSkins.GetSkin(UserLookAndFeel.Default)[AccordionControlSkins.SkinRootGroup];
            element.ContentMargins.Top = element.ContentMargins.Bottom = 0;
            element.Size.MinSize = new Size(element.Size.MinSize.Width, min);

            element = AccordionControlSkins.GetSkin(UserLookAndFeel.Default)[AccordionControlSkins.SkinGroup];
            element.ContentMargins.Top = element.ContentMargins.Bottom = 0;
            element.Size.MinSize = new Size(element.Size.MinSize.Width, min);

            element = AccordionControlSkins.GetSkin(UserLookAndFeel.Default)[AccordionControlSkins.SkinItem];
            element.ContentMargins.Top = element.ContentMargins.Bottom = 0;
            element.Size.MinSize = new Size(element.Size.MinSize.Width, min);

            
        }

        public XtraForm1(XtraForm parent):this()
        {
            this.parent = parent;
        }

        private void ClientChange(object sender, ClientChangeEventArgs e)
        {            
            menuManager.LoadData(e.Client.PKClient);
            menuManager.AddSettings();

            this.navigationFrame1.SelectedPage = navPageWelcome;
            this.Text = "Wookie - " + e.Client.Name;
        }

        private void SettingsClicked(object sender, EventArgs e)
        {
            //this.barTool.Visible = !this.barTool.Visible;
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

        
    }
}