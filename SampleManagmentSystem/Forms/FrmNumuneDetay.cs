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
            int selectedRowIndex = gridView1.GetSelectedRows()[0];
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATE BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
            int selectedRowIndex = gridView1.GetSelectedRows()[0];
            int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");

            Forms.NewNumune fr = new Forms.NewNumune(id);
            fr.Show();
        }
    }
}
