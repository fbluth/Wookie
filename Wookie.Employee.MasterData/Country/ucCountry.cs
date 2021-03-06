﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Wookie.Menu;

namespace Wookie.Employee.MasterData.Country
{
    public partial class ucCountry : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        private Database.MasterDataDataContext dataContext = null;
        private Wookie.Tools.Controls.ModulData modulData = null;

        public event StatusBarEventHandler StatusBarChanged;
        public event SelectionEventHandler SelectionChanged;
        #endregion

        #region Constructor
        public ucCountry()
        {
            InitializeComponent();

            this.ucDefault1.Connect(
                this.groupControl1,
                this.gridView1,
                this.popupMenu1,
                this.tlkpCountryBindingSource);

            this.ucDefault1.RegisterPictureEdit(this.PicturePictureEdit);

            this.SetValidationRules();
        }
        #endregion

        public void Activate(Wookie.Tools.Controls.ModulData modulData)
        {
            this.modulData = modulData;
            this.ucDefault1.Initialize(modulData);
        }

        #region Public properties
        public System.Drawing.Image Image
        {
            get { return this.ucDefault1.Image; }
            set { this.ucDefault1.Image = value; }
        }

        public String Caption
        {
            get { return this.ucDefault1.Caption; }
            set { this.ucDefault1.Caption = value; }
        }

        public String CaptionDetail
        {
            get { return this.ucDefault1.CaptionDetail; }
            set { this.ucDefault1.CaptionDetail = value; }
        }
        #endregion

        private void SetValidationRules()
        {

        }

        private void ucDefault1_BeforeDataLoad(object sender, EventArgs e)
        {
            this.dataContext = new Database.MasterDataDataContext(modulData.SqlConnection);
            this.ucDefault1.DataContext = this.dataContext;
            this.tlkpCountryBindingSource.DataSource = this.dataContext.tlkpCountry;
        }
    }
}
