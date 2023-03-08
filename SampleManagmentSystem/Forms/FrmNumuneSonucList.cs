using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FrmNumuneSonucList : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();

        public FrmNumuneSonucList()
        {
            InitializeComponent();
        }
        public void UpdateGridviews()
        {
            nmnSonucGirilmemis.Refresh();
            numuneSonuclari.Refresh();
        }
        public void ListSonucGirmemisler()
        {
            var nmn = db.TblNumuneler.ToList();
            var nmnh = db.NUMUNE_HAREKETLERI.Select(x => x.nmnh_nmnkod).ToList();
            var sonucGirilmemisler = nmn.OrderBy(x=>x.nmn_kod).Where(x => !nmnh.Contains(x.nmn_kod)).Select(x => new
            {
                x.nmn_kod,
                x.nmn_ad,
                x.nmn_cari_kod,
                x.nmn_cari_unvan,
                x.nmn_tarih,
                x.nmn_cari_seviye

            }).ToList();
            nmnSonucGirilmemis.DataSource = sonucGirilmemisler;
        }
        public void ListNumuneSonuclar()
        {
            var sonuclar = (from nmnh in db.NUMUNE_HAREKETLERI
                            join nmn in db.TblNumuneler
                            on nmnh.nmnh_nmnkod equals nmn.nmn_kod
                            orderby nmnh.nmnh_nmnkod
                            select new
                            {
                                nmnh.nmnh_nmnkod,
                                nmnh.nmnh_sonucsirano,
                                //nmnh.nmnh_labonay,
                                //musteri_fiyatonay = nmnh.nmnh_labonay == 1 ? (nmn.nmn_musonay==1?"ONAYLANDI" : "ONAYLANMADI") : ""
                                musteri_fiyatonay = nmn.nmn_musonay == 1 ? "ONAYLANDI" :
                                nmn.nmn_musonay == 0 ? "ONAYLANMADI" : "",

                                nmn_nmnonay = nmn.nmn_nmnonay == 1 ? "ONAYLANDI" :
                                nmn.nmn_nmnonay == 0 ? "ONAYLANMADI" : ""
                            }).ToList();
                     numuneSonuclari.DataSource = sonuclar;
        }
        private void FrmNumuneSonucList_Load(object sender, EventArgs e)
        {
            ListNumuneSonuclar();
            ListSonucGirmemisler();
        }
        //private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        //{
        //    if (e.Column.FieldName == "nmnh_labonay")
        //    {
        //        int labOnay = Convert.ToInt32(e.CellValue);
        //        if (labOnay == 1)
        //        {
        //            e.DisplayText = "✔";
        //        }
        //        else if (labOnay == 0)
        //        {
        //            e.DisplayText = "❌";
        //        }
        //        else
        //        {
        //            e.DisplayText = "DEVAM EDİYOR";
        //        }
        //    }
        //}

        private void gridView1_RowStyle_1(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                var nmnOnay = View.GetRowCellValue(e.RowHandle, View.Columns["nmn_nmnonay"]);
                if (nmnOnay.ToString() == "ONAYLANMADI")
                {

                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
                }
                else if (nmnOnay.ToString() == "ONAYLANDI")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.ForestGreen);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.ForestGreen);
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Blue);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Blue);
                }
            }
        }
    }
}
