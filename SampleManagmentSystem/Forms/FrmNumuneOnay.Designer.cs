namespace SampleManagmentSystem.Forms
{
    partial class FrmNumuneOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNumuneOnay));
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.txtNmnAd = new DevExpress.XtraEditors.TextEdit();
            this.txtNmnKod = new DevExpress.XtraEditors.TextEdit();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtNmnOnayAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.radioGroupNmnOnay = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLabNmnSonuc = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnOnayAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupNmnOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabNmnSonuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(14, 88);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(66, 16);
            this.labelControl17.TabIndex = 218;
            this.labelControl17.Text = "Numune Ad";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 16);
            this.labelControl1.TabIndex = 215;
            this.labelControl1.Text = "Numune Kodu";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(14, 175);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(51, 16);
            this.labelControl23.TabIndex = 211;
            this.labelControl23.Text = "Açıklama";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(12, 129);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(126, 16);
            this.labelControl18.TabIndex = 209;
            this.labelControl18.Text = "Müşteri Numune Onay";
            // 
            // txtNmnAd
            // 
            this.txtNmnAd.Location = new System.Drawing.Point(189, 85);
            this.txtNmnAd.Name = "txtNmnAd";
            this.txtNmnAd.Size = new System.Drawing.Size(340, 22);
            this.txtNmnAd.TabIndex = 217;
            // 
            // txtNmnKod
            // 
            this.txtNmnKod.Enabled = false;
            this.txtNmnKod.Location = new System.Drawing.Point(188, 23);
            this.txtNmnKod.Name = "txtNmnKod";
            this.txtNmnKod.Size = new System.Drawing.Size(340, 22);
            this.txtNmnKod.TabIndex = 216;
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnVazgec.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnVazgec.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(381, 349);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(134, 42);
            this.btnVazgec.TabIndex = 214;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(530, 349);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(134, 42);
            this.BtnKaydet.TabIndex = 213;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtNmnOnayAciklama
            // 
            this.txtNmnOnayAciklama.Location = new System.Drawing.Point(124, 174);
            this.txtNmnOnayAciklama.Name = "txtNmnOnayAciklama";
            this.txtNmnOnayAciklama.Size = new System.Drawing.Size(540, 164);
            this.txtNmnOnayAciklama.TabIndex = 212;
            // 
            // radioGroupNmnOnay
            // 
            this.radioGroupNmnOnay.Location = new System.Drawing.Point(188, 97);
            this.radioGroupNmnOnay.Name = "radioGroupNmnOnay";
            this.radioGroupNmnOnay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupNmnOnay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioGroupNmnOnay.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupNmnOnay.Properties.Appearance.Options.UseFont = true;
            this.radioGroupNmnOnay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupNmnOnay.Properties.Columns = 2;
            this.radioGroupNmnOnay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylanmadı", "Onaylanmadı", true, "Onaylanmadı", "Onaylanmadı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylandı", "Onaylandı", true, "Onaylandı", "Onaylandı")});
            this.radioGroupNmnOnay.Size = new System.Drawing.Size(291, 76);
            this.radioGroupNmnOnay.TabIndex = 210;
            this.radioGroupNmnOnay.Tag = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 16);
            this.labelControl2.TabIndex = 219;
            this.labelControl2.Text = "Lab Numune Sonuç";
            // 
            // txtLabNmnSonuc
            // 
            this.txtLabNmnSonuc.Enabled = false;
            this.txtLabNmnSonuc.Location = new System.Drawing.Point(188, 54);
            this.txtLabNmnSonuc.Name = "txtLabNmnSonuc";
            this.txtLabNmnSonuc.Size = new System.Drawing.Size(340, 22);
            this.txtLabNmnSonuc.TabIndex = 220;
            // 
            // FrmNumuneOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 415);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLabNmnSonuc);
            this.Controls.Add(this.txtNmnAd);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNmnKod);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtNmnOnayAciklama);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.radioGroupNmnOnay);
            this.Controls.Add(this.labelControl18);
            this.Name = "FrmNumuneOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numune Onay";
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnOnayAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupNmnOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLabNmnSonuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNmnAd;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNmnKod;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.MemoEdit txtNmnOnayAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.RadioGroup radioGroupNmnOnay;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtLabNmnSonuc;
    }
}