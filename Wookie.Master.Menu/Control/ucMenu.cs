using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace Wookie.Master.Menu.Control
{
    public partial class ucMenu : DevExpress.XtraEditors.XtraUserControl
    {
        private Database.MenuDataContext dataContext = null;
        private ModulData modulData = null;

        public ucMenu(ModulData modulData)
        {
            InitializeComponent();
            this.modulData = modulData;
            dataContext = new Database.MenuDataContext(modulData.SqlConnectionClientDB);

            this.tsysSubCategoryBindingSource.DataSource = dataContext.tsysSubCategory;
            this.tsysClientBindingSource.DataSource = dataContext.tsysClient;
            //this.tsysModulGroupBindingSource.DataSource = dataContext.tsysModulGroup;
        }

        private void RefreshDataOnScreen()
        {
            Database.tsysClient c = (Database.tsysClient)tsysClientBindingSource.Current;
            tsysModulGroupBindingSource.DataSource = c;                            
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
         
        }

        private void tsysClientBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            RefreshDataOnScreen();
        }

        private void repositoryItemPictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            // dataContext.SubmitChanges();

            Database.tsysClient c1 = (Database.tsysClient)tsysClientBindingSource.Current;


            c1.Image = Wookie.Tools.Image.Converter.GetBinaryFromImage(((PictureEdit)sender).Image as Image);
            

                dataContext.SubmitChanges();
            


        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (((PictureEdit)sender).EditValue is Image)
            {
                Database.tsysClient c = (Database.tsysClient)tsysClientBindingSource.Current;
                c.Image = Wookie.Tools.Image.Converter.GetBinaryFromImage(((PictureEdit)sender).EditValue as Image);

                dataContext.SubmitChanges();
            }
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            Wookie.Tools.ImagePicker.ImagePicker imagePicker = new Tools.ImagePicker.ImagePicker();
            if (imagePicker.ShowDialog() == DialogResult.OK)
                pictureEdit1.Image = imagePicker.SelectedImage;
        }
    }
}
