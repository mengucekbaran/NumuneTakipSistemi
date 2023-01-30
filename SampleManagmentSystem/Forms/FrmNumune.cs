using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using SampleManagmentSystem.Entities;
namespace SampleManagmentSystem.Forms
{
    public partial class FrmNumune : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        public FrmNumune()
        {
            InitializeComponent();
        }
        void Listele()
        {
            
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;

            //var degerler = (from x in db.ListNumune(df, dl)
            //                select new
            //                {
            //                    x.id,
            //                    x.nmn_kod,
            //                    x.nmn_cari_kod,
            //                    x.nmn_cari_unvan,
            //                    x.nmn_tarih,
            //                    x.nmn_cari_seviye,
            //                    x.nmn_adaycari_unvan,
            //                    x.nmn_sip_miktar,
            //                    x.nmn_deneme_miktar,
            //                    x.nmn_hdf_fiyat,
            //                    x.nmn_fiyat_cins,
            //                    x.nmn_tur
            //                }).ToList();
            gridControl1.DataSource = db.ListNumune(df,dl).ToList();
            //gridControl1.DataSource = degerler;

        }

        //private void EditButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    int selectedRowIndex = gridView1.FocusedRowHandle;
        //    int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");

        //    Form2 form2 = new Form2(id);
        //    form2.ShowDialog();
        //    Listele();
        //}
        //private void DeleteButton_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    int selectedRowIndex = gridView1.FocusedRowHandle;
        //    int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");

        //    var sonuc = MessageBox.Show("Seçili veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        //    if (sonuc == DialogResult.Yes)
        //    {
        //        numune_takip numune = db.numune_takip.Find(id);
        //        db.numune_takip.Remove(numune);
        //        db.SaveChanges();
        //        Listele();
        //    }
        //}
        private void BtnList_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
        //SAYFA YÜKLENDİĞİNDE
        private void FrmNumune_Load(object sender, EventArgs e)
        {
            SetTodayDate();
        }
        //TARİHLERE BAŞLANGI DEĞERİ ATAMA
        public void SetTodayDate()
        {
            DateTime dateTimeObj = DateTime.Parse($"01-01-{DateTime.Now.Year}");
            dateFirst.EditValue = dateTimeObj;
            dateLast.EditValue = DateTime.Today;
        }
        //DELETE NUMUNE
        private void repositoryItemButtonDelete_Click(object sender, EventArgs e)
        {
            //DELETE BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.FocusedRowHandle;
            int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");

            //SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ MESAJI
            var sonuc = XtraMessageBox.Show($"{(gridView1.GetFocusedRow() as ListNumune_Result).nmn_kod} kodlu kaydı silmek istediğinizden emin misiniz ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //YESE TIKLANIRSA
            if (sonuc == DialogResult.Yes)
            {
                XtraMessageBox.Show("Siliniyor...");
                // TABLODA VERİLEN İD YE EŞİT OLAN KAYDI BULDU
                TblNumuneler nmn = db.TblNumuneler.Find(id);
                //SİLDİ
                db.TblNumuneler.Remove(nmn);
                db.SaveChanges();
                Listele();
            }
        }
        //UPDATE BUTONUNA BASILDIĞINDA YAPILACAKLAR
        private void repositoryItemButtonUpdate_Click(object sender, EventArgs e)
        {
            
            //UPDATE BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.FocusedRowHandle;
            int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");

            Forms.NewNumune fr = new Forms.NewNumune(id);
            fr.Show();
        }


    }
    
}
