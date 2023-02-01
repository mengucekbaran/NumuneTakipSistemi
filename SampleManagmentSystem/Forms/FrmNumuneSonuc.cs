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
    public partial class FrmNumuneSonuc : Form
    {
        NUMUNE_TAKİPEntities db = new NUMUNE_TAKİPEntities();
        public FrmNumuneSonuc()
        {
            
            InitializeComponent();
            dateBitisTarih.EditValue = DateTime.Now;

        }
        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNumuneSonuc_Load(object sender, EventArgs e)
        {
            var numuneler = (from x in db.TblNumuneler
                                select new
                                {
                                    x.id,
                                    x.nmn_kod                   
                                }).ToList();
            lookUpNmnKod.Properties.ValueMember = "id";
            lookUpNmnKod.Properties.DisplayMember = "nmn_kod";
            lookUpNmnKod.Properties.DataSource = numuneler;
        }
    }
}
