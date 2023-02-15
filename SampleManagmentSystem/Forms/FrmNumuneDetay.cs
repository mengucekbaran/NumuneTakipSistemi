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
    public partial class FrmNumuneDetay : Form
    {
        public FrmNumuneDetay()
        {
            InitializeComponent();
            if(ActiveUser.Instance.YetkiDüzeltme == false)
            {
                BtnUpdate.Visible = false;
            }
            if (ActiveUser.Instance.YetkiSilme == false)
            {
                BtnDelete.Visible = false;
            }
        }
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        void Listele()
        {
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;

            var degerler = db.ListNumune(df, dl);
            gridControl1.DataSource = degerler;

        }

        private void BtnList_Click(object sender, EventArgs e)
        {

        }

        private void FrmNumuneDetay_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = db.TblNumuneler.Local;
            SetTodayDate();
        }

        private void BtnList_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
        public void SetTodayDate()
        {
            DateTime dateTimeObj = DateTime.Parse($"01-01-{DateTime.Now.Year}");
            dateFirst.EditValue = dateTimeObj;
            dateLast.EditValue = DateTime.Today;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                int selectedRowIndex = gridView1.GetSelectedRows()[0];
                if (selectedRowIndex >= 0 && selectedRowIndex < gridView1.RowCount)
                {
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
                        foreach (var item in nmnh)
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
            }
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATE BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            if (gridView1.GetSelectedRows().Length > 0)
            {
                int selectedRowIndex = gridView1.GetSelectedRows()[0];
                if (selectedRowIndex >= 0 && selectedRowIndex < gridView1.RowCount)
                {
                    string nmnKod = gridView1.GetRowCellValue(selectedRowIndex, "nmn_kod").ToString();
                    Forms.NewNumune fr = new Forms.NewNumune(nmnKod);
                    fr.Show();
                }
            }

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
