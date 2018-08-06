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
using DevExpress.XtraBars.Ribbon;
using DevExpress.Images;

namespace Wookie.Tools.ImagePicker
{
    public partial class ImagePicker : DevExpress.XtraEditors.XtraForm
    {
        private Dictionary<string, GalleryItem> galleryItemDictionary = new Dictionary<string, GalleryItem>();
        private System.Drawing.Image selectedImage = null;

        public ImagePicker()
        {
            InitializeComponent();

            List<string> collectionList = new List<string>();
            List<string> categoryList = new List<string>();
            List<string> sizeList = new List<string>{ "16x16", "32x32"};
            List<string> ressourceList = ImageResourceCache.Default.GetAllResourceKeys().ToList();

            ressourceList.Sort();

            foreach (string ressource in ressourceList)
            {
                if (ressource == null) continue;

                string[] part = ressource.Split('/');
                if (part != null && part.Length >= 2)
                {
                    if (!part[0].Contains("svg"))
                    {
                        if (!collectionList.Contains(part[0].Replace("%20", " "))) collectionList.Add(part[0].Replace("%20", " "));
                        if (!categoryList.Contains(part[1].Replace("%20", " "))) categoryList.Add(part[1].Replace("%20", " "));
                    }
                }
            }

            collectionList.Sort();
            categoryList.Sort();
            sizeList.Sort();

            FillListBox(cListBoxCollection, collectionList, "images");
            FillListBox(cListBoxCategories, categoryList, null);
            FillListBox(cListBoxSize, sizeList, "32x32");
            
            InitializeGallery(ressourceList);

            collectionList.Clear();
            categoryList.Clear();
            sizeList.Clear();
            ressourceList.Clear();
        }

        private void FillListBox(CheckedListBoxControl checkedListBoxControl, List<string> list, string checkedValue)
        {
            int counter = 0;
            checkedListBoxControl.Items.BeginUpdate();
            if (checkedListBoxControl != null && list != null)
            {
                foreach (string item in list)
                {
                    checkedListBoxControl.Items.Insert(counter++,new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, item, item==checkedValue|| checkedValue == null? CheckState.Checked: CheckState.Unchecked));
                }
            }
            checkedListBoxControl.Items.EndUpdate();
        }

        private void InitializeGallery(List <string> ressourceList)
        {
            if (ressourceList == null) return;

            GalleryItemGroup galleryItemGroup = null;
            GalleryItem galleryItem = null;
            Dictionary<string, GalleryItemGroup> galleryItemGroupDictionary = new Dictionary<string, GalleryItemGroup>();
                        
            gControlImages.Gallery.BeginUpdate();
            gControlImages.Gallery.Groups.Clear();

            foreach (string imageName in ressourceList)
            {
                if (imageName == null) continue;
                if (imageName.ToLower().EndsWith("svg")) continue;

                string[] part = imageName.Split('/');
                if (part != null && part.Length >= 2)
                {
                    part[1] = part[1].Replace("%20", " ");
                }

                if (galleryItemGroupDictionary.ContainsKey(part[1]))
                {
                    galleryItemGroup = galleryItemGroupDictionary[part[1]];
                }
                else
                {
                    galleryItemGroup = new GalleryItemGroup();
                    galleryItemGroup.Caption = part[1];
                    galleryItemGroupDictionary.Add(part[1], galleryItemGroup);
                }
                
                galleryItem = new GalleryItem();
                galleryItem.ImageOptions.Image = ImageResourceCache.Default.GetImage(imageName);
                galleryItem.Caption = imageName;

                DevExpress.Utils.SuperToolTip tip = new DevExpress.Utils.SuperToolTip();
                tip.Items.Add(part[2]);
                galleryItem.SuperTip = tip;
                galleryItemGroup.Items.Add(galleryItem);

                galleryItemDictionary.Add(imageName, galleryItem);
            }

            foreach (GalleryItemGroup group in galleryItemGroupDictionary.Values)
            {
                gControlImages.Gallery.Groups.Add(group);
            }

            gControlImages.Gallery.EndUpdate();

            ApplyFilter();
        }

        private void ApplyFilter()
        {
            gControlImages.Gallery.BeginUpdate();

            foreach (KeyValuePair<string, GalleryItem> item in galleryItemDictionary)
            {
                item.Value.Visible = false;

                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem checkedCollectionItem in this.cListBoxCollection.CheckedItems)
                {
                    foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem checkCategoryItem in this.cListBoxCategories.CheckedItems)
                    {
                        string res = checkedCollectionItem.Description.Replace(" ", "%20") + '/' + checkCategoryItem.Description.Replace(" ", "%20") + '/';

                        if (item.Key.StartsWith(res))
                        {
                            if ((cListBoxSize.Items[0].CheckState == CheckState.Checked && item.Key.Contains("16x16")) ||
                                    (cListBoxSize.Items[1].CheckState == CheckState.Checked && item.Key.Contains("32x32")))
                            {
                                item.Value.Visible = buttonEdit1.Text == null ? true : item.Key.Contains(buttonEdit1.Text);                                
                            }
                        }
                    }
                }
            }

            foreach (GalleryItemGroup group in this.gControlImages.Gallery.Groups)
            {
                int visibleItems = 0;

                foreach (GalleryItem item in group.Items)
                {
                    if (item.Visible) { visibleItems++; break; }
                }

                group.Visible = visibleItems > 0;
            }

            gControlImages.Gallery.EndUpdate();                     
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cListBoxCategories_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            this.ApplyFilter();
        }

        private void cListBoxCollection_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            this.ApplyFilter();
        }
        
        private void cListBoxSize_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            this.ApplyFilter();
        }

        private void gControlImages_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            selectedImage = e.Item.ImageOptions.Image;
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {
            this.ApplyFilter();
        }

        private void cListBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public System.Drawing.Image SelectedImage
        {
            get { return this.selectedImage; }
        }

        private void buttonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }
    }
}