namespace Wookie.Ressource.Contact.Control
{
    partial class XtraUserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer3 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer4 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer widgetDockingContainer5 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetDockingContainer();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.widgetView1 = new DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView(this.components);
            this.document2 = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.ucContactDocument = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.ucHeaderDocument = new DevExpress.XtraBars.Docking2010.Views.Widget.Document(this.components);
            this.stackGroup1 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            this.stackGroup2 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            this.stackGroup3 = new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucContactDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucHeaderDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup3)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.widgetView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.widgetView1});
            // 
            // widgetView1
            // 
            this.widgetView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.document2,
            this.ucContactDocument,
            this.ucHeaderDocument});
            this.widgetView1.FreeLayoutProperties.FreeLayoutItems.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document2,
            this.ucContactDocument,
            this.ucHeaderDocument});
            this.widgetView1.LayoutMode = DevExpress.XtraBars.Docking2010.Views.Widget.LayoutMode.FreeLayout;
            widgetDockingContainer2.Element = this.ucHeaderDocument;
            widgetDockingContainer4.Element = this.ucContactDocument;
            widgetDockingContainer5.Element = this.document2;
            widgetDockingContainer3.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer4,
            widgetDockingContainer5});
            widgetDockingContainer3.Orientation = System.Windows.Forms.Orientation.Vertical;
            widgetDockingContainer3.Size.Width.UnitValue = 0.82098535491159086D;
            widgetDockingContainer1.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer2,
            widgetDockingContainer3});
            widgetDockingContainer1.Size.Height.UnitValue = 0.81027667984189722D;
            this.widgetView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            widgetDockingContainer1});
            this.widgetView1.RootContainer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.widgetView1.StackGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup[] {
            this.stackGroup1,
            this.stackGroup2,
            this.stackGroup3});
            // 
            // document2
            // 
            this.document2.Caption = "document2";
            this.document2.ControlName = "document2";
            this.document2.CustomHeaderButtons.AddRange(new DevExpress.XtraBars.Docking2010.IButton[] {
            new DevExpress.XtraBars.Docking.CustomHeaderButton(),
            new DevExpress.XtraBars.Docking.CustomHeaderButton()});
            this.document2.FreeLayoutHeight.UnitValue = 0.59396433470507548D;
            this.document2.FreeLayoutWidth.UnitValue = 0.70622568093385218D;
            this.document2.Height = 425;
            this.document2.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.document2.Properties.AllowResize = DevExpress.Utils.DefaultBoolean.False;
            // 
            // ucContactDocument
            // 
            this.ucContactDocument.Caption = "ucContact";
            this.ucContactDocument.ControlName = "ucContact";
            this.ucContactDocument.ControlTypeName = "Wookie.Ressource.Contact.Control.ucContact";
            this.ucContactDocument.FreeLayoutHeight.UnitValue = 1.1422924901185771D;
            this.ucContactDocument.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.False;
            this.ucContactDocument.Properties.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            // 
            // ucHeaderDocument
            // 
            this.ucHeaderDocument.Caption = "ucHeader";
            this.ucHeaderDocument.ControlName = "ucHeader";
            this.ucHeaderDocument.ControlTypeName = "Wookie.Ressource.Contact.Control.ucHeader";
            this.ucHeaderDocument.FreeLayoutHeight.UnitValue = 0.81027667984189722D;
            this.ucHeaderDocument.FreeLayoutWidth.UnitValue = 1.4727889641545571D;
            this.ucHeaderDocument.Properties.ShowBorders = DevExpress.Utils.DefaultBoolean.False;
            // 
            // stackGroup1
            // 
            this.stackGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.document2});
            this.stackGroup1.Length.UnitValue = 2D;
            // 
            // stackGroup2
            // 
            this.stackGroup2.Caption = "Erstes";
            this.stackGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Widget.Document[] {
            this.ucContactDocument,
            this.ucHeaderDocument});
            // 
            // XtraUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "XtraUserControl1";
            this.Size = new System.Drawing.Size(1015, 739);
            this.Load += new System.EventHandler(this.XtraUserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widgetView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucContactDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucHeaderDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackGroup3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.WidgetView widgetView1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document document2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document ucContactDocument;
        private DevExpress.XtraBars.Docking2010.Views.Widget.Document ucHeaderDocument;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup1;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup2;
        private DevExpress.XtraBars.Docking2010.Views.Widget.StackGroup stackGroup3;
    }
}
