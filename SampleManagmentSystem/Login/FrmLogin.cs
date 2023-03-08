using DevExpress.XtraEditors;
using SampleManagmentSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            var yetkiliKullanicilar = dbMaskom.KULLANICILAR_USER
                .Where(k => (k.Numune_Duzeltme==true || k.Numune_Giris==true || k.Numune_Silme==true|| k.Numune_Sonuc_Giris==true))
                .ToList();
            var kullanicilar = (from yetkili in yetkiliKullanicilar
                                join user in dbMikro.KULLANICILAR on yetkili.Record_uid equals user.User_Guid
                                select new
                                {                                   
                                    user.User_no,
                                    user.User_name,
                                    user.User_LongName                                  
                                }).ToList();
            lookUpKullanici.Properties.ValueMember = "User_no";
            lookUpKullanici.Properties.DisplayMember = "User_name";
            lookUpKullanici.Properties.DataSource = kullanicilar;


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
            return;
        }
        Form1 fr;
        private void tbnGiris_Click(object sender, EventArgs e)
        {
            var seciliKullanici = dbMikro.KULLANICILAR.FirstOrDefault(x => x.User_name == lookUpKullanici.Text);
            var cdr = 0;
            if (seciliKullanici != null)
            {
                //var seciliKullanici = lookUpKullanici.GetSelectedDataRow();
                var seciliKullaniciPassword = txtSifre.EditValue == null ? "" : txtSifre.EditValue;
                
                // Mikro DLl'den kontrol et password doğru mu diye -->/
                 try
                {
                    cdr = new myeDB.myeMain().IsPassOK(seciliKullaniciPassword.ToString(), seciliKullanici.User_pw);
                }
                catch (COMException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
           
                // Mikro DLl'den kontrol et password doğru mu diye <--/

                if (cdr == -1)
                {
                    var kUser = dbMaskom.KULLANICILAR_USER;
                    ActiveUser.Instance.UserNo = Convert.ToInt32(lookUpKullanici.EditValue);
                    ActiveUser.Instance.UserName = lookUpKullanici.Text;
                    ActiveUser.Instance.Guid = seciliKullanici.User_Guid.ToString();
                    ActiveUser.Instance.YetkiDüzeltme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Duzeltme.Value;
                    ActiveUser.Instance.YetkiSilme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Silme.Value;
                    ActiveUser.Instance.YetkiEkleme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Giris.Value;
                    ActiveUser.Instance.YetkiSonucEkleme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Sonuc_Giris.Value;
                    ActiveUser.Instance.YetkiListeleme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Listeleme.Value;
                    ActiveUser.Instance.YetkiMusteriOnay = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Musteri_Onay_Girme.Value;

                    fr = new Form1();
                    fr.Show();
                    this.Hide();
                    //this.Close();
                    //this.Visible = true;
                    //var deger = MD5eDonustur(seciliKullanici.User_pw);
                }
                else
                {

                    MessageBox.Show("Hatalı parola...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı seçiniz...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            //var User= dbMikro.KULLANICILAR.FirstOrDefault(x => x.User_name == lookUpKullanici.Text);
            //if (User != null)
            //{
            //    var kUser = dbMaskom.KULLANICILAR_USER;
            //    ActiveUser.Instance.UserNo = Convert.ToInt32(lookUpKullanici.EditValue);
            //    ActiveUser.Instance.UserName = lookUpKullanici.Text;
            //    ActiveUser.Instance.Guid = User.User_Guid.ToString();
            //    ActiveUser.Instance.YetkiDüzeltme =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Duzeltme.Value;
            //    ActiveUser.Instance.YetkiSilme    =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Silme.Value;
            //    ActiveUser.Instance.YetkiEkleme   =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Giris.Value;
            //    ActiveUser.Instance.YetkiSonucEkleme   =   kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Sonuc_Giris.Value;
            //    ActiveUser.Instance.YetkiListeleme = kUser.FirstOrDefault(x => x.Record_uid.ToString() == ActiveUser.Instance.Guid).Numune_Listeleme.Value;

            //    fr = new Form1();
            //    fr.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    XtraMessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "Information");
            //}
        }

    }
}
