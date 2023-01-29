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
    public partial class FrmNumune : Form
    {
        public FrmNumune()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
            DateTime temp = new DateTime(); //default 01/01/0001
            DateTime? df = dateFirst.DateTime;
            DateTime? dl = dateLast.DateTime;
            if (df == temp)
                df = null;
            if (dl == temp)
                dl = null;

            var degerler = (from x in db.ListNumune(df, dl)
                            select new
                            {
                                
                                x.nmn_kod,
                                x.nmn_tarih,
                                x.nmn_cari_seviye,
                                x.nmn_aday_cari,
                                x.nmn_aday_carikonum,
                                x.nmn_sip_miktar,
                                x.nmn_deneme_miktar,
                                x.nmn_hdf_fiyat,
                                x.nmn_fiyat_cins,
                                x.nmn_tur
                            });

            gridControl1.DataSource = degerler;

        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnList_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void dateFirst_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmNumune_Load(object sender, EventArgs e)
        {
            SetTodayDate();
        }
        //TABLONUN SATIRINA TIKLANDIĞINDA NUMUNE DÜZELTME SAYFASI
        //private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);


        //        Forms.NewNumune fr = new Forms.NewNumune();
        //        fr.Show();


        //}
        public void SetTodayDate()
        {
            DateTime dateTimeObj = DateTime.Parse($"01-01-{DateTime.Now.Year}");
            dateFirst.EditValue = dateTimeObj;
            dateLast.EditValue = DateTime.Today;
        }
    }
    
}
