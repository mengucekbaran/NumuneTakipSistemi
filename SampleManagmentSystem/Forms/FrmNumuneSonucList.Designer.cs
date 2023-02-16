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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNumuneSonucList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.nUMUNEHAREKETLERIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nUMUNEHAREKETLERIBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nmnSonucGirilmemis = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnmn_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_ad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_unvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_seviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDelete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonUpdate = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.numuneSonuclari = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnmnh_nmnkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmnh_sonucsirano = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmnh_labonay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmnSonucGirilmemis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // nUMUNEHAREKETLERIBindingSource
            // 
            this.nUMUNEHAREKETLERIBindingSource.DataSource = typeof(SampleManagmentSystem.Entities.NUMUNE_HAREKETLERI);
            // 
            // nUMUNEHAREKETLERIBindingSource1
            // 
            this.nUMUNEHAREKETLERIBindingSource1.DataSource = typeof(SampleManagmentSystem.Entities.NUMUNE_HAREKETLERI);
            // 
            // nmnSonucGirilmemis
            // 
            this.nmnSonucGirilmemis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nmnSonucGirilmemis.Location = new System.Drawing.Point(2, 28);
            this.nmnSonucGirilmemis.MainView = this.gridView3;
            this.nmnSonucGirilmemis.Name = "nmnSonucGirilmemis";
            this.nmnSonucGirilmemis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonDelete,
            this.repositoryItemButtonUpdate});
            this.nmnSonucGirilmemis.Size = new System.Drawing.Size(696, 514);
            this.nmnSonucGirilmemis.TabIndex = 1;
            this.nmnSonucGirilmemis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnmn_kod,
            this.colnmn_ad,
            this.colnmn_cari_kod,
            this.colnmn_cari_unvan,
            this.colnmn_tarih,
            this.colnmn_cari_seviye});
            this.gridView3.GridControl = this.nmnSonucGirilmemis;
            this.gridView3.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsFind.AlwaysVisible = true;
            this.gridView3.OptionsView.ShowFooter = true;
            // 
            // colnmn_kod
            // 
            this.colnmn_kod.Caption = "NUMUNE KODU";
            this.colnmn_kod.FieldName = "nmn_kod";
            this.colnmn_kod.MinWidth = 25;
            this.colnmn_kod.Name = "colnmn_kod";
            this.colnmn_kod.OptionsColumn.AllowEdit = false;
            this.colnmn_kod.Visible = true;
            this.colnmn_kod.VisibleIndex = 0;
            this.colnmn_kod.Width = 88;
            // 
            // colnmn_ad
            // 
            this.colnmn_ad.Caption = "NUMUNE AD";
            this.colnmn_ad.FieldName = "nmn_ad";
            this.colnmn_ad.MinWidth = 25;
            this.colnmn_ad.Name = "colnmn_ad";
            this.colnmn_ad.Visible = true;
            this.colnmn_ad.VisibleIndex = 1;
            this.colnmn_ad.Width = 98;
            // 
            // colnmn_cari_kod
            // 
            this.colnmn_cari_kod.Caption = "CARİ KOD";
            this.colnmn_cari_kod.FieldName = "nmn_cari_kod";
            this.colnmn_cari_kod.MinWidth = 25;
            this.colnmn_cari_kod.Name = "colnmn_cari_kod";
            this.colnmn_cari_kod.OptionsColumn.AllowEdit = false;
            this.colnmn_cari_kod.Visible = true;
            this.colnmn_cari_kod.VisibleIndex = 2;
            this.colnmn_cari_kod.Width = 88;
            // 
            // colnmn_cari_unvan
            // 
            this.colnmn_cari_unvan.Caption = "CARİ UNVAN";
            this.colnmn_cari_unvan.FieldName = "nmn_cari_unvan";
            this.colnmn_cari_unvan.MinWidth = 25;
            this.colnmn_cari_unvan.Name = "colnmn_cari_unvan";
            this.colnmn_cari_unvan.OptionsColumn.AllowEdit = false;
            this.colnmn_cari_unvan.Visible = true;
            this.colnmn_cari_unvan.VisibleIndex = 3;
            this.colnmn_cari_unvan.Width = 101;
            // 
            // colnmn_tarih
            // 
            this.colnmn_tarih.Caption = "ALIŞ TARİHİ";
            this.colnmn_tarih.FieldName = "nmn_tarih";
            this.colnmn_tarih.MinWidth = 25;
            this.colnmn_tarih.Name = "colnmn_tarih";
            this.colnmn_tarih.OptionsColumn.AllowEdit = false;
            this.colnmn_tarih.Visible = true;
            this.colnmn_tarih.VisibleIndex = 4;
            this.colnmn_tarih.Width = 102;
            // 
            // colnmn_cari_seviye
            // 
            this.colnmn_cari_seviye.Caption = "CARİ SEVİYE";
            this.colnmn_cari_seviye.FieldName = "nmn_cari_seviye";
            this.colnmn_cari_seviye.MinWidth = 25;
            this.colnmn_cari_seviye.Name = "colnmn_cari_seviye";
            this.colnmn_cari_seviye.OptionsColumn.AllowEdit = false;
            this.colnmn_cari_seviye.Visible = true;
            this.colnmn_cari_seviye.VisibleIndex = 5;
            this.colnmn_cari_seviye.Width = 86;
            // 
            // repositoryItemButtonDelete
            // 
            this.repositoryItemButtonDelete.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemButtonDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Sil", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonDelete.Name = "repositoryItemButtonDelete";
            this.repositoryItemButtonDelete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // repositoryItemButtonUpdate
            // 
            this.repositoryItemButtonUpdate.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonUpdate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Güncelle", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonUpdate.Name = "repositoryItemButtonUpdate";
            this.repositoryItemButtonUpdate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.nmnSonucGirilmemis);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(700, 544);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sonuç Girilmemiş Numuneler";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.groupControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 544);
            this.panel1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numuneSonuclari);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(700, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(504, 544);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Numune Sonuçları";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
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
            this.numuneSonuclari.Size = new System.Drawing.Size(500, 514);
            this.numuneSonuclari.TabIndex = 0;
            this.numuneSonuclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnmnh_nmnkod,
            this.colnmnh_sonucsirano,
            this.colnmnh_labonay});
            this.gridView1.GridControl = this.numuneSonuclari;
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell_1);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            // 
            // colnmnh_nmnkod
            // 
            this.colnmnh_nmnkod.Caption = "NUMUNE KODU";
            this.colnmnh_nmnkod.FieldName = "nmnh_nmnkod";
            this.colnmnh_nmnkod.MinWidth = 25;
            this.colnmnh_nmnkod.Name = "colnmnh_nmnkod";
            this.colnmnh_nmnkod.Visible = true;
            this.colnmnh_nmnkod.VisibleIndex = 0;
            this.colnmnh_nmnkod.Width = 94;
            // 
            // colnmnh_sonucsirano
            // 
            this.colnmnh_sonucsirano.Caption = "SONUC SIRA NO";
            this.colnmnh_sonucsirano.FieldName = "nmnh_sonucsirano";
            this.colnmnh_sonucsirano.MinWidth = 25;
            this.colnmnh_sonucsirano.Name = "colnmnh_sonucsirano";
            this.colnmnh_sonucsirano.Visible = true;
            this.colnmnh_sonucsirano.VisibleIndex = 1;
            this.colnmnh_sonucsirano.Width = 94;
            // 
            // colnmnh_labonay
            // 
            this.colnmnh_labonay.Caption = "LAB ONAY";
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
            this.Controls.Add(this.panel1);
            this.Name = "FrmNumuneSonucList";
            this.Text = "Numune Sonuç Listesi";
            this.Load += new System.EventHandler(this.FrmNumuneSonucList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmnSonucGirilmemis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nUMUNEHAREKETLERIBindingSource;
        private System.Windows.Forms.BindingSource nUMUNEHAREKETLERIBindingSource1;
        private DevExpress.XtraGrid.GridControl nmnSonucGirilmemis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_ad;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_unvan;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_seviye;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonUpdate;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl numuneSonuclari;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_nmnkod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_sonucsirano;
        private DevExpress.XtraGrid.Columns.GridColumn colnmnh_labonay;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
    }
}