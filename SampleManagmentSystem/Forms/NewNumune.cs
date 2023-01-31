using DevExpress.XtraEditors;
using DevExpress.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleManagmentSystem.Entities;
namespace SampleManagmentSystem.Forms
{
    public partial class NewNumune : Form
    {
        MikroDB_V16_MASKOM dbMaskom = new MikroDB_V16_MASKOM();
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        public NewNumune() //CREATE NUMUNE
        {
            InitializeComponent();
            SetTodayDate();
            SetZero();
        }
        public NewNumune(int id) //UPDATE NUMUNE
        {
            InitializeComponent();
            TblNumuneler nmn = db.TblNumuneler.Find(id);
            if (nmn.id == id)
            {
                //BUTONLARIN GÖRÜNÜRLÜĞÜNÜ AYARLAMA
                BtnKaydet.Visible = false;
                BtnGuncelle.Visible = true;
                //FORM ELEMANLARINI TIKLANAN KAYIDIN BİLGİLERİYLE DOLDURMA
                txtNmnKod.Enabled = false;
                txtNmnKod.EditValue = nmn.nmn_kod;
                lookUpCariAd.EditValue = nmn.nmn_cari_kod;
                lookUpCariSvy.EditValue = nmn.nmn_cari_seviye;
                lookUpAdayCari.EditValue = nmn.nmn_adaycari_kod;
                txtSipMktr.EditValue = nmn.nmn_sip_miktar;
                txtHedefFiyat.EditValue = nmn.nmn_hdf_fiyat;
                txtMusYetkili.EditValue = nmn.nmn_mus_yetkili;
                txtRkpUnvan.EditValue = nmn.nmn_rkpcari_unvan;
                lookUpNmnTur.EditValue = nmn.nmn_tur;
                txtKullanımOran.EditValue = nmn.nmn_oran;
                lookUpHammadde.EditValue = nmn.nmn_hammadde;
                txtMfi.EditValue = nmn.nmn_mfi;
                txtAlisTarih.EditValue = nmn.nmn_tarih;
                txtTerminTarih.EditValue = nmn.nmn_termin_tarih;
                radioGroupCariKnm.EditValue = nmn.nmn_adaycari_konum;
                txtDenemeMktr.EditValue = nmn.nmn_deneme_miktar;
                lookUpUrunGrubu.EditValue = nmn.nmn_urungrup_kod;
                lookUpDoviz.EditValue = nmn.nmn_fiyat_cins;
                txtRkpUrunKod.EditValue = nmn.nmn_rkpcari_urunkod;
                txtUretilecekUrun.EditValue = nmn.nmn_uretilecek_urun;
                lookUpAciliyet.EditValue = nmn.nmn_aciliyet;
                radioGroupGida.EditValue = nmn.nmn_gida;
                radioGroupReachRohs.EditValue = nmn.nmn_reach_rohs;
                txtAciklama.EditValue = nmn.nmn_aciklama;
            }
        }
        //VAZGEC 
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // KAYDET BUTONUNA TIKLANDIĞINDA YAPILACAKLAR

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblNumuneler nmn = new TblNumuneler();
            //Girilen numune kodu kontrolü
            bool isExist = db.TblNumuneler.Any(x => x.nmn_kod == txtNmnKod.Text);
            if (isExist)
            {
                XtraMessageBox.Show("Bu numune kodu sistemde bulunmaktadır.Lütfen farklı bir numune kodu giriniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNmnKod.Focus();
                return;
            }
            if (PostFormElementToDb(nmn))
            {
                nmn.nmn_create_date = DateTime.Now;
                db.TblNumuneler.Add(nmn);//tabloya ekler
                db.SaveChanges(); // degisiklikleri kaydeder
                XtraMessageBox.Show("Numune Başarılı Bir Şekilde Tanımlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else return;
            
        }
        // GÜNCELLE BUTONUNA TIKLANDIĞINDA YAPILACAKLAR
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //FirstOrDefault, belirli bir koşula uyan ilk öğeyi döndüren veya eğer bu tür bir öğe bulunamazsa varsayılan değer döndüren bir LINQ uzantı metodudur.
            TblNumuneler nmn = db.TblNumuneler.FirstOrDefault(x => x.nmn_kod == txtNmnKod.EditValue.ToString());
            if (nmn != null)
            {
                if (PostFormElementToDb(nmn))
                {
                    db.SaveChanges();
                    XtraMessageBox.Show("Numune Başarılı Bir Şekilde Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else return;
                
                
            }

        }

        //SAYFA YÜKLENDİĞİNDE YAPILACAKLAR
        private void NewNumune_Load(object sender, EventArgs e)
        {
            //TABLES
            //******************************************************************************************************
            // ACİLİYET 
            DataTable dtAciliyet = new DataTable();
            dtAciliyet.Columns.Add("Deger", typeof(string));
            dtAciliyet.Rows.Add("Normal");
            dtAciliyet.Rows.Add("Acil");
            dtAciliyet.Rows.Add("Çok Acil");
            lookUpShow(lookUpAciliyet, dtAciliyet);
            //DÖVİZ
            DataTable dtDoviz = new DataTable();
            dtDoviz.Columns.Add("Deger", typeof(string));
            dtDoviz.Rows.Add("TL");
            dtDoviz.Rows.Add("DOLAR");
            dtDoviz.Rows.Add("EURO");
            lookUpShow(lookUpDoviz, dtDoviz);
            //TÜR - NUMUNENİN GELME ŞEKLİ
            DataTable dtTur= new DataTable();
            dtTur.Columns.Add("Deger", typeof(string));
            dtTur.Rows.Add("Masterbatch");
            dtTur.Rows.Add("Uygulama Numunesi");
            dtTur.Rows.Add("Pantolon Veya Ral");
            dtTur.Rows.Add("Mail veya Telefon ile Fotoğraf");
            dtTur.Rows.Add("Müşteri Hammaddesi ile yapılacaktır");
            lookUpShow(lookUpNmnTur, dtTur);
            //HAMMADDE
            DataTable dtHammadde = new DataTable();
            dtHammadde.Columns.Add("Deger", typeof(string));
            dtHammadde.Rows.Add("LDPE");
            dtHammadde.Rows.Add("LLDPE");
            dtHammadde.Rows.Add("PP HOMOPOL");
            dtHammadde.Rows.Add("PP COPOL");
            dtHammadde.Rows.Add("HDPE");
            dtHammadde.Rows.Add("ABS");
            dtHammadde.Rows.Add("PC");
            dtHammadde.Rows.Add("PS");
            dtHammadde.Rows.Add("ANTİŞOK");
            dtHammadde.Rows.Add("PA6,PA66 VB.");
            dtHammadde.Rows.Add("PMMA veya SAN");
            dtHammadde.Rows.Add("DİĞER PET");
            lookUpShow(lookUpHammadde, dtHammadde);
            //CARİ SEVİYE
            DataTable dtCariSeviye = new DataTable();
            dtCariSeviye.Columns.Add("Deger", typeof(string));
            dtCariSeviye.Rows.Add("EKONOMİK");
            dtCariSeviye.Rows.Add("VİP");
            dtCariSeviye.Rows.Add("CIP");
            lookUpShow(lookUpCariSvy, dtCariSeviye);
            //CARİ HESAPLAR
            var cariHesaplar = (from x in dbMaskom.CARI_HESAPLAR
                                select new
                                {
                                    x.cari_kod,
                                    unvan = x.cari_unvan1 + x.cari_unvan2
                                }).ToList();
            lookUpCariAd.Properties.ValueMember = "cari_kod";
            lookUpCariAd.Properties.DisplayMember = "unvan";
            lookUpCariAd.Properties.DataSource = cariHesaplar;
            //ADAY CARİLER
            var adayCariler = (from x in dbMaskom.ADAY_CARI_HESAPLAR
                               select new
                               {
                                   x.adaycr_kod,
                                   unvan = x.adaycr_unvan1 + x.adaycr_unvan2
                               }).ToList();
            lookUpAdayCari.Properties.ValueMember = "adaycr_kod";
            lookUpAdayCari.Properties.DisplayMember = "unvan";
            lookUpAdayCari.Properties.DataSource = adayCariler;
            //URUN GRUBU
            var urunGrubu = (from x in dbMaskom.STOK_ALT_GRUPLARI
                             select new
                             {
                                 x.sta_kod,
                                 x.sta_isim
                             }).ToList();
            lookUpUrunGrubu.Properties.ValueMember = "sta_kod";
            lookUpUrunGrubu.Properties.DisplayMember = "sta_isim";
            lookUpUrunGrubu.Properties.DataSource = urunGrubu;
            //**************************************************************************************************
            
        }
        //FORMDAKİ DEĞERLERİ 
        public bool PostFormElementToDb(TblNumuneler nmn)
        {
            //KONTROLLER
            if (string.IsNullOrEmpty(txtNmnKod.Text))
            {
                XtraMessageBox.Show("Numune kodu boş bırakılamaz.", "Information");
                txtNmnKod.Focus();
                return false;
            }
            if (lookUpCariAd.EditValue==null)
            {
                lookUpCariAd.ShowPopup();
                return false;
            }
            if (txtAlisTarih.DateTime == Convert.ToDateTime("1-01-0001"))
            {
                XtraMessageBox.Show("Geçerli bir tarih giriniz.", "Information");
                txtAlisTarih.Focus();
                return false;
            }
            if (txtTerminTarih.DateTime == Convert.ToDateTime("1-01-0001"))
            {
                XtraMessageBox.Show("Geçerli bir tarih giriniz.", "Information");
                txtTerminTarih.Focus();
                return false;
            }
            if (lookUpAdayCari.EditValue == null)
            {
                lookUpAdayCari.ShowPopup();
                return false;
            }
            if (lookUpUrunGrubu.EditValue == null)
            {
                lookUpUrunGrubu.ShowPopup();
                return false;
            }
            if (Convert.ToDecimal(txtSipMktr.EditValue) < 0)
            {
                XtraMessageBox.Show("Sipariş miktarı negatif olamaz.", "Information");
                txtSipMktr.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtDenemeMktr.EditValue) < 0)
            {
                XtraMessageBox.Show("Deneme miktarı negatif olamaz.", "Information");
                txtDenemeMktr.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtHedefFiyat.EditValue) < 0)
            {
                XtraMessageBox.Show("Hedef fiyat negatif olamaz.", "Information");
                txtHedefFiyat.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtKullanımOran.EditValue) < 0)
            {
                XtraMessageBox.Show("Kullanım oranı negatif olamaz.", "Information");
                txtKullanımOran.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtMfi.EditValue) < 0)
            {
                XtraMessageBox.Show("MFI negatif olamaz.", "Information");
                txtMfi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAciklama.Text))
            {
                XtraMessageBox.Show("Açıklama boş bırakılamaz.", "Information");
                txtNmnKod.Focus();
                return false;
            }
            nmn.nmn_lastup_date = DateTime.Now;
            nmn.nmn_aciklama = txtAciklama.Text;
            nmn.nmn_aciliyet = lookUpAciliyet.Text;
            nmn.nmn_adaycari_kod = lookUpAdayCari.EditValue.ToString(); ;
            nmn.nmn_adaycari_unvan = lookUpAdayCari.Text;
            nmn.nmn_adaycari_konum = radioGroupCariKnm.Properties.Items[radioGroupCariKnm.SelectedIndex].Description; ;
            nmn.nmn_cari_kod = lookUpCariAd.EditValue.ToString();
            nmn.nmn_cari_unvan = lookUpCariAd.Text;
            nmn.nmn_cari_seviye = lookUpCariSvy.Text;
            nmn.nmn_deneme_miktar = float.Parse(txtDenemeMktr.Text);
            nmn.nmn_fiyat_cins = lookUpDoviz.Text;
            nmn.nmn_gida = radioGroupGida.Properties.Items[radioGroupGida.SelectedIndex].Description;
            // seçili olan checkboxların değerlerini bir listeye alır
            //CheckEdit[] checkEdits = new CheckEdit[] { chEdit1, chEdit2, chEdit3, chEdit4, chEdit5,
            //                                           chEdit6, chEdit7, chEdit8,chEdit9,chEdit10,chEdit11,chEdit12 };
            //List<string> checkedValues = new List<string>();
            //string temp="";
            //for (int i = 0; i < checkEdits.Length; i++)
            //{
            //    if (checkEdits[i].Checked)
            //        checkedValues.Add(checkEdits[i].Text);
            //}
            //foreach(string item in checkedValues)
            //{
            //    temp += item + ",";
            //}
            //nmn.nmn_hammadde = temp;
            nmn.nmn_hammadde = lookUpHammadde.Text;
            nmn.nmn_hdf_fiyat = float.Parse(txtHedefFiyat.Text);
            nmn.nmn_urun_grubu = lookUpUrunGrubu.Text;
            nmn.nmn_urungrup_kod = lookUpUrunGrubu.EditValue.ToString();
            nmn.nmn_kod = txtNmnKod.Text;
            nmn.nmn_mfi = float.Parse(txtMfi.Text);
            //nmn.nmn_mfi = txtEdit1 + ',' + txtEdit2 + ',' + txtEdit3 + ',' + txtEdit4 + ',' + txtEdit5
            //                + ',' + txtEdit6 + ',' + txtEdit7 + ',' + txtEdit8 + ',' + txtEdit9;
            nmn.nmn_mus_yetkili = txtMusYetkili.Text;
            nmn.nmn_oran = float.Parse(txtKullanımOran.Text);
            nmn.nmn_reach_rohs = radioGroupReachRohs.Properties.Items[radioGroupReachRohs.SelectedIndex].Description;
            nmn.nmn_rkpcari_unvan = txtRkpUnvan.Text;
            nmn.nmn_rkpcari_urunkod = txtRkpUrunKod.Text;
            nmn.nmn_sip_miktar = float.Parse(txtSipMktr.Text);

            //MessageBox.Show("Lütfen sayısal bir değer giriniz.");
            nmn.nmn_tarih = txtAlisTarih.DateTime;
            nmn.nmn_termin_tarih = txtTerminTarih.DateTime;
            nmn.nmn_tur = lookUpNmnTur.Text;
            nmn.nmn_uretilecek_urun = txtUretilecekUrun.Text;
            return true;
        }
        // parametre verilen lookUpEdite ,parametre verilen tabloyu atar ve görüntülenmesini sağlar
        public void lookUpShow(LookUpEdit lookUpEdit,DataTable dt)
        {
            //lookUp da görüntülemek için ValueMember ve DisplayMember değerleri atanır
            lookUpEdit.Properties.ValueMember = "Deger";
            lookUpEdit.Properties.DisplayMember = "Deger";
            lookUpEdit.Properties.DataSource = dt;   //DataSource e veri kaynağı atanır
        }
        public void SetTodayDate()
        {
            txtAlisTarih.EditValue = DateTime.Today;
            txtTerminTarih.EditValue = DateTime.Today;
        }
        public void SetZero()
        {
            txtSipMktr.EditValue = 0.00;
            txtHedefFiyat.EditValue = 0.00;
            txtKullanımOran.EditValue = 0.00;
            txtMfi.EditValue = 0.00;
            txtDenemeMktr.EditValue = 0.00;
        }

    }
}
