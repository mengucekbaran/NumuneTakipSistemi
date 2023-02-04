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

        private void FrmNumuneSonucList_Load(object sender, EventArgs e)
        {
            var sonuclar = db.NUMUNE_HAREKETLERI.Select(x => new
            {
                x.nmnh_nmnkod,
                x.nmnh_sonucsirano,
                labonayDisplayValue = x.nmnh_labonay == 1 ? "ONAYLANDI" : "ONAYLANMADI"
            }).ToList();
            numuneSonuclari.DataSource = sonuclar;
            var nmn = db.TblNumuneler.ToList();
            var nmnh = db.NUMUNE_HAREKETLERI.Select(x => x.nmnh_nmnkod).ToList();
            var sonucGirilmemisler = nmn.Where(x => !nmnh.Contains(x.nmn_kod)).Select(x => new
            {
                x.nmn_kod,
                x.nmn_ad
            }).ToList();
            nmnSonucGirilmemis.DataSource = sonucGirilmemisler;
        }
    }
}
