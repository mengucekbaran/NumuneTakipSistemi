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
    public partial class FrmNumuneSonucList2 : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();

        public FrmNumuneSonucList2(string nmnKod)
        {
            InitializeComponent();
            ListNumuneSonuclar(nmnKod);
        }
        public void ListNumuneSonuclar(string nmnKod)
        {
            var sonuclar = db.NUMUNE_HAREKETLERI.Select(x => new
            {
                x.nmnh_nmnkod,
                x.nmnh_sonucsirano,
                x.nmnh_labonay
                //labonayDisplayValue = x.nmnh_labonay == 1 ? "ONAYLANDI" : "ONAYLANMADI"
            }).Where(x => x.nmnh_nmnkod==nmnKod).ToList();
            numuneSonuclari.DataSource = sonuclar;
        }


        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "nmnh_labonay")
            {
                int labOnay = Convert.ToInt32(e.CellValue);
                if (labOnay == 0)
                {
                    e.DisplayText = "❌";
                }
                else if (labOnay == 1)
                {
                    e.DisplayText = "✔ ";
                }
                else
                {
                    e.DisplayText = "DEVAM EDİYOR";
                }
            }
        }

        private void gridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                var labOnay = View.GetRowCellValue(e.RowHandle, View.Columns["nmnh_labonay"]);
                if (labOnay.ToString() == "0")
                {

                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.Salmon);
                }
                else if (labOnay.ToString() == "1")
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
