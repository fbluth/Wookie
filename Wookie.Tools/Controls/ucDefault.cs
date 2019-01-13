using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System.Data.Linq;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.ButtonsPanelControl;
using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using DevExpress.Utils.Svg;

namespace Wookie.Tools.Controls
{
    [Designer(typeof(Wookie.Tools.Controls.TestControlDesigner))]   
    public partial class ucDefault : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        public enum Mode { Default = 0, Edit = 1 };

        public System.Data.Linq.DataContext DataContext { get; set; } = null;

        private List<GridView> GridViews { get; set; } = new List<GridView>();
        private List<TreeList> TreeLists { get; set; } = new List<TreeList>();
        private List<PopupMenu> PopupMenus = new List<PopupMenu>();

        private Dictionary<GridView, PopupMenu> gridConnector = new Dictionary<GridView, PopupMenu>();
        private Dictionary<TreeList, PopupMenu> treeConnector = new Dictionary<TreeList, PopupMenu>();
        
        private Dictionary<BindingSource, bool> ignore = new Dictionary<BindingSource, bool>();
        private ModulData modulData = null;
        private string captionDetail = null;
        private string caption = null;
        private IOverlaySplashScreenHandle handle = null;

        [Category("Data")]
        public event EventHandler BeforeDataSave;
        [Category("Data")]
        public event EventHandler DataSaved;
        [Category("Data")]
        public event EventHandler BeforeDataLoad;
        [Category("Data")]
        public event EventHandler DataLoaded;
        [Category("Data")]
        public event EventHandler DataRefresh;
        #endregion

        #region Constructor
        public ucDefault()
        {
            InitializeComponent();
        }
        #endregion

        #region Public Functions
        public void Initialize(ModulData modulData, bool loadData=true)
        {
            if (modulData != null)
            {
                this.modulData = modulData;
                this.SetMode(Mode.Default);
                if (loadData) this.LoadData();
            }
        }

        public void ShowProgressPanel()
        {
            try
            {
                OverlayWindowOptions options = new OverlayWindowOptions(true, true, Color.GhostWhite, Color.Black, 0.7);
                handle = SplashScreenManager.ShowOverlayForm(this, options);
            }
            catch
            {
            }
        }

        public void CloseProgressPanel()
        {
            try
            {
                if (handle != null)
                {
                    SplashScreenManager.CloseOverlayForm(handle);
                    handle = null;
                }
            }
            catch
            {
            }
        }

        public void RegisterPictureEdit(PictureEdit pictureEdit)
        {
            if (pictureEdit == null) return;

            pictureEdit.FormatEditValue += PictureEdit_FormatEditValue;
            pictureEdit.ParseEditValue += PictureEdit_ParseEditValue;
        }

        public void RegisterGridView(GridView gridView)
        {
            if (gridView == null) return;

            if (!this.GridViews.Contains(gridView))
            {
                this.GridViews.Add(gridView);
                gridView.BeforeLeaveRow += GridView_BeforeLeaveRow;
                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        public void RegisterTreeList(TreeList treeList)
        {
            if (treeList == null) return;

            if (!this.TreeLists.Contains(treeList))
            {
                this.TreeLists.Add(treeList);
                treeList.MouseDown += treeMenu_MouseDown;
            }
        }

        public void RegisterBindingSource(BindingSource bindingSource)
        {
            if (bindingSource == null) return;

            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            bindingSource.ListChanged += BindingSource_ListChanged;
            ignore.Add(bindingSource, true);
        }

        public void RegisterPopup(PopupMenu popupMenu)
        {
            if (popupMenu == null) return;

            if (!this.PopupMenus.Contains(popupMenu))
            {
                this.PopupMenus.Add(popupMenu);                
            }            
        }        

        public void Connect(GroupControl groupControl, GridView gridView, PopupMenu popupMenu, BindingSource bindingSource)
        {
            this.RegisterBindingSource(bindingSource);
            this.RegisterGridView(gridView);
            this.RegisterPopup(popupMenu);

            this.ConnectPopup(popupMenu, groupControl, gridView);
        }

        public void Connect(GroupControl groupControl, TreeList treeList, PopupMenu popupMenu, BindingSource bindingSource)
        {
            this.RegisterBindingSource(bindingSource);
            this.RegisterTreeList(treeList);
            this.RegisterPopup(popupMenu);

            this.ConnectPopup(popupMenu, groupControl, treeList);
        }     

        public void PostEditor()
        {
            foreach (GridView gridView in this.GridViews) gridView.PostEditor();
            foreach (TreeList treeList in this.TreeLists)
            {
                treeList.PostEditor();
                treeList.EndCurrentEdit();
            }
        }
        #endregion

        #region Public properties
        [Category("Appearance")]
        public System.Drawing.Image Image
        {
            get { return this.gcMain.CaptionImageOptions.Image; }
            set { this.gcMain.CaptionImageOptions.Image = value;}
        }

        [Category("Appearance")]
        public String Caption
        {
            get { return this.caption; }
            set { this.caption = value; this.SetCaption(); }
        }

        [Category("Appearance")]
        public String CaptionDetail
        {
            get { return this.captionDetail; }
            set { this.captionDetail = value; this.SetCaption(); }
        }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        /// <span class="code-SummaryComment"><summary></span>
        /// This property is essential to allowing the designer to work and
        /// the DesignerSerializationVisibility Attribute (above) is essential
        /// in allowing serialization to take place at design time.
        /// <span class="code-SummaryComment"></summary></span>
        public PanelControl WorkingArea
        {
            get { return this.pnlWorkingArea; }
        }

        [Category("Appearance"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public DXValidationProvider ValidationProvider
        {
            get { return this.dxValidationProvider; }
            set { this.dxValidationProvider = value; }
        }
        #endregion

        #region Private Functions
        private void SetMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Default:
                    this.gcMain.CustomHeaderButtons[0].Properties.Visible = false; // Save
                    this.gcMain.CustomHeaderButtons[1].Properties.Visible = false; // Cancel
                    this.gcMain.CustomHeaderButtons[2].Properties.Visible = true; // Refresh
                    break;
                case Mode.Edit:
                    this.gcMain.CustomHeaderButtons[0].Properties.Visible = true; // Save
                    this.gcMain.CustomHeaderButtons[1].Properties.Visible = true; // Cancel
                    this.gcMain.CustomHeaderButtons[2].Properties.Visible = false; // Refresh
                    break;
            }
        }

        private void LoadData()
        {
            try
            {
                this.ShowProgressPanel();

                this.BeforeDataLoad?.Invoke(this, new EventArgs());
                this.SetMode(Mode.Default);

                this.CloseProgressPanel();

                this.DataLoaded?.Invoke(this, new EventArgs());                
            }
            catch 
            {
                this.CloseProgressPanel();
                XtraMessageBox.Show("Fehler beim laden der Daten", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool SaveData()
        {
            try
            {
                BeforeDataSave?.Invoke(this, new EventArgs());

                this.PostEditor();

                if (dxValidationProvider != null)
                    if (!dxValidationProvider.Validate()) return false;

                if (this.DataContext != null)
                {
                    this.ShowProgressPanel();

                    this.DataContext.SubmitChanges(ConflictMode.ContinueOnConflict);
                    this.SetMode(Mode.Default);
                }

                DataSaved?.Invoke(this, new EventArgs());
                return true;
            }
            catch (ChangeConflictException e)
            {

                this.CloseProgressPanel();

                ucConflicts ucConflicts = new ucConflicts();

                if (this.DataContext.ChangeConflicts.Count > 0)
                {
                    foreach (System.Data.Linq.ObjectChangeConflict objectChangeConflict in this.DataContext.ChangeConflicts)
                    {
                        if (objectChangeConflict.IsDeleted)
                        {

                            Conflict conflict = new Conflict();
                            conflict.Message = "Der Datensatz existiert nicht mehr";
                            conflict.RefreshMode = RefreshMode.KeepChanges;
                            ucConflicts.Conflicts.Add(conflict);

                            //Database.tsysClient client = this.DataContext.ChangeConflicts[0].Object as Database.tsysClient;
                            //XtraMessageBox.Show(System.String.Format("Der Datensatz <b>\"{0}\"</b> existiert in der Datenbank nicht mehr.", client.Name), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, DevExpress.Utils.DefaultBoolean.True);
                        }
                        else if (objectChangeConflict.MemberConflicts.Count > 0 &&
                                 objectChangeConflict.MemberConflicts[0].IsModified)
                        {

                            Conflict conflict = new Conflict();
                            conflict.Message = "Der Datensatz wurde in der Datenbank geändert";
                            conflict.RefreshMode = RefreshMode.KeepChanges;
                            ucConflicts.Conflicts.Add(conflict);


                            //Database.tsysClient client = this.DataContext.ChangeConflicts[0].Object as Database.tsysClient;
                            //XtraMessageBox.Show(
                            //    System.String.Format(
                            //        "Der Datensatz <b>\"{0}\"</b> wurde in der Datenbank geändert. Datenbankwert: {2}, Neuer Wert: {1}",
                            //        this.DataContext.ChangeConflicts[0].MemberConflicts[0].Member.Name,
                            //        this.DataContext.ChangeConflicts[0].MemberConflicts[0].CurrentValue,
                            //        this.DataContext.ChangeConflicts[0].MemberConflicts[0].DatabaseValue),
                            //        "Fehler",
                            //        MessageBoxButtons.OK,
                            //        MessageBoxIcon.Exclamation,
                            //        DevExpress.Utils.DefaultBoolean.True);
                        }
                    }
                    //this.DataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);

                    frmConflict frm = new frmConflict(ucConflicts);
                    frm.ShowDialog();
                }

                

                return false;
            }
            catch (SqlException exception)
            {
                this.CloseProgressPanel();

                if (exception.Number == 547) // Constraint error
                    XtraMessageBox.Show("Datensatz wird noch von anderer Stelle referenziert und kann daher nicht gelöscht werden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    XtraMessageBox.Show(exception.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            catch (Exception err)
            {
                this.CloseProgressPanel();

                XtraMessageBox.Show(err.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                this.CloseProgressPanel();
            }
        }

        private void SetCaption()
        {
            this.gcMain.Text = this.caption;
            if (this.captionDetail != null)
                this.gcMain.Text += " (" + this.captionDetail + ")";
        }

        private void ConnectPopup(PopupMenu popupMenu, GroupControl groupControl, GridView gridView)
        {
            if (!this.gridConnector.ContainsKey(gridView))
            {
                this.gridConnector.Add(gridView, popupMenu);
            }

            this.ConnectPopup(popupMenu, groupControl);
        }

        private void ConnectPopup(PopupMenu popupMenu, GroupControl groupControl, TreeList treeList)
        {
            if (!this.treeConnector.ContainsKey(treeList))
            {
                this.treeConnector.Add(treeList, popupMenu);
            }

            this.ConnectPopup(popupMenu, groupControl);
        }

        private void ConnectPopup(PopupMenu popupMenu, GroupControl groupControl)
        {
            if (popupMenu == null || groupControl == null) return;

            foreach (LinkPersistInfo a in popupMenu.LinksPersistInfo)
            {
                ButtonImageOptions buttonImageOptions = new ButtonImageOptions();
                GroupBoxButton button = new GroupBoxButton();

                button.Tag = a.Item;
                button.Caption = a.Item.Caption;
                button.UseCaption = false;
                button.ToolTip = a.Item.Caption;
                button.ImageOptions.SvgImage = a.Item.ImageOptions.SvgImage;
                button.ImageOptions.SvgImageSize = new Size(16, 16);

                groupControl.CustomHeaderButtons.Add(button);
            }

            groupControl.CustomButtonClick += GroupControl_CustomButtonClick;
        }
        #endregion

        #region Handled Events
        private void GridView_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (dxValidationProvider != null && !dxValidationProvider.Validate()) e.Allow = false;
        }

        private void gcMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (gcMain.CustomHeaderButtons.IndexOf(e.Button))
            {
                case 0: //Speichern
                    this.SaveData();
                    break;
                case 1: //Abbrechen
                case 2: //Reload
                    this.LoadData();
                    break;
            }
        }

        private void GroupControl_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            BarItem item = e.Button.Properties.Tag as BarItem;
            if (item != null) item.PerformClick();
        }

        private void GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row || e.MenuType == GridMenuType.User)
            {
                if (this.gridConnector.ContainsKey((GridView)sender))
                {
                    PopupMenu popupMenu = this.gridConnector[(GridView)sender];
                    popupMenu.ShowPopup((new Point(MousePosition.X, MousePosition.Y)));
                }
            }
        }

        private void treeMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.treeConnector.ContainsKey((TreeList)sender))
            {
                if (e.Button == MouseButtons.Right)
                {
                    PopupMenu popupMenu = this.treeConnector[(TreeList)sender];
                    popupMenu.ShowPopup((new Point(MousePosition.X, MousePosition.Y)));
                }
            }
        }

        private void PictureEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            if (e.Value is DBNull || e.Value is System.Data.Linq.Binary)
                return;

            if (e.Value is System.Drawing.Image)
            {

                e.Value = Wookie.Tools.Image.Converter.GetBinaryFromImage((System.Drawing.Image)e.Value);
                e.Handled = true;
            }
            else if (e.Value is SvgImage)
            {
                e.Value = Wookie.Tools.Image.Converter.GetBinaryFromSvgImage((SvgImage)e.Value);
                e.Handled = true;
            }
        }

        private void PictureEdit_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            var data = e.Value as System.Data.Linq.Binary;
            if (data != null)
            {
                e.Handled = true;
                e.Value = data;
            }
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemChanged:
                case ListChangedType.ItemDeleted:
                    this.SetMode(Mode.Edit);
                    this.DataRefresh?.Invoke(this, new EventArgs());
                    break;
            }
        }

        private void BindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!this.ignore.ContainsKey((BindingSource)sender)) return;

            if (this.ignore[(BindingSource)sender]) this.ignore[(BindingSource)sender] = false;
            else this.SetMode(Mode.Edit);
        }

        private void BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!this.ignore.ContainsKey((BindingSource)sender)) return;

            this.ignore[(BindingSource)sender] = true;
            DataRefresh?.Invoke(this, new EventArgs());
        }

        private void ucDefault_VisibleChanged(object sender, EventArgs e)
        {
            foreach (PopupMenu popupMenu in this.PopupMenus)
            {
                foreach (LinkPersistInfo a in popupMenu.LinksPersistInfo)
                {
                    a.Item.Enabled = this.Visible;
                }
            }
        }
        #endregion
    }

    public class ModulData
    {
        public SqlConnection SqlConnection;
        public long? FKExternal;
        public List<long?> FKSelected { get; set; }
        public XtraUserControl DetailUserControl;
        public string UniqueIdentifier;
    }

    public class TestControlDesigner : ParentControlDesigner
    {
        public override void Initialize(System.ComponentModel.IComponent component)
        {
            base.Initialize(component);

            if (this.Control is ucDefault)
            {
                this.EnableDesignMode((
                   (ucDefault)this.Control).WorkingArea, "WorkingArea");
            }
        }
    }   
}
