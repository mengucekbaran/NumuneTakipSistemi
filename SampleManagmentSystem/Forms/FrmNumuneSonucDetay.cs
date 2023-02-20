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
    public partial class FrmNumuneSonucDetay : Form
    {
        public FrmNumuneSonucDetay()
        {
            InitializeComponent();
        }
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        void Listele()
        {
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            int userNo = ActiveUser.Instance.UserNo;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;

            if (ActiveUser.Instance.YetkiListeleme == true)
                gridControl1.DataSource = db.ListAllNumune(df, dl).ToList();
            else
                gridControl1.DataSource = db.ListNumune(userNo, df, dl).ToList();

        }
        public void SetTodayDate()
        {
            DateTime dateTimeObj = DateTime.Parse($"01-01-{DateTime.Now.Year}");
            dateFirst.EditValue = dateTimeObj;
            dateLast.EditValue = DateTime.Today;
        }
        private void FrmNumuneSonucDetay_Load(object sender, EventArgs e)
        {
            SetTodayDate();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length > 0)
            {
                int selectedRowIndex = gridView1.GetSelectedRows()[0];
                if (selectedRowIndex >= 0 && selectedRowIndex < gridView1.RowCount)
                {
                    //SONUC GİR BUTONUNA BASILAN SATIRDAKİ İD BULUNUR
                    int id = (int)gridView1.GetRowCellValue(selectedRowIndex, "id");
                    Forms.FrmNumuneSonuc fr = new Forms.FrmNumuneSonuc(id);
                    fr.Show();
                }
            }


        }


    }
}
