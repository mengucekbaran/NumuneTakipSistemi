using SampleManagmentSystem.Entities;
using SampleManagmentSystem.Forms;
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

        MikroDB_V16Entities dbMikro = new MikroDB_V16Entities();
        //MikroDB_V16_MASKOM dbMaskom = new MikroDB_V16_MASKOM();
        public Form1()
        {
            InitializeComponent();
            homePage.Visible = false;
            if (ActiveUser.Instance.YetkiSonucEkleme == false)
            {
                //satış giriş yaparsa numune listesini getir
                FrmNumune frmNumune = new FrmNumune();
                ViewChildForm(frmNumune);
                lab.Visible = false;
            }
            else
            {
                // lab giriş yaparsa numune detayı getir
                FrmNumuneSonucDetay sonucDetay = new FrmNumuneSonucDetay();
                ViewChildForm(sonucDetay);
            }

        }
        //formun mdi alanında gözükmesi için bu Form1 parametre verilen formun parenti atanır

        public void ViewChildForm(Form form)
        {
            form.MdiParent = this;
            form.Show();
        }
        //SONUÇ LİSTESİ
        Forms.FrmNumuneSonucList sonucList;
        private void btnNumuneList2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Mdi Kapanan Formun Yeniden Açılması ve Açık olan formun tekrardan açılmaması
            if (sonucList == null || sonucList.IsDisposed)
            {
                sonucList = new Forms.FrmNumuneSonucList();
                //mdi alanında gözükmesi için this ile belirtilir
                ViewChildForm(sonucList);
            }

        }

        // Numune Listesi butonuna tıklandığında  frmNumune formu Formdaki mdi alanında gözükür
        Forms.FrmNumune frmNumune;
        private void bntNumuneList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmNumune == null || frmNumune.IsDisposed)
            {
                frmNumune = new Forms.FrmNumune();
                ViewChildForm(frmNumune);
            }

        }
        Forms.NewNumune newNumune;
        private void NewNumuneAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(newNumune == null || newNumune.IsDisposed)
            {
                newNumune = new Forms.NewNumune();
                newNumune.Show();
            }
        }
        Forms.FrmNumuneDetay frmNumuneDetay;
        private void btnNumuneDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmNumuneDetay==null || frmNumuneDetay.IsDisposed)
            {
                frmNumuneDetay = new Forms.FrmNumuneDetay();
                frmNumuneDetay.Show();
            }
        }
        Forms.FrmNumuneSonuc frmNumuneSonuc;
        private void btnNumuneSonuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frmNumuneSonuc==null || frmNumuneSonuc.IsDisposed)
            {
                frmNumuneSonuc = new Forms.FrmNumuneSonuc();
                ViewChildForm(frmNumuneSonuc);
            }

        }



        private void btnSonucDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ribbonControl1.BackColor = Color.Green;

        }
        Forms.FrmNumuneSonucDetay frmSonucDetay;
        private void btnSonucDetay_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmSonucDetay == null || frmSonucDetay.IsDisposed)
            {
                frmSonucDetay = new Forms.FrmNumuneSonucDetay();
                ViewChildForm(frmSonucDetay);
            }
        }
    }
}
