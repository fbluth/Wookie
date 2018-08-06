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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.galleryControl1 = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient2 = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gControlImages)).BeginInit();
            this.gControlImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cListBoxCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).BeginInit();
            this.galleryControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
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
            this.gControlImages.Location = new System.Drawing.Point(154, 54);
            this.gControlImages.Name = "gControlImages";
            this.gControlImages.Size = new System.Drawing.Size(584, 369);
            this.gControlImages.TabIndex = 0;
            this.gControlImages.Text = "galleryControl1";
            // 
            // galleryControlClient1
            // 
            this.galleryControlClient1.GalleryControl = this.gControlImages;
            this.galleryControlClient1.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient1.Size = new System.Drawing.Size(563, 365);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(656, 461);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(575, 461);
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
            this.cListBoxCategories.Location = new System.Drawing.Point(3, 28);
            this.cListBoxCategories.Name = "cListBoxCategories";
            this.cListBoxCategories.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxCategories.Size = new System.Drawing.Size(145, 167);
            this.cListBoxCategories.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.cListBoxCategories.TabIndex = 3;
            this.cListBoxCategories.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxCategories_ItemCheck);
            this.cListBoxCategories.SelectedIndexChanged += new System.EventHandler(this.cListBoxCategories_SelectedIndexChanged);
            // 
            // cListBoxSize
            // 
            this.cListBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cListBoxSize.Location = new System.Drawing.Point(3, 220);
            this.cListBoxSize.Name = "cListBoxSize";
            this.cListBoxSize.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxSize.Size = new System.Drawing.Size(145, 47);
            this.cListBoxSize.TabIndex = 4;
            this.cListBoxSize.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxSize_ItemCheck);
            // 
            // lblCategories
            // 
            this.lblCategories.Location = new System.Drawing.Point(3, 9);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(52, 13);
            this.lblCategories.TabIndex = 5;
            this.lblCategories.Text = "Categories";
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSize.Location = new System.Drawing.Point(3, 201);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(19, 13);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblCollection
            // 
            this.lblCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCollection.Location = new System.Drawing.Point(3, 273);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(46, 13);
            this.lblCollection.TabIndex = 5;
            this.lblCollection.Text = "Collection";
            // 
            // cListBoxCollection
            // 
            this.cListBoxCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cListBoxCollection.Location = new System.Drawing.Point(3, 292);
            this.cListBoxCollection.Name = "cListBoxCollection";
            this.cListBoxCollection.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.cListBoxCollection.Size = new System.Drawing.Size(145, 131);
            this.cListBoxCollection.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.cListBoxCollection.TabIndex = 6;
            this.cListBoxCollection.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.cListBoxCollection_ItemCheck);
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit1.Location = new System.Drawing.Point(154, 28);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "Suche", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.buttonEdit1.Size = new System.Drawing.Size(584, 20);
            this.buttonEdit1.TabIndex = 7;
            this.buttonEdit1.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(743, 455);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.lblCategories);
            this.xtraTabPage1.Controls.Add(this.cListBoxCollection);
            this.xtraTabPage1.Controls.Add(this.buttonEdit1);
            this.xtraTabPage1.Controls.Add(this.lblCollection);
            this.xtraTabPage1.Controls.Add(this.cListBoxCategories);
            this.xtraTabPage1.Controls.Add(this.cListBoxSize);
            this.xtraTabPage1.Controls.Add(this.lblSize);
            this.xtraTabPage1.Controls.Add(this.gControlImages);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(741, 426);
            this.xtraTabPage1.Text = "Predefined Icons";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.buttonEdit2);
            this.xtraTabPage2.Controls.Add(this.galleryControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(741, 426);
            this.xtraTabPage2.Text = "Choose File";
            // 
            // galleryControl1
            // 
            this.galleryControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.galleryControl1.Controls.Add(this.galleryControlClient2);
            this.galleryControl1.DesignGalleryGroupIndex = 0;
            this.galleryControl1.DesignGalleryItemIndex = 0;
            // 
            // 
            // 
            this.galleryControl1.Gallery.AllowFilter = false;
            this.galleryControl1.Gallery.ImageSize = new System.Drawing.Size(32, 32);
            this.galleryControl1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck;
            this.galleryControl1.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.gControlImages_Gallery_ItemClick);
            this.galleryControl1.Location = new System.Drawing.Point(11, 42);
            this.galleryControl1.Name = "galleryControl1";
            this.galleryControl1.Size = new System.Drawing.Size(719, 381);
            this.galleryControl1.TabIndex = 1;
            this.galleryControl1.Text = "galleryControl1";
            // 
            // galleryControlClient2
            // 
            this.galleryControlClient2.GalleryControl = this.galleryControl1;
            this.galleryControlClient2.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient2.Size = new System.Drawing.Size(698, 377);
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.Location = new System.Drawing.Point(11, 18);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttonEdit2.Size = new System.Drawing.Size(719, 20);
            this.buttonEdit2.TabIndex = 2;
            this.buttonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit2_ButtonClick);
            // 
            // ImagePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 494);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl1)).EndInit();
            this.galleryControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
        private DevExpress.XtraBars.Ribbon.GalleryControl galleryControl1;
        private DevExpress.XtraBars.Ribbon.GalleryControlClient galleryControlClient2;
    }
}