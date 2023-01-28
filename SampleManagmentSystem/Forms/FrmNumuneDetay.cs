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
            bindingSource1.DataSource = db.TblNumuneler.Local;
        }

        private void BtnList_Click_1(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
