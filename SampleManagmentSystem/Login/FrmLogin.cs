﻿using DevExpress.XtraEditors;
using SampleManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SampleManagmentSystem.Forms
{

    public partial class FrmLogin : Form
    {
        MikroDB_V16Entities dbMikro = new MikroDB_V16Entities();
        MikroDB_V16_MASKOM dbMaskom = new MikroDB_V16_MASKOM();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var kullanicilar = (from x in dbMikro.KULLANICILAR
                                select new
                                {
                                    x.User_no,
                                    x.User_name,
                                    x.User_LongName
                                  
                                }).ToList();
            lookUpKullanici.Properties.ValueMember = "User_no";
            lookUpKullanici.Properties.DisplayMember = "User_name";
            lookUpKullanici.Properties.DataSource = kullanicilar;
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form1 fr;
        private void tbnGiris_Click(object sender, EventArgs e)
        {
            var User= dbMikro.KULLANICILAR.FirstOrDefault(x => x.User_name == lookUpKullanici.Text);
            if (User != null)
            {
                var kUser = dbMaskom.KULLANICILAR_USER;
                ActiveUser.Instance.UserName = lookUpKullanici.Text;
                ActiveUser.Instance.Guid = User.User_Guid.ToString();
                ActiveUser.Instance.YetkiDüzeltme =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Duzeltme.Value;
                ActiveUser.Instance.YetkiSilme    =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Silme.Value;
                ActiveUser.Instance.YetkiEkleme   =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Giris.Value;
                ActiveUser.Instance.YetkiSonucEkleme   =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Sonuc_Giris.Value;
                fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Information");
            }
        }
    }
}