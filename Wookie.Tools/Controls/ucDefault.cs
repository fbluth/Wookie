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
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.Utils.Menu;
using System.Drawing;

namespace Wookie.Tools.Controls
{
    [Designer(typeof(Wookie.Tools.Controls.TestControlDesigner))]
    public partial class ucDefault : DevExpress.XtraEditors.XtraUserControl
    {
        #region Variables
        public enum Mode { Default = 0, Edit = 1 };
        private List<GridView> GridViews { get; set; } = new List<GridView>();
        private List<TreeList> TreeLists { get; set; } = new List<TreeList>();
        private Dictionary<GridView, GroupControl> gridConnector = new Dictionary<GridView, GroupControl>();
        private Dictionary<TreeList, GroupControl> treeConnector = new Dictionary<TreeList, GroupControl>();
        public System.Data.Linq.DataContext DataContext { get; set; } = null;
        private Dictionary<BindingSource, bool> ignore = new Dictionary<BindingSource, bool>();
        private ModulData modulData = null;

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
        public void Initialize(ModulData modulData)
        {
            if (modulData != null)
            {
                this.modulData = modulData;
                this.SetMode(Mode.Default);                
                this.LoadData();
            }
        }

        public void RegisterGridView(GridView gridView)
        {
            if (!this.GridViews.Contains(gridView))
            {
                this.GridViews.Add(gridView);
                gridView.BeforeLeaveRow += GridView_BeforeLeaveRow;                
            }
        }

        public void RegisterTreeList(TreeList treeList)
        {
            if (!this.TreeLists.Contains(treeList))
            {
                this.TreeLists.Add(treeList);
            }
        }

        public void RegisterBindingSource(BindingSource bindingSource)
        {
            bindingSource.CurrentChanged += BindingSource_CurrentChanged;
            bindingSource.CurrentItemChanged += BindingSource_CurrentItemChanged;
            bindingSource.ListChanged += BindingSource_ListChanged;
            ignore.Add(bindingSource, true);
        }

        public void ConnectGroupControlWithGridView(GroupControl groupControl, GridView gridView)
        {
            if (!this.gridConnector.ContainsKey(gridView))
            {
                this.gridConnector.Add(gridView, groupControl);
                gridView.PopupMenuShowing += GridView_PopupMenuShowing;
            }
        }

        public void ConnectGroupControlWithTreeList(GroupControl groupControl, TreeList treeList)
        {
            if (!this.treeConnector.ContainsKey(treeList))
            {
                this.treeConnector.Add(treeList, groupControl);
                treeList.MouseDown += treeMenu_MouseDown;
            }
        }

        private void GridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row || e.MenuType == GridMenuType.User)
            {
                if (this.gridConnector.ContainsKey((GridView)sender))
                {
                    if (e.Menu == null) e.Menu = new GridViewMenu((GridView)sender);
                    GridViewMenu menu = e.Menu as GridViewMenu;
                    GroupControl groupControl = this.gridConnector[(GridView)sender];
                    foreach (GroupBoxButton button in groupControl.CustomHeaderButtons)
                    {
                        DXMenuItem item = new DXMenuItem(button.Caption, new EventHandler(OnItemClick));
                        item.ImageOptions.Image = button.ImageOptions.Image;
                        item.ImageOptions.SvgImage = button.ImageOptions.SvgImage;
                        item.Tag = groupControl.CustomHeaderButtons.IndexOf(button);
                        menu.Items.Add(item); 
                    }                    
                }
            }
        }

        private void OnItemClick(object sender, EventArgs e)
        {
            
        }

        private void treeMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.treeConnector.ContainsKey((TreeList)sender))
            {
                TreeList view = sender as TreeList;
                TreeListHitInfo hi = view.CalcHitInfo(new Point(e.X, e.Y));

                if (e.Button == MouseButtons.Right)
                {
                    DevExpress.XtraTreeList.Menu.TreeListMenu menu = new DevExpress.XtraTreeList.Menu.TreeListMenu((TreeList)sender);
                    GroupControl groupControl = this.treeConnector[(TreeList)sender];
                    
                    foreach (GroupBoxButton button in groupControl.CustomHeaderButtons)
                    {
                        DXMenuItem item = new DXMenuItem(button.Caption, new EventHandler(OnItemClick));
                        item.ImageOptions.Image = button.ImageOptions.Image;
                        item.ImageOptions.SvgImage = button.ImageOptions.SvgImage;
                        item.Tag = groupControl.CustomHeaderButtons.IndexOf(button);
                        menu.Items.Add(item);
                    }
                    
                    menu.Init(hi);
                    menu.Show(hi.HitTest.MousePoint);
                }                
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
                    break;                
            }
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
            get { return this.gcMain.Text; }
            set { this.gcMain.Text = value; }
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

        private void LoadData()
        {
            try
            {
                BeforeDataLoad?.Invoke(this, new EventArgs());

                this.splashScreenManager.ShowWaitForm();
                this.splashScreenManager.SetWaitFormCaption("Lade Daten");
                this.splashScreenManager.SetWaitFormDescription("Bitte warten");

                this.SetMode(Mode.Default);
                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();

                DataLoaded?.Invoke(this, new EventArgs());
            }
            catch
            {
                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();
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
                    this.splashScreenManager.ShowWaitForm();
                    this.splashScreenManager.SetWaitFormCaption("Speichere Daten");
                    this.splashScreenManager.SetWaitFormDescription("Bitte warten");

                    this.DataContext.SubmitChanges(ConflictMode.FailOnFirstConflict);
                    this.SetMode(Mode.Default);
                }

                DataSaved?.Invoke(this, new EventArgs());
                return true;
            }
            catch (ChangeConflictException e)
            {

                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();

                //if (dataContext.ChangeConflicts.Count > 0 &&
                //    dataContext.ChangeConflicts[0].IsDeleted &&
                //    dataContext.ChangeConflicts[0].Object is Database.tsysClient)
                //{
                //    Database.tsysClient client = dataContext.ChangeConflicts[0].Object as Database.tsysClient;
                //    XtraMessageBox.Show(System.String.Format("Der Datensatz <b>\"{0}\"</b> existiert in der Datenbank nicht mehr.", client.Name), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, DevExpress.Utils.DefaultBoolean.True);
                //}
                //else if (dataContext.ChangeConflicts.Count > 0 &&
                //    dataContext.ChangeConflicts[0].MemberConflicts.Count > 0 &&
                //    dataContext.ChangeConflicts[0].MemberConflicts[0].IsModified &&
                //    dataContext.ChangeConflicts[0].Object is Database.tsysClient)
                //{
                //    Database.tsysClient client = dataContext.ChangeConflicts[0].Object as Database.tsysClient;
                //    XtraMessageBox.Show(
                //        System.String.Format(
                //            "Der Datensatz <b>\"{0}\"</b> wurde in der Datenbank geändert. Datenbankwert: {2}, Neuer Wert: {1}",
                //            dataContext.ChangeConflicts[0].MemberConflicts[0].Member.Name,
                //            dataContext.ChangeConflicts[0].MemberConflicts[0].CurrentValue,
                //            dataContext.ChangeConflicts[0].MemberConflicts[0].DatabaseValue),
                //        "Fehler",
                //        MessageBoxButtons.OK,
                //        MessageBoxIcon.Exclamation,
                //        DevExpress.Utils.DefaultBoolean.True);
                //}

                //dataContext.ChangeConflicts.ResolveAll(RefreshMode.KeepChanges);

                return false;
            }
            catch (SqlException exception)
            {
                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();

                if (exception.Number == 547) // Constraint error
                    XtraMessageBox.Show("Datensatz wird noch von anderer Stelle referenziert und kann daher nicht gelöscht werden.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                    XtraMessageBox.Show(exception.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            catch (Exception err)
            {
                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();

                XtraMessageBox.Show(err.ToString(), "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            finally
            {
                if (this.splashScreenManager.IsSplashFormVisible) this.splashScreenManager.CloseWaitForm();
            }

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
        #endregion

    }

    public class ModulData
    {
        public SqlConnection SqlConnection;
        public long? FKExternal;
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
