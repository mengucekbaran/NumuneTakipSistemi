namespace SampleManagmentSystem.Forms
{
    partial class FrmNumuneSonucList2
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
            this.components = new System.ComponentModel.Container();
            this.numuneSonuclari = new DevExpress.XtraGrid.GridControl();
            this.nUMUNEHAREKETLERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnmnh_nmnkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmnh_sonucsirano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteri_fiyatonay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_nmnonay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // numuneSonuclari
            // 
            this.numuneSonuclari.DataSource = this.nUMUNEHAREKETLERIBindingSource;
            this.numuneSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numuneSonuclari.EmbeddedNavigator.BackgroundImage = global::SampleManagmentSystem.Properties.Resources._2824437_48lab_school_science_tube_icon1;
            this.numuneSonuclari.Location = new System.Drawing.Point(0, 0);
            this.numuneSonuclari.MainView = this.gridView1;
            this.numuneSonuclari.Name = "numuneSonuclari";
            this.numuneSonuclari.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.numuneSonuclari.Size = new System.Drawing.Size(800, 450);
            this.numuneSonuclari.TabIndex = 1;
            this.numuneSonuclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnmnh_nmnkod,
            this.colnmnh_sonucsirano,
            this.musteri_fiyatonay,
            this.colnmn_nmnonay});
            this.gridView1.GridControl = this.numuneSonuclari;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colnmnh_nmnkod
            // 
            this.colnmnh_nmnkod.Caption = "NUMUNE KODU";
            this.colnmnh_nmnkod.FieldName = "nmnh_nmnkod";
            this.colnmnh_nmnkod.MinWidth = 25;
            this.colnmnh_nmnkod.Name = "colnmnh_nmnkod";
            this.colnmnh_nmnkod.OptionsColumn.AllowEdit = false;
            this.colnmnh_nmnkod.OptionsColumn.ReadOnly = true;
            this.colnmnh_nmnkod.Visible = true;
            this.colnmnh_nmnkod.VisibleIndex = 0;
            this.colnmnh_nmnkod.Width = 94;
            // 
            // colnmnh_sonucsirano
            // 
            this.colnmnh_sonucsirano.Caption = "LAB NUMUNE SONUÇ";
            this.colnmnh_sonucsirano.FieldName = "nmnh_sonucsirano";
            this.colnmnh_sonucsirano.MinWidth = 25;
            this.colnmnh_sonucsirano.Name = "colnmnh_sonucsirano";
            this.colnmnh_sonucsirano.OptionsColumn.AllowEdit = false;
            this.colnmnh_sonucsirano.OptionsColumn.ReadOnly = true;
            this.colnmnh_sonucsirano.Visible = true;
            this.colnmnh_sonucsirano.VisibleIndex = 1;
            this.colnmnh_sonucsirano.Width = 94;
            // 
            // musteri_fiyatonay
            // 
            this.musteri_fiyatonay.Caption = "MÜŞTERİ FİYAT ONAY";
            this.musteri_fiyatonay.FieldName = "musteri_fiyatonay";
            this.musteri_fiyatonay.MinWidth = 25;
            this.musteri_fiyatonay.Name = "musteri_fiyatonay";
            this.musteri_fiyatonay.OptionsColumn.AllowEdit = false;
            this.musteri_fiyatonay.OptionsColumn.ReadOnly = true;
            this.musteri_fiyatonay.Visible = true;
            this.musteri_fiyatonay.VisibleIndex = 2;
            this.musteri_fiyatonay.Width = 94;
            // 
            // colnmn_nmnonay
            // 
            this.colnmn_nmnonay.Caption = "MÜŞTERİ NUMUNE ONAY";
            this.colnmn_nmnonay.FieldName = "nmn_nmnonay";
            this.colnmn_nmnonay.MinWidth = 25;
            this.colnmn_nmnonay.Name = "colnmn_nmnonay";
            this.colnmn_nmnonay.OptionsColumn.AllowEdit = false;
            this.colnmn_nmnonay.OptionsColumn.ReadOnly = true;
            this.colnmn_nmnonay.Visible = true;
            this.colnmn_nmnonay.VisibleIndex = 3;
            this.colnmn_nmnonay.Width = 94;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // FrmNumuneSonucList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numuneSonuclari);
            this.Name = "FrmNumuneSonucList2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numune Sonuçları ";
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl numuneSonuclari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource nUMUNEHAREKETLERIBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_nmnkod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_sonucsirano;
        private DevExpress.XtraGrid.Columns.GridColumn musteri_fiyatonay;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_nmnonay;
    }
}