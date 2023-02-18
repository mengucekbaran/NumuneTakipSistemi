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
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.radioGroupLabOnay = new DevExpress.XtraEditors.RadioGroup();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupLabOnay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(11, 38);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(53, 16);
            this.labelControl18.TabIndex = 78;
            this.labelControl18.Text = "Lab Onay";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(13, 90);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(51, 16);
            this.labelControl23.TabIndex = 80;
            this.labelControl23.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(108, 88);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(648, 164);
            this.txtAciklama.TabIndex = 81;
            this.txtAciklama.EditValueChanged += new System.EventHandler(this.txtAciklama_EditValueChanged);
            // 
            // radioGroupLabOnay
            // 
            this.radioGroupLabOnay.EditValue = "Onaylanmadı";
            this.radioGroupLabOnay.Location = new System.Drawing.Point(157, 6);
            this.radioGroupLabOnay.Name = "radioGroupLabOnay";
            this.radioGroupLabOnay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroupLabOnay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.radioGroupLabOnay.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroupLabOnay.Properties.Appearance.Options.UseFont = true;
            this.radioGroupLabOnay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroupLabOnay.Properties.Columns = 2;
            this.radioGroupLabOnay.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylanmadı", "Onaylanmadı", true, "Onaylanmadı", "Onaylanmadı"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Onaylandı", "Onaylandı", true, "Onaylandı", "Onaylandı")});
            this.radioGroupLabOnay.Size = new System.Drawing.Size(291, 76);
            this.radioGroupLabOnay.TabIndex = 79;
            this.radioGroupLabOnay.Tag = "";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Appearance.BackColor = System.Drawing.Color.DarkRed;
            this.btnVazgec.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnVazgec.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnVazgec.Appearance.Options.UseBackColor = true;
            this.btnVazgec.Appearance.Options.UseFont = true;
            this.btnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.ImageOptions.Image")));
            this.btnVazgec.Location = new System.Drawing.Point(473, 278);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(134, 42);
            this.btnVazgec.TabIndex = 83;
            this.btnVazgec.Text = "Vazgeç";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(622, 278);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(134, 42);
            this.BtnKaydet.TabIndex = 82;
            this.BtnKaydet.Text = "Kaydet";
            // 
            // FrmMusteriOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 343);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.radioGroupLabOnay);
            this.Controls.Add(this.labelControl18);
            this.Name = "FrmMusteriOnay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Onay ";
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupLabOnay.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroupLabOnay;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
    }
}