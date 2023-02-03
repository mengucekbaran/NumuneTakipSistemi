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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tblNumunelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_create_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_lastup_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_unvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_cari_seviye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_aciliyet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_adaycari_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_adaycari_unvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_adaycari_konum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_sip_miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_deneme_miktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_hdf_fiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_fiyat_cins = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_mus_yetkili = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_urun_grubu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_rkpcari_unvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_rkpcari_urunkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_tur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_uretilecek_urun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_hammadde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_mfi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_oran = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_gida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_reach_rohs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_termin_tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_aciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnmn_urungrup_kod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNUMUNE_HAREKETLERI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumunelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblNumunelerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(379, 515);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colnmn_create_date,
            this.colnmn_lastup_date,
            this.colnmn_kod,
            this.colnmn_cari_kod,
            this.colnmn_cari_unvan,
            this.colnmn_tarih,
            this.colnmn_cari_seviye,
            this.colnmn_aciliyet,
            this.colnmn_adaycari_kod,
            this.colnmn_adaycari_unvan,
            this.colnmn_adaycari_konum,
            this.colnmn_sip_miktar,
            this.colnmn_deneme_miktar,
            this.colnmn_hdf_fiyat,
            this.colnmn_fiyat_cins,
            this.colnmn_mus_yetkili,
            this.colnmn_urun_grubu,
            this.colnmn_rkpcari_unvan,
            this.colnmn_rkpcari_urunkod,
            this.colnmn_tur,
            this.colnmn_uretilecek_urun,
            this.colnmn_hammadde,
            this.colnmn_mfi,
            this.colnmn_oran,
            this.colnmn_gida,
            this.colnmn_reach_rohs,
            this.colnmn_termin_tarih,
            this.colnmn_aciklama,
            this.colnmn_urungrup_kod,
            this.colNUMUNE_HAREKETLERI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 545);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Sonuç Girilen Numuneler";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Location = new System.Drawing.Point(400, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(383, 545);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Sonuç Girilmemiş Numuneler";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 28);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(379, 515);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl3);
            this.groupControl3.Location = new System.Drawing.Point(803, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(383, 545);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "groupControl3";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 28);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(379, 515);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            // 
            // tblNumunelerBindingSource
            // 
            this.tblNumunelerBindingSource.DataSource = typeof(SampleManagmentSystem.Entities.TblNumuneler);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 94;
            // 
            // colnmn_create_date
            // 
            this.colnmn_create_date.FieldName = "nmn_create_date";
            this.colnmn_create_date.MinWidth = 25;
            this.colnmn_create_date.Name = "colnmn_create_date";
            this.colnmn_create_date.Visible = true;
            this.colnmn_create_date.VisibleIndex = 1;
            this.colnmn_create_date.Width = 94;
            // 
            // colnmn_lastup_date
            // 
            this.colnmn_lastup_date.FieldName = "nmn_lastup_date";
            this.colnmn_lastup_date.MinWidth = 25;
            this.colnmn_lastup_date.Name = "colnmn_lastup_date";
            this.colnmn_lastup_date.Visible = true;
            this.colnmn_lastup_date.VisibleIndex = 2;
            this.colnmn_lastup_date.Width = 94;
            // 
            // colnmn_kod
            // 
            this.colnmn_kod.FieldName = "nmn_kod";
            this.colnmn_kod.MinWidth = 25;
            this.colnmn_kod.Name = "colnmn_kod";
            this.colnmn_kod.Visible = true;
            this.colnmn_kod.VisibleIndex = 3;
            this.colnmn_kod.Width = 94;
            // 
            // colnmn_cari_kod
            // 
            this.colnmn_cari_kod.FieldName = "nmn_cari_kod";
            this.colnmn_cari_kod.MinWidth = 25;
            this.colnmn_cari_kod.Name = "colnmn_cari_kod";
            this.colnmn_cari_kod.Visible = true;
            this.colnmn_cari_kod.VisibleIndex = 4;
            this.colnmn_cari_kod.Width = 94;
            // 
            // colnmn_cari_unvan
            // 
            this.colnmn_cari_unvan.FieldName = "nmn_cari_unvan";
            this.colnmn_cari_unvan.MinWidth = 25;
            this.colnmn_cari_unvan.Name = "colnmn_cari_unvan";
            this.colnmn_cari_unvan.Visible = true;
            this.colnmn_cari_unvan.VisibleIndex = 5;
            this.colnmn_cari_unvan.Width = 94;
            // 
            // colnmn_tarih
            // 
            this.colnmn_tarih.FieldName = "nmn_tarih";
            this.colnmn_tarih.MinWidth = 25;
            this.colnmn_tarih.Name = "colnmn_tarih";
            this.colnmn_tarih.Visible = true;
            this.colnmn_tarih.VisibleIndex = 6;
            this.colnmn_tarih.Width = 94;
            // 
            // colnmn_cari_seviye
            // 
            this.colnmn_cari_seviye.FieldName = "nmn_cari_seviye";
            this.colnmn_cari_seviye.MinWidth = 25;
            this.colnmn_cari_seviye.Name = "colnmn_cari_seviye";
            this.colnmn_cari_seviye.Visible = true;
            this.colnmn_cari_seviye.VisibleIndex = 7;
            this.colnmn_cari_seviye.Width = 94;
            // 
            // colnmn_aciliyet
            // 
            this.colnmn_aciliyet.FieldName = "nmn_aciliyet";
            this.colnmn_aciliyet.MinWidth = 25;
            this.colnmn_aciliyet.Name = "colnmn_aciliyet";
            this.colnmn_aciliyet.Visible = true;
            this.colnmn_aciliyet.VisibleIndex = 8;
            this.colnmn_aciliyet.Width = 94;
            // 
            // colnmn_adaycari_kod
            // 
            this.colnmn_adaycari_kod.FieldName = "nmn_adaycari_kod";
            this.colnmn_adaycari_kod.MinWidth = 25;
            this.colnmn_adaycari_kod.Name = "colnmn_adaycari_kod";
            this.colnmn_adaycari_kod.Visible = true;
            this.colnmn_adaycari_kod.VisibleIndex = 9;
            this.colnmn_adaycari_kod.Width = 94;
            // 
            // colnmn_adaycari_unvan
            // 
            this.colnmn_adaycari_unvan.FieldName = "nmn_adaycari_unvan";
            this.colnmn_adaycari_unvan.MinWidth = 25;
            this.colnmn_adaycari_unvan.Name = "colnmn_adaycari_unvan";
            this.colnmn_adaycari_unvan.Visible = true;
            this.colnmn_adaycari_unvan.VisibleIndex = 10;
            this.colnmn_adaycari_unvan.Width = 94;
            // 
            // colnmn_adaycari_konum
            // 
            this.colnmn_adaycari_konum.FieldName = "nmn_adaycari_konum";
            this.colnmn_adaycari_konum.MinWidth = 25;
            this.colnmn_adaycari_konum.Name = "colnmn_adaycari_konum";
            this.colnmn_adaycari_konum.Visible = true;
            this.colnmn_adaycari_konum.VisibleIndex = 11;
            this.colnmn_adaycari_konum.Width = 94;
            // 
            // colnmn_sip_miktar
            // 
            this.colnmn_sip_miktar.FieldName = "nmn_sip_miktar";
            this.colnmn_sip_miktar.MinWidth = 25;
            this.colnmn_sip_miktar.Name = "colnmn_sip_miktar";
            this.colnmn_sip_miktar.Visible = true;
            this.colnmn_sip_miktar.VisibleIndex = 12;
            this.colnmn_sip_miktar.Width = 94;
            // 
            // colnmn_deneme_miktar
            // 
            this.colnmn_deneme_miktar.FieldName = "nmn_deneme_miktar";
            this.colnmn_deneme_miktar.MinWidth = 25;
            this.colnmn_deneme_miktar.Name = "colnmn_deneme_miktar";
            this.colnmn_deneme_miktar.Visible = true;
            this.colnmn_deneme_miktar.VisibleIndex = 13;
            this.colnmn_deneme_miktar.Width = 94;
            // 
            // colnmn_hdf_fiyat
            // 
            this.colnmn_hdf_fiyat.FieldName = "nmn_hdf_fiyat";
            this.colnmn_hdf_fiyat.MinWidth = 25;
            this.colnmn_hdf_fiyat.Name = "colnmn_hdf_fiyat";
            this.colnmn_hdf_fiyat.Visible = true;
            this.colnmn_hdf_fiyat.VisibleIndex = 14;
            this.colnmn_hdf_fiyat.Width = 94;
            // 
            // colnmn_fiyat_cins
            // 
            this.colnmn_fiyat_cins.FieldName = "nmn_fiyat_cins";
            this.colnmn_fiyat_cins.MinWidth = 25;
            this.colnmn_fiyat_cins.Name = "colnmn_fiyat_cins";
            this.colnmn_fiyat_cins.Visible = true;
            this.colnmn_fiyat_cins.VisibleIndex = 15;
            this.colnmn_fiyat_cins.Width = 94;
            // 
            // colnmn_mus_yetkili
            // 
            this.colnmn_mus_yetkili.FieldName = "nmn_mus_yetkili";
            this.colnmn_mus_yetkili.MinWidth = 25;
            this.colnmn_mus_yetkili.Name = "colnmn_mus_yetkili";
            this.colnmn_mus_yetkili.Visible = true;
            this.colnmn_mus_yetkili.VisibleIndex = 16;
            this.colnmn_mus_yetkili.Width = 94;
            // 
            // colnmn_urun_grubu
            // 
            this.colnmn_urun_grubu.FieldName = "nmn_urun_grubu";
            this.colnmn_urun_grubu.MinWidth = 25;
            this.colnmn_urun_grubu.Name = "colnmn_urun_grubu";
            this.colnmn_urun_grubu.Visible = true;
            this.colnmn_urun_grubu.VisibleIndex = 17;
            this.colnmn_urun_grubu.Width = 94;
            // 
            // colnmn_rkpcari_unvan
            // 
            this.colnmn_rkpcari_unvan.FieldName = "nmn_rkpcari_unvan";
            this.colnmn_rkpcari_unvan.MinWidth = 25;
            this.colnmn_rkpcari_unvan.Name = "colnmn_rkpcari_unvan";
            this.colnmn_rkpcari_unvan.Visible = true;
            this.colnmn_rkpcari_unvan.VisibleIndex = 18;
            this.colnmn_rkpcari_unvan.Width = 94;
            // 
            // colnmn_rkpcari_urunkod
            // 
            this.colnmn_rkpcari_urunkod.FieldName = "nmn_rkpcari_urunkod";
            this.colnmn_rkpcari_urunkod.MinWidth = 25;
            this.colnmn_rkpcari_urunkod.Name = "colnmn_rkpcari_urunkod";
            this.colnmn_rkpcari_urunkod.Visible = true;
            this.colnmn_rkpcari_urunkod.VisibleIndex = 19;
            this.colnmn_rkpcari_urunkod.Width = 94;
            // 
            // colnmn_tur
            // 
            this.colnmn_tur.FieldName = "nmn_tur";
            this.colnmn_tur.MinWidth = 25;
            this.colnmn_tur.Name = "colnmn_tur";
            this.colnmn_tur.Visible = true;
            this.colnmn_tur.VisibleIndex = 20;
            this.colnmn_tur.Width = 94;
            // 
            // colnmn_uretilecek_urun
            // 
            this.colnmn_uretilecek_urun.FieldName = "nmn_uretilecek_urun";
            this.colnmn_uretilecek_urun.MinWidth = 25;
            this.colnmn_uretilecek_urun.Name = "colnmn_uretilecek_urun";
            this.colnmn_uretilecek_urun.Visible = true;
            this.colnmn_uretilecek_urun.VisibleIndex = 21;
            this.colnmn_uretilecek_urun.Width = 94;
            // 
            // colnmn_hammadde
            // 
            this.colnmn_hammadde.FieldName = "nmn_hammadde";
            this.colnmn_hammadde.MinWidth = 25;
            this.colnmn_hammadde.Name = "colnmn_hammadde";
            this.colnmn_hammadde.Visible = true;
            this.colnmn_hammadde.VisibleIndex = 22;
            this.colnmn_hammadde.Width = 94;
            // 
            // colnmn_mfi
            // 
            this.colnmn_mfi.FieldName = "nmn_mfi";
            this.colnmn_mfi.MinWidth = 25;
            this.colnmn_mfi.Name = "colnmn_mfi";
            this.colnmn_mfi.Visible = true;
            this.colnmn_mfi.VisibleIndex = 23;
            this.colnmn_mfi.Width = 94;
            // 
            // colnmn_oran
            // 
            this.colnmn_oran.FieldName = "nmn_oran";
            this.colnmn_oran.MinWidth = 25;
            this.colnmn_oran.Name = "colnmn_oran";
            this.colnmn_oran.Visible = true;
            this.colnmn_oran.VisibleIndex = 24;
            this.colnmn_oran.Width = 94;
            // 
            // colnmn_gida
            // 
            this.colnmn_gida.FieldName = "nmn_gida";
            this.colnmn_gida.MinWidth = 25;
            this.colnmn_gida.Name = "colnmn_gida";
            this.colnmn_gida.Visible = true;
            this.colnmn_gida.VisibleIndex = 25;
            this.colnmn_gida.Width = 94;
            // 
            // colnmn_reach_rohs
            // 
            this.colnmn_reach_rohs.FieldName = "nmn_reach_rohs";
            this.colnmn_reach_rohs.MinWidth = 25;
            this.colnmn_reach_rohs.Name = "colnmn_reach_rohs";
            this.colnmn_reach_rohs.Visible = true;
            this.colnmn_reach_rohs.VisibleIndex = 26;
            this.colnmn_reach_rohs.Width = 94;
            // 
            // colnmn_termin_tarih
            // 
            this.colnmn_termin_tarih.FieldName = "nmn_termin_tarih";
            this.colnmn_termin_tarih.MinWidth = 25;
            this.colnmn_termin_tarih.Name = "colnmn_termin_tarih";
            this.colnmn_termin_tarih.Visible = true;
            this.colnmn_termin_tarih.VisibleIndex = 27;
            this.colnmn_termin_tarih.Width = 94;
            // 
            // colnmn_aciklama
            // 
            this.colnmn_aciklama.FieldName = "nmn_aciklama";
            this.colnmn_aciklama.MinWidth = 25;
            this.colnmn_aciklama.Name = "colnmn_aciklama";
            this.colnmn_aciklama.Visible = true;
            this.colnmn_aciklama.VisibleIndex = 28;
            this.colnmn_aciklama.Width = 94;
            // 
            // colnmn_urungrup_kod
            // 
            this.colnmn_urungrup_kod.FieldName = "nmn_urungrup_kod";
            this.colnmn_urungrup_kod.MinWidth = 25;
            this.colnmn_urungrup_kod.Name = "colnmn_urungrup_kod";
            this.colnmn_urungrup_kod.Visible = true;
            this.colnmn_urungrup_kod.VisibleIndex = 29;
            this.colnmn_urungrup_kod.Width = 94;
            // 
            // colNUMUNE_HAREKETLERI
            // 
            this.colNUMUNE_HAREKETLERI.FieldName = "NUMUNE_HAREKETLERI";
            this.colNUMUNE_HAREKETLERI.MinWidth = 25;
            this.colNUMUNE_HAREKETLERI.Name = "colNUMUNE_HAREKETLERI";
            this.colNUMUNE_HAREKETLERI.Visible = true;
            this.colNUMUNE_HAREKETLERI.VisibleIndex = 30;
            this.colNUMUNE_HAREKETLERI.Width = 94;
            // 
            // FrmNumuneSonucList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 544);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmNumuneSonucList";
            this.Text = "Numune Sonuç Listesi";
            this.Load += new System.EventHandler(this.FrmNumuneSonucList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNumunelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource tblNumunelerBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_create_date;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_lastup_date;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_unvan;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_cari_seviye;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_aciliyet;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_adaycari_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_adaycari_unvan;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_adaycari_konum;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_sip_miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_deneme_miktar;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_hdf_fiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_fiyat_cins;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_mus_yetkili;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_urun_grubu;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_rkpcari_unvan;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_rkpcari_urunkod;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_tur;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_uretilecek_urun;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_hammadde;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_mfi;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_oran;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_gida;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_reach_rohs;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_termin_tarih;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_aciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colnmn_urungrup_kod;
        private DevExpress.XtraGrid.Columns.GridColumn colNUMUNE_HAREKETLERI;
    }
}