namespace Wookie.Tools.Controls
{
    partial class ucConflicts
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
            this.bindingSourceConflicts = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefreshMode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConflicts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceConflicts
            // 
            this.bindingSourceConflicts.DataSource = typeof(Wookie.Tools.Controls.Conflict);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSourceConflicts;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(563, 278);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMessage,
            this.colRefreshMode});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMessage
            // 
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 0;
            this.colMessage.Width = 313;
            // 
            // colRefreshMode
            // 
            this.colRefreshMode.FieldName = "RefreshMode";
            this.colRefreshMode.Name = "colRefreshMode";
            this.colRefreshMode.Visible = true;
            this.colRefreshMode.VisibleIndex = 1;
            this.colRefreshMode.Width = 223;
            // 
            // ucConflicts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "ucConflicts";
            this.Size = new System.Drawing.Size(563, 278);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceConflicts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSourceConflicts;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colRefreshMode;
    }
}
