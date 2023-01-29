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
        public NewNumune()
        {
            InitializeComponent();
        }
        // CHECKBOX İSLEMLERİ
        //*************************************************************************************
        //private void chEdit1_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit1.Enabled = chEdit1.Checked;
        //    if (!chEdit1.Checked)
        //        txtEdit1.Text = string.Empty;
        //}

        //private void chEdit2_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit2.Enabled = chEdit2.Checked;
        //    if (!chEdit2.Checked)
        //        txtEdit2.Text = string.Empty;
        //}

        //private void chEdit3_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit3.Enabled = chEdit3.Checked;
        //    if (!chEdit3.Checked)
        //        txtEdit3.Text = string.Empty;
        //}

        //private void chEdit4_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit4.Enabled = chEdit4.Checked;
        //    if (!chEdit4.Checked)
        //        txtEdit4.Text = string.Empty;
        //}

        //private void chEdit5_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit5.Enabled = chEdit5.Checked;
        //    if (!chEdit5.Checked)
        //        txtEdit5.Text = string.Empty;
        //}

        //private void chEdit6_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit6.Enabled = chEdit6.Checked;
        //    if (!chEdit6.Checked)
        //        txtEdit6.Text = string.Empty;
        //}

        //private void chEdit7_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit7.Enabled = chEdit7.Checked;
        //    if (!chEdit7.Checked)
        //        txtEdit7.Text = string.Empty;
        //}

        //private void chEdit8_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit8.Enabled = chEdit8.Checked;
        //    if (!chEdit8.Checked)
        //        txtEdit8.Text = string.Empty;
        //}

        //private void chEdit9_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit9.Enabled = chEdit9.Checked;
        //    if (!chEdit9.Checked)
        //        txtEdit9.Text = string.Empty;
        //}
        //private void chEdit10_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit10.Enabled = chEdit10.Checked;
        //    if (!chEdit10.Checked)
        //        txtEdit10.Text = string.Empty;
        //}
        //private void chEdit11_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit11.Enabled = chEdit11.Checked;
        //    if (!chEdit11.Checked)
        //        txtEdit11.Text = string.Empty;
        //}
        //private void chEdit12_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtEdit12.Enabled = chEdit12.Checked;
        //    if (!chEdit12.Checked)
        //        txtEdit12.Text = string.Empty;
        //}

        //*************************************************************************************
        //VAZGEC 
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // KAYDET BUTONUNA TIKLANDIĞINDA YAPILACAKLAR
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblNumuneler nmn = new TblNumuneler();
            nmn.nmn_aciklama = txtAciklama.Text;
            nmn.nmn_aciliyet = lookUpAciliyet.Text;
            nmn.nmn_aday_cari = txtAdayCari.Text;
            nmn.nmn_aday_carikonum = lookUpCariKnm.Text;
            nmn.nmn_cari_seviye = lookUpCariSvy.Text;
            if (int.TryParse(txtDenemeMktr.EditValue.ToString(), out int result))
                nmn.nmn_deneme_miktar = result;
            else
                MessageBox.Show("Lütfen sayısal bir değer giriniz.");
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

            if (int.TryParse(txtHedefFiyat.EditValue.ToString(), out int result2))
                nmn.nmn_hdf_fiyat = result2;
            else
                MessageBox.Show("Lütfen sayısal bir değer giriniz.");
            nmn.nmn_is_merkezi = lookUpIsMerkez.Text;
            nmn.nmn_kod = txtNmnKod.Text;
            //MFI VE HAMMADDE SORULACAK
            nmn.nmn_mfi = 0;
            //nmn.nmn_mfi = txtEdit1 + ',' + txtEdit2 + ',' + txtEdit3 + ',' + txtEdit4 + ',' + txtEdit5
            //                + ',' + txtEdit6 + ',' + txtEdit7 + ',' + txtEdit8 + ',' + txtEdit9;
            nmn.nmn_mus_yetkili = txtMusYetkili.Text;
            if (int.TryParse(txtKullanımOran.EditValue.ToString(), out int result3))
                nmn.nmn_oran = result3;
            else
                MessageBox.Show("Lütfen sayısal bir değer giriniz.");
            nmn.nmn_reach_rohs = radioGroupReachRohs.Properties.Items[radioGroupGida.SelectedIndex].Description;
            nmn.nmn_rkpcari_ad = txtRkpAd.Text;
            nmn.nmn_rkpcari_urunkod = txtRkpUrunKod.Text;
            
            if (int.TryParse(txtSipMktr.EditValue.ToString(), out int result4))
                nmn.nmn_sip_miktar = result3;
            else
                MessageBox.Show("Lütfen sayısal bir değer giriniz.");
            nmn.nmn_tarih = txtAlisTarih.DateTime;
            nmn.nmn_termintarih = txtTerminTarih.DateTime;
            nmn.nmn_tur = lookUpNmnTur.Text;
            nmn.nmn_uretilecek_urun = txtUretilecekUrun.Text;
            //nmn.nmn_gida = txtGıdayaUygunMu.Text;
            db.TblNumuneler.Add(nmn);
            db.SaveChanges();
            XtraMessageBox.Show("Numune Başarılı Bir Şekilde Tanımlandı",
                "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        MikroDB_V16_MASKOM dbMaskom = new MikroDB_V16_MASKOM();
        //SAYFA YÜKLENDİĞİNDE YAPILACAKLAR
        private void NewNumune_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.TblLab
                            select new
                            {
                                x.id,
                                x.lab_aciklama
                            }).ToList();
            lookUpCariKnm.Properties.ValueMember = "id";
            lookUpCariKnm.Properties.DisplayMember = "lab_aciklama";
            lookUpCariKnm.Properties.DataSource = degerler;
            lookUpCariSvy.Properties.ValueMember = "id";
            lookUpCariSvy.Properties.DisplayMember = "lab_aciklama";
            lookUpCariSvy.Properties.DataSource = degerler;
            lookUpDoviz.Properties.ValueMember = "id";
            lookUpDoviz.Properties.DisplayMember = "lab_aciklama";
            lookUpDoviz.Properties.DataSource = degerler;
            lookUpIsMerkez.Properties.ValueMember = "id";
            lookUpIsMerkez.Properties.DisplayMember = "lab_aciklama";
            lookUpIsMerkez.Properties.DataSource = degerler;
            lookUpHammadde.Properties.ValueMember = "id";
            lookUpHammadde.Properties.DisplayMember = "lab_aciklama";
            lookUpHammadde.Properties.DataSource = degerler;
            lookUpNmnTur.Properties.ValueMember = "id";
            lookUpNmnTur.Properties.DisplayMember = "lab_aciklama";
            lookUpNmnTur.Properties.DataSource = degerler;
            lookUpAciliyet.Properties.ValueMember = "id";
            lookUpAciliyet.Properties.DisplayMember = "lab_aciklama";
            lookUpAciliyet.Properties.DataSource = degerler;

            var cariHesaplar = (from x in dbMaskom.CARI_HESAPLAR
                                select new
                                {
                                    x.cari_kod,
                                    unvan = x.cari_unvan1 + x.cari_unvan2
                            }).ToList();
            lookUpCariAd.Properties.ValueMember = "cari_kod";
            lookUpCariAd.Properties.DisplayMember = "unvan";
            lookUpCariAd.Properties.DataSource = cariHesaplar;
            
            SetTodayDate();
        }
        public void SetTodayDate()
        {
            txtAlisTarih.EditValue = DateTime.Today;
            txtTerminTarih.EditValue = DateTime.Today;
        }

        private void lookUpCariKnm_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpCariSvy_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {

        }
    }
}
