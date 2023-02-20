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
    public partial class FrmMusteriOnay : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        public FrmMusteriOnay(string nmnKod)
        {
            InitializeComponent();
            TblNumuneler nmn = db.TblNumuneler.FirstOrDefault(n => n.nmn_kod == nmnKod);
            if (nmn.nmn_kod == nmnKod)
            {
                //FORM ELEMANLARINI TIKLANAN KAYIDIN BİLGİLERİYLE DOLDURMA
                txtNmnKod.Enabled = false;
                txtNmnAd.Enabled = false;
                txtNmnKod.EditValue = nmn.nmn_kod;
                txtNmnAd.EditValue = nmn.nmn_ad;
                txtMusAciklama.EditValue = nmn.nmn_musonay_aciklama;
                if(nmn.nmn_musonay != null)
                radioGroupMusOnay.SelectedIndex = nmn.nmn_musonay.Value;
            }
        }
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //FirstOrDefault, belirli bir koşula uyan ilk öğeyi döndüren veya eğer bu tür bir öğe bulunamazsa varsayılan değer döndüren bir LINQ uzantı metodudur.
            TblNumuneler nmn = db.TblNumuneler.FirstOrDefault(x => x.nmn_kod == txtNmnKod.EditValue.ToString());
            if (nmn != null)
            {
                if (string.IsNullOrEmpty(txtMusAciklama.Text))
                {
                    XtraMessageBox.Show("Açıklama boş bırakılamaz.", "Information");
                    txtMusAciklama.Focus();
                    return;
                }
                nmn.nmn_lastup_date = DateTime.Now;
                nmn.nmn_musonay = (byte)(radioGroupMusOnay.SelectedIndex);
                nmn.nmn_musonay_aciklama = txtMusAciklama.Text;
                db.SaveChanges();
              XtraMessageBox.Show("Müşteri onay başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.Close();                    
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
