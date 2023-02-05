namespace SampleManagmentSystem.Forms
{
    partial class FrmNumuneSonucList
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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nUMUNEHAREKETLERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.nmnSonucGirilmemis = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.numuneSonuclari = new DevExpress.XtraGrid.GridControl();
            this.nUMUNEHAREKETLERIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnmnh_nmnkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmnh_sonucsirano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmnh_labonay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmnSonucGirilmemis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // nUMUNEHAREKETLERIBindingSource
            // 
            this.nUMUNEHAREKETLERIBindingSource.DataSource = typeof(SampleManagmentSystem.Entities.NUMUNE_HAREKETLERI);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.nmnSonucGirilmemis);
            this.groupControl2.Location = new System.Drawing.Point(656, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(550, 545);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sonuç Girilmemiş Numuneler";
            // 
            // nmnSonucGirilmemis
            // 
            this.nmnSonucGirilmemis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmnSonucGirilmemis.Location = new System.Drawing.Point(2, 28);
            this.nmnSonucGirilmemis.MainView = this.gridView2;
            this.nmnSonucGirilmemis.Name = "nmnSonucGirilmemis";
            this.nmnSonucGirilmemis.Size = new System.Drawing.Size(546, 515);
            this.nmnSonucGirilmemis.TabIndex = 0;
            this.nmnSonucGirilmemis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.nmnSonucGirilmemis;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numuneSonuclari);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(550, 545);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Numune Sonuçları";
            // 
            // numuneSonuclari
            // 
            this.numuneSonuclari.DataSource = this.nUMUNEHAREKETLERIBindingSource1;
            this.numuneSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numuneSonuclari.EmbeddedNavigator.BackgroundImage = global::SampleManagmentSystem.Properties.Resources._2824437_48lab_school_science_tube_icon1;
            this.numuneSonuclari.Location = new System.Drawing.Point(2, 28);
            this.numuneSonuclari.MainView = this.gridView1;
            this.numuneSonuclari.Name = "numuneSonuclari";
            this.numuneSonuclari.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.numuneSonuclari.Size = new System.Drawing.Size(546, 515);
            this.numuneSonuclari.TabIndex = 0;
            this.numuneSonuclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // nUMUNEHAREKETLERIBindingSource1
            // 
            this.nUMUNEHAREKETLERIBindingSource1.DataSource = typeof(SampleManagmentSystem.Entities.NUMUNE_HAREKETLERI);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnmnh_nmnkod,
            this.colnmnh_sonucsirano,
            this.colnmnh_labonay});
            this.gridView1.GridControl = this.numuneSonuclari;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle_1);
            // 
            // colnmnh_nmnkod
            // 
            this.colnmnh_nmnkod.FieldName = "nmnh_nmnkod";
            this.colnmnh_nmnkod.MinWidth = 25;
            this.colnmnh_nmnkod.Name = "colnmnh_nmnkod";
            this.colnmnh_nmnkod.Visible = true;
            this.colnmnh_nmnkod.VisibleIndex = 0;
            this.colnmnh_nmnkod.Width = 94;
            // 
            // colnmnh_sonucsirano
            // 
            this.colnmnh_sonucsirano.FieldName = "nmnh_sonucsirano";
            this.colnmnh_sonucsirano.MinWidth = 25;
            this.colnmnh_sonucsirano.Name = "colnmnh_sonucsirano";
            this.colnmnh_sonucsirano.Visible = true;
            this.colnmnh_sonucsirano.VisibleIndex = 1;
            this.colnmnh_sonucsirano.Width = 94;
            // 
            // colnmnh_labonay
            // 
            this.colnmnh_labonay.ColumnEdit = this.repositoryItemTextEdit1;
            this.colnmnh_labonay.FieldName = "nmnh_labonay";
            this.colnmnh_labonay.MinWidth = 25;
            this.colnmnh_labonay.Name = "colnmnh_labonay";
            this.colnmnh_labonay.Visible = true;
            this.colnmnh_labonay.VisibleIndex = 2;
            this.colnmnh_labonay.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // FrmNumuneSonucList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 544);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "FrmNumuneSonucList";
            this.Text = "Numune Sonuç Listesi";
            this.Load += new System.EventHandler(this.FrmNumuneSonucList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmnSonucGirilmemis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.BindingSource nUMUNEHAREKETLERIBindingSource;
        private DevExpress.XtraGrid.GridControl nmnSonucGirilmemis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl numuneSonuclari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource nUMUNEHAREKETLERIBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_nmnkod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_sonucsirano;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_labonay;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}