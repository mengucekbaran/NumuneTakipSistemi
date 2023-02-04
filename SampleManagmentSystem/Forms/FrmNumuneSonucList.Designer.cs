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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.nUMUNEHAREKETLERIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmnSonucGirilmemis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numuneSonuclari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.numuneSonuclari.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numuneSonuclari.Location = new System.Drawing.Point(2, 28);
            this.numuneSonuclari.MainView = this.gridView1;
            this.numuneSonuclari.Name = "numuneSonuclari";
            this.numuneSonuclari.Size = new System.Drawing.Size(546, 515);
            this.numuneSonuclari.TabIndex = 0;
            this.numuneSonuclari.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.numuneSonuclari;
            this.gridView1.Name = "gridView1";
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
    }
}