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
            var sonucGirilmemisler = nmn.Where(x => !nmnh.Contains(x.nmn_kod)).Select(x => new
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
            var sonuclar = db.NUMUNE_HAREKETLERI.Select(x => new
            {
                x.nmnh_nmnkod,
                x.nmnh_sonucsirano,
                x.nmnh_labonay
                //labonayDisplayValue = x.nmnh_labonay == 1 ? "ONAYLANDI" : "ONAYLANMADI"
            }).ToList();
            numuneSonuclari.DataSource = sonuclar;
        }
        private void FrmNumuneSonucList_Load(object sender, EventArgs e)
        {
            ListNumuneSonuclar();
            ListSonucGirmemisler();
        }
        private void gridView1_RowStyle_1(object sender, RowStyleEventArgs e)
        {


        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_CustomDrawCell_1(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "nmnh_labonay")
            {
                int labOnay = Convert.ToInt32(e.CellValue);
                if (labOnay == 1)
                {
                    e.DisplayText = "✔";
                }
                else
                {
                    e.DisplayText = "❌";
                }
            }
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                var labOnay = View.GetRowCellValue(e.RowHandle, View.Columns["nmnh_labonay"]);
                if (labOnay.ToString() == "1")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.ForestGreen);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.ForestGreen);
                }
                else
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
                }
            }
        }
    }
}
