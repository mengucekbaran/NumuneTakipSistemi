namespace SampleManagmentSystem.Forms
{
    partial class FrmMusteriOnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriOnay));
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.txtMusAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.radioGroupMusOnay = new DevExpress.XtraEditors.RadioGroup();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtNmnAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNmnKod = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMusAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMusOnay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnKod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(12, 126);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(75, 16);
            this.labelControl18.TabIndex = 78;
            this.labelControl18.Text = "Müşteri Onay";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(14, 194);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(51, 16);
            this.labelControl23.TabIndex = 80;
            this.labelControl23.Text = "Açıklama";
            // 
            // txtMusAciklama
            // 
            this.txtMusAciklama.Location = new System.Drawing.Point(124, 193);
            this.txtMusAciklama.Name = "txtMusAciklama";
            this.txtMusAciklama.Size = new System.Drawing.Size(540, 164);
            this.txtMusAciklama.TabIndex = 81;
            // 
            // radioGroupMusOnay
            // 
            this.radioGroupMusOnay.EditValue = "Bekleniyor";
            this.radioGroupMusOnay.Location = new System.Drawing.Point(188, 111);
            this.radioGroupMusOnay.Name = "radioGroupMusOnay";
            this.radioGroupMusOnay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupMusOnay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioGroupMusOnay.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupMusOnay.Properties.Appearance.Options.UseFont = true;
            this.radioGroupMusOnay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupMusOnay.Properties.Columns = 2;
            this.radioGroupMusOnay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylanmadı", "Onaylanmadı", true, "Onaylanmadı", "Onaylanmadı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylandı", "Onaylandı", true, "Onaylandı", "Onaylandı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Bekleniyor", "Bekleniyor", true, "Bekleniyor", "Bekleniyor")});
            this.radioGroupMusOnay.Size = new System.Drawing.Size(291, 76);
            this.radioGroupMusOnay.TabIndex = 79;
            this.radioGroupMusOnay.Tag = "";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnVazgec.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnVazgec.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(381, 368);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(134, 42);
            this.btnVazgec.TabIndex = 83;
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
            this.BtnKaydet.Location = new System.Drawing.Point(530, 368);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(134, 42);
            this.BtnKaydet.TabIndex = 82;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtNmnAd
            // 
            this.txtNmnAd.Location = new System.Drawing.Point(188, 66);
            this.txtNmnAd.Name = "txtNmnAd";
            this.txtNmnAd.Size = new System.Drawing.Size(340, 22);
            this.txtNmnAd.TabIndex = 207;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(13, 69);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(66, 16);
            this.labelControl17.TabIndex = 208;
            this.labelControl17.Text = "Numune Ad";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 16);
            this.labelControl1.TabIndex = 205;
            this.labelControl1.Text = "Numune Kodu";
            // 
            // txtNmnKod
            // 
            this.txtNmnKod.Enabled = false;
            this.txtNmnKod.Location = new System.Drawing.Point(188, 20);
            this.txtNmnKod.Name = "txtNmnKod";
            this.txtNmnKod.Size = new System.Drawing.Size(340, 22);
            this.txtNmnKod.TabIndex = 206;
            // 
            // FrmMusteriOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 434);
            this.Controls.Add(this.txtNmnAd);
            this.Controls.Add(this.labelControl17);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNmnKod);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtMusAciklama);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.radioGroupMusOnay);
            this.Controls.Add(this.labelControl18);
            this.Name = "FrmMusteriOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Onay ";
            ((System.ComponentModel.ISupportInitialize)(this.txtMusAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupMusOnay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNmnKod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroupMusOnay;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.MemoEdit txtMusAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit txtNmnAd;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNmnKod;
    }
}