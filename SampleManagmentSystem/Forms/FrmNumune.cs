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
        MikroDB_V16_MASKOM dbMaskom = new MikroDB_V16_MASKOM();
        public FrmNumune()
        {
            InitializeComponent();
            if(ActiveUser.Instance.YetkiDüzeltme== false)
            {
                gridView1.Columns["update"].Visible = false;
            }
            if (ActiveUser.Instance.YetkiSilme == false)
            {
                gridView1.Columns["delete"].Visible = false;
            }
        }
        public void Listele()
        {
            
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            int userNo = ActiveUser.Instance.UserNo;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;
            if(ActiveUser.Instance.YetkiListeleme==true)
                gridControl1.DataSource = db.ListAllNumune(df,dl).ToList();
            else
                gridControl1.DataSource = db.ListNumune(userNo, df, dl).ToList();

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
        //UPDATE BUTONUNA BASILDIĞINDA YAPILACAKLAR
        private void repositoryItemButtonUpdate_Click(object sender, EventArgs e)
        {
            
            //UPDATE BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.FocusedRowHandle;
            string nmnKod = gridView1.GetRowCellValue(selectedRowIndex, "nmn_kod").ToString();
            Forms.NewNumune fr = new Forms.NewNumune(nmnKod);
            fr.Show();
        }
        //MÜŞTERİ ONAY BUTONUNA BASILDIĞINDA YAPILACAKLAR
        private void repositoryItemButtonMusOnay_Click(object sender, EventArgs e)
        {
            //MÜŞTERİ ONAY BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.FocusedRowHandle;
            string nmnKod = gridView1.GetRowCellValue(selectedRowIndex, "nmn_kod").ToString();
            Forms.FrmMusteriOnay fr = new Forms.FrmMusteriOnay(nmnKod);
            fr.Show();
        }
        //DELETE NUMUNE 
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
                var nmnh = db.NUMUNE_HAREKETLERI.Where(x => x.nmnh_nmnkod == nmn.nmn_kod).ToList();
                foreach(var item in nmnh)
                {
                    db.NUMUNE_HAREKETLERI.Remove(item); //nmnh_koduna sahip tüm kayıtları sil
                }
                //SİLDİ
                db.TblNumuneler.Remove(nmn);
                db.SaveChanges();
                //FrmNumuneSonucList formunda bulunan numuneSonucları gridViewini günceller
                FrmNumuneSonucList frmNmnSonucList = (FrmNumuneSonucList)Application.OpenForms["FrmNumuneSonucList"];
                if (frmNmnSonucList != null)
                {
                    frmNmnSonucList.ListNumuneSonuclar();
                    frmNmnSonucList.ListSonucGirmemisler();
                    frmNmnSonucList.UpdateGridviews();
                }
                Listele();
            }
        }


        private void repositoryItemButtonDetay_Click(object sender, EventArgs e)
        {
            //DETAY BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.FocusedRowHandle;
            string nmnKod = gridView1.GetRowCellValue(selectedRowIndex, "nmn_kod").ToString();
            Forms.FrmNumuneSonucList2 fr = new Forms.FrmNumuneSonucList2(nmnKod);
            fr.Show();
        }


    }
    
}
