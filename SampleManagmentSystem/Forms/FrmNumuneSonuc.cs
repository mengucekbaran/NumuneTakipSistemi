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
    public partial class FrmNumuneSonuc : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        public FrmNumuneSonuc()
        {
            
            InitializeComponent();
            dateBitisTarih.EditValue = DateTime.Now;

        }
        public FrmNumuneSonuc( int id)
        {
            InitializeComponent();
            dateBitisTarih.EditValue = DateTime.Now;
            TblNumuneler nmn = db.TblNumuneler.Find(id);
            if (nmn.id == id)
            {
                txtNmnKod.Visible = true;
                txtNmnKod.Enabled = false;
                lookUpNmnKod.Visible = false;
                txtNmnKod.EditValue = nmn.nmn_kod;
                
            }

        }
        private void FrmNumuneSonuc_Load(object sender, EventArgs e)
        {
            var numuneler = (from x in db.TblNumuneler
                             select new
                             {
                                 x.id,
                                 x.nmn_kod
                             }).ToList();
            lookUpNmnKod.Properties.ValueMember = "id";
            lookUpNmnKod.Properties.DisplayMember = "nmn_kod";
            lookUpNmnKod.Properties.DataSource = numuneler;
        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            NUMUNE_HAREKETLERI nmnh = new NUMUNE_HAREKETLERI();
            if (PostFormElementToDb(nmnh))
            {
                nmnh.nmnh_createdate = DateTime.Now;
                db.NUMUNE_HAREKETLERI.Add(nmnh);//tabloya ekler
                db.SaveChanges(); // degisiklikleri kaydeder

                //FrmNumuneSonucList formunda bulunan numuneSonucları gridViewini günceller
                FrmNumuneSonucList frmNmnSonucList = (FrmNumuneSonucList)Application.OpenForms["FrmNumuneSonucList"];
                if (frmNmnSonucList != null)
                {
                    frmNmnSonucList.ListNumuneSonuclar();
                    frmNmnSonucList.ListSonucGirmemisler();
                    frmNmnSonucList.UpdateGridviews();
                }
                XtraMessageBox.Show("Numune Sonucu Başarılı Bir Şekilde Tanımlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else return;
        }
        //FORMDAKİ DEĞERLERİ 
        public bool PostFormElementToDb(NUMUNE_HAREKETLERI nmnh)
        {
            //KONTROLLER
            if (lookUpNmnKod.Visible == true)
            {
                if (lookUpNmnKod.EditValue == null)
                {
                    XtraMessageBox.Show("Numune kodu boş bırakılamaz.", "Information");
                    lookUpNmnKod.ShowPopup();
                    return false;
                }
                else
                {
                    nmnh.nmnh_nmnkod = lookUpNmnKod.Text;
                    nmnh.nmnh_nmnid = int.Parse(lookUpNmnKod.EditValue.ToString());

                }

            }
            else

            if ( txtNmnKod.Visible == true)
            {
                if (string.IsNullOrEmpty(txtNmnKod.Text))
                {
                    XtraMessageBox.Show("Numune kodu boş bırakılamaz.", "Information");
                    txtNmnKod.Focus();
                    return false;
                }
                else
                {
                    nmnh.nmnh_nmnkod = txtNmnKod.Text;
                    nmnh.nmnh_nmnid = db.TblNumuneler.FirstOrDefault(x => x.nmn_kod == txtNmnKod.Text).id;
                }

            }

            if (dateBitisTarih.DateTime == Convert.ToDateTime("1-01-0001"))
            {
                XtraMessageBox.Show("Geçerli bir tarih giriniz.", "Information");
                dateBitisTarih.Focus();
                return false;
            }
            if (Convert.ToDecimal(spinMaliyetEuro.EditValue) < 0)
            {
                XtraMessageBox.Show("Maliyet negatif olamaz.", "Information");
                spinMaliyetEuro.Focus();
                return false;
            }
            if (Convert.ToDecimal(spinHassas.EditValue) < 0)
            {
                XtraMessageBox.Show("Işık hassaslığı negatif olamaz.", "Information");
                spinHassas.Focus();
                return false;
            }
            if (Convert.ToDecimal(spinDayanim.EditValue) < 0)
            {
                XtraMessageBox.Show("Isı dayanımı negatif olamaz.", "Information");
                spinDayanim.Focus();
                return false;
            }
            if (Convert.ToDecimal(spinRrOran.EditValue) < 0)
            {
                XtraMessageBox.Show("Reach/Rohs oranı negatif olamaz.", "Information");
                spinRrOran.Focus();
                return false;
            }
            if (Convert.ToDecimal(spinMaliyetYonetim.EditValue) < 0)
            {
                XtraMessageBox.Show("Yönetim maliyeti negatif olamaz.", "Information");
                spinMaliyetYonetim.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAciklama.Text))
            {
                XtraMessageBox.Show("Açıklama boş bırakılamaz.", "Information");
                txtAciklama.Focus();
                return false;
            }
            nmnh.nmnh_lastupdate = DateTime.Now;

            int nextSiraNo;
            //verilen numune koduna sahip kayıtlardan nmnh_sonucsirano en büyük olanını getirir.
            var result = db.NUMUNE_HAREKETLERI.Where(x => x.nmnh_nmnkod==nmnh.nmnh_nmnkod).Max(x => (int?)x.nmnh_sonucsirano);
            //null kontrol
            if (result.HasValue)
            {
                int siraNo = (int)result.Value;
                nextSiraNo = siraNo + 1;
            }
            else
            {
                nextSiraNo = 1;
            }
            nmnh.nmnh_sonucsirano = nextSiraNo;
            nmnh.nmnh_bitistarih = dateBitisTarih.DateTime;
            nmnh.nmnh_maliyetEuo = (float)spinMaliyetEuro.Value;
            nmnh.nmnh_isikhas = (float)spinHassas.Value;
            nmnh.nmnh_isidayanim = (float)spinDayanim.Value;
            nmnh.nmnh_rroran = (float)spinRrOran.Value;
            nmnh.nmnh_maliyetYonetim = (float)spinMaliyetYonetim.Value;
            nmnh.nmnh_gida = (byte)(radioGroupGida.SelectedIndex);
            nmnh.nmnh_labonay = (byte)(radioGroupLabOnay.SelectedIndex);
            nmnh.nmnh_aciklama = txtAciklama.Text;
            return true;
        }
    }
}
