using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        // Numune Listesi butonuna tıklandığında  frmNumune formu Formdaki mdi alanında gözükür
        private void bntNumuneList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            Forms.FrmNumune frmNumune = new Forms.FrmNumune();
            //mdi alanında gözükmesi için this ile belirtilir
            frmNumune.MdiParent = this;
            frmNumune.Show();
        }

        private void NewNumuneAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.NewNumune fr = new Forms.NewNumune();
            fr.Show();
        }

        private void btnNumuneDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.FrmNumuneDetay fr = new Forms.FrmNumuneDetay();
            fr.Show();
        }
    }
}
