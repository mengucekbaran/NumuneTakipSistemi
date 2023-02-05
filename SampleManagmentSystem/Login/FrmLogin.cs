using DevExpress.XtraEditors;
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
            KULLANICILAR user = new KULLANICILAR();
            var isExist= dbMikro.KULLANICILAR.FirstOrDefault(x => x.User_name == lookUpKullanici.Text);
            if (isExist!=null)
            {
                
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
