namespace Wookie.Tools.ImagePicker
{
    partial class ImagePicker
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gControlImages = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient1 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cListBoxCategories = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.cListBoxSize = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.lblCategories = new DevExpress.XtraEditors.LabelControl();
            this.lblSize = new DevExpress.XtraEditors.LabelControl();
            this.lblCollection = new DevExpress.XtraEditors.LabelControl();
            this.cListBoxCollection = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gControlImages)).BeginInit();
            this.gControlImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gControlImages
            // 
            this.gControlImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gControlImages.Controls.Add(this.galleryControlClient1);
            this.gControlImages.DesignGalleryGroupIndex = 0;
            this.gControlImages.DesignGalleryItemIndex = 0;
            // 
            // 
            // 
            this.gControlImages.Gallery.AllowFilter = false;
            this.gControlImages.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.gControlImages.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            this.gControlImages.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.gControlImages_Gallery_ItemClick);
            this.gControlImages.Location = new System.Drawing.Point(163, 57);
            this.gControlImages.Name = "gControlImages";
            this.gControlImages.Size = new System.Drawing.Size(515, 390);
            this.gControlImages.TabIndex = 0;
            this.gControlImages.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControlImages;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(494, 386);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(603, 455);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(522, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cListBoxCategories
            // 
            this.cListBoxCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cListBoxCategories.Location = new System.Drawing.Point(12, 31);
            this.cListBoxCategories.Name = "cListBoxCategories";
            this.cListBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxCategories.Size = new System.Drawing.Size(145, 176);
            this.cListBoxCategories.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.cListBoxCategories.TabIndex = 3;
            this.cListBoxCategories.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxCategories_ItemCheck);
            this.cListBoxCategories.SelectedIndexChanged += new System.EventHandler(this.cListBoxCategories_SelectedIndexChanged);
            // 
            // cListBoxSize
            // 
            this.cListBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cListBoxSize.Location = new System.Drawing.Point(12, 232);
            this.cListBoxSize.Name = "cListBoxSize";
            this.cListBoxSize.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxSize.Size = new System.Drawing.Size(145, 47);
            this.cListBoxSize.TabIndex = 4;
            this.cListBoxSize.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxSize_ItemCheck);
            // 
            // lblCategories
            // 
            this.lblCategories.Location = new System.Drawing.Point(12, 12);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(52, 13);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSize.Location = new System.Drawing.Point(12, 213);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(19, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblCollection
            // 
            this.lblCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCollection.Location = new System.Drawing.Point(13, 285);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(46, 13);
            this.lblCollection.TabIndex = 5;
            this.lblCollection.Text = "Collection";
            // 
            // cListBoxCollection
            // 
            this.cListBoxCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cListBoxCollection.Location = new System.Drawing.Point(12, 304);
            this.cListBoxCollection.Name = "cListBoxCollection";
            this.cListBoxCollection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxCollection.Size = new System.Drawing.Size(145, 143);
            this.cListBoxCollection.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.cListBoxCollection.TabIndex = 6;
            this.cListBoxCollection.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxCollection_ItemCheck);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit1.Location = new System.Drawing.Point(163, 31);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Suche", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit1.Size = new System.Drawing.Size(515, 20);
            this.buttonEdit1.TabIndex = 7;
            this.buttonEdit1.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // ImagePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 488);
            this.Controls.Add(this.buttonEdit1);
            this.Controls.Add(this.cListBoxCollection);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblCategories);
            this.Controls.Add(this.cListBoxSize);
            this.Controls.Add(this.cListBoxCategories);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gControlImages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 376);
            this.Name = "ImagePicker";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImagePicker";
            ((System.ComponentModel.ISupportInitialize)(this.gControlImages)).EndInit();
            this.gControlImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.GalleryControl gControlImages;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient1;
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.CheckedListBoxControl cListBoxCategories;
        private DevExpress.XtraEditors.CheckedListBoxControl cListBoxSize;
        private DevExpress.XtraEditors.LabelControl lblCategories;
        private DevExpress.XtraEditors.LabelControl lblSize;
        private DevExpress.XtraEditors.LabelControl lblCollection;
        private DevExpress.XtraEditors.CheckedListBoxControl cListBoxCollection;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
    }
}