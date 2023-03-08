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
    public partial class FrmNumuneOnay : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();

        public FrmNumuneOnay(string nmnKod)
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
                txtNmnOnayAciklama.EditValue = nmn.nmn_nmnonay_aciklama;
                if (nmn.nmn_nmnonay != null)
                    radioGroupNmnOnay.SelectedIndex = nmn.nmn_nmnonay.Value;
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //FirstOrDefault, belirli bir koşula uyan ilk öğeyi döndüren veya eğer bu tür bir öğe bulunamazsa varsayılan değer döndüren bir LINQ uzantı metodudur.
            TblNumuneler nmn = db.TblNumuneler.FirstOrDefault(x => x.nmn_kod == txtNmnKod.EditValue.ToString());
            if (nmn != null)
            {
                if (radioGroupNmnOnay.EditValue == null)
                {
                    XtraMessageBox.Show("Numune onay boş bırakılamaz.", "Information");
                    radioGroupNmnOnay.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtNmnOnayAciklama.Text))
                {
                    XtraMessageBox.Show("Açıklama boş bırakılamaz.", "Information");
                    txtNmnOnayAciklama.Focus();
                    return;
                }

                nmn.nmn_lastup_date = DateTime.Now;
                nmn.nmn_nmnonay = (byte)(radioGroupNmnOnay.SelectedIndex);
                nmn.nmn_nmnonay_aciklama = txtNmnOnayAciklama.Text;
                db.SaveChanges();
                XtraMessageBox.Show("Numune onay başarılı bir şekilde kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
