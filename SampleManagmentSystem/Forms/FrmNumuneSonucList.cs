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
            //tblNumunelerBindingSource.DataSource = db.TblNumuneler.Where(db.NUMUNE_HAREKETLERI.Where(x=>x.nmnh_labonay==1))
        }
    }
}
