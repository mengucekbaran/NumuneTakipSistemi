namespace SampleManagmentSystem.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtKullanici = new DevExpress.XtraEditors.TextEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.tbnGiris = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControl1 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.hyperlinkLabelControl2 = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelControl4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelControl3);
            this.panel1.Controls.Add(this.pictureEdit1);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 530);
            this.panel1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(87, 273);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Giriş Paneli";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(16, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(269, 198);
            this.pictureEdit1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(4, 237);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(282, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Numune Takip ve Yönetim Sistemi ";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(297, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 530);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.pictureEdit2);
            this.panel3.Controls.Add(this.txtKullanici);
            this.panel3.Location = new System.Drawing.Point(292, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 50);
            this.panel3.TabIndex = 1;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtKullanici.EditValue = "";
            this.txtKullanici.Location = new System.Drawing.Point(70, 10);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Properties.Appearance.Font = new System.Drawing.Font("Dutch801 Rm BT", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtKullanici.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtKullanici.Properties.Appearance.Options.UseFont = true;
            this.txtKullanici.Properties.Appearance.Options.UseForeColor = true;
            this.txtKullanici.Size = new System.Drawing.Size(380, 28);
            this.txtKullanici.TabIndex = 0;
            this.txtKullanici.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.txtKullanici.Click += new System.EventHandler(this.textEdit1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.pictureEdit3);
            this.panel4.Controls.Add(this.txtSifre);
            this.panel4.Location = new System.Drawing.Point(294, 285);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 50);
            this.panel4.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSifre.EditValue = "";
            this.txtSifre.Location = new System.Drawing.Point(70, 10);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = new System.Drawing.Font("Dutch801 Rm BT", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtSifre.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.Appearance.Options.UseForeColor = true;
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(380, 28);
            this.txtSifre.TabIndex = 0;
            this.txtSifre.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            this.txtSifre.Click += new System.EventHandler(this.textEdit2_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(22, 8);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(30, 30);
            this.pictureEdit2.TabIndex = 7;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(22, 7);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(28, 28);
            this.pictureEdit3.TabIndex = 7;
            // 
            // tbnGiris
            // 
            this.tbnGiris.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnGiris.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnGiris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbnGiris.Location = new System.Drawing.Point(364, 351);
            this.tbnGiris.Name = "tbnGiris";
            this.tbnGiris.Size = new System.Drawing.Size(277, 40);
            this.tbnGiris.TabIndex = 3;
            this.tbnGiris.Text = "Giriş Yap";
            this.tbnGiris.UseVisualStyleBackColor = false;
            this.tbnGiris.Click += new System.EventHandler(this.tbnGiris_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(322, 173);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(347, 23);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Kullanıcı Adı ve Şifre İle Giriş Yapın ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl4.Location = new System.Drawing.Point(52, 511);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(167, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "V 1.0 Tüm Hakları Saklıdır";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // hyperlinkLabelControl1
            // 
            this.hyperlinkLabelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.hyperlinkLabelControl1.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkLabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.hyperlinkLabelControl1.Appearance.Options.UseBackColor = true;
            this.hyperlinkLabelControl1.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl1.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl1.Location = new System.Drawing.Point(253, 3);
            this.hyperlinkLabelControl1.Name = "hyperlinkLabelControl1";
            this.hyperlinkLabelControl1.Size = new System.Drawing.Size(131, 18);
            this.hyperlinkLabelControl1.TabIndex = 7;
            this.hyperlinkLabelControl1.Text = "Uygulamayı Kapat";
            this.hyperlinkLabelControl1.Click += new System.EventHandler(this.hyperlinkLabelControl1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.hyperlinkLabelControl2);
            this.panel5.Controls.Add(this.hyperlinkLabelControl1);
            this.panel5.Location = new System.Drawing.Point(294, 502);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 27);
            this.panel5.TabIndex = 8;
            // 
            // hyperlinkLabelControl2
            // 
            this.hyperlinkLabelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.hyperlinkLabelControl2.Appearance.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkLabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.hyperlinkLabelControl2.Appearance.Options.UseBackColor = true;
            this.hyperlinkLabelControl2.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControl2.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControl2.Location = new System.Drawing.Point(83, 3);
            this.hyperlinkLabelControl2.Name = "hyperlinkLabelControl2";
            this.hyperlinkLabelControl2.Size = new System.Drawing.Size(120, 18);
            this.hyperlinkLabelControl2.TabIndex = 8;
            this.hyperlinkLabelControl2.Text = "Şifremi Unuttum";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tbnGiris);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanici.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtKullanici;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Button tbnGiris;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControl2;
    }
}