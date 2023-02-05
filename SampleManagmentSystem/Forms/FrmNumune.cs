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
        public void Listele()
        {
            
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;
            gridControl1.DataSource = db.ListNumune(df,dl).ToList();
            //gridControl1.DataSource = degerler;

        }
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
                NUMUNE_HAREKETLERI nmnh = db.NUMUNE_HAREKETLERI.FirstOrDefault(x => x.nmnh_nmnkod == nmn.nmn_kod);
                //SİLDİ
                db.NUMUNE_HAREKETLERI.Remove(nmnh);
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
            string nmnKod = gridView1.GetRowCellValue(selectedRowIndex, "nmn_kod").ToString();
            Forms.NewNumune fr = new Forms.NewNumune(nmnKod);
            fr.Show();
        }

        private void repositoryItemButtonDelete_Click_1(object sender, EventArgs e)
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
                NUMUNE_HAREKETLERI nmnh = db.NUMUNE_HAREKETLERI.FirstOrDefault(x => x.nmnh_nmnkod == nmn.nmn_kod);
                //SİLDİ
                db.NUMUNE_HAREKETLERI.Remove(nmnh);
                db.TblNumuneler.Remove(nmn);
                db.SaveChanges();
                Listele();
            }
        }
    }
    
}
