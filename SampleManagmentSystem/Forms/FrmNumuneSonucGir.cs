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
    public partial class FrmNumuneSonucGir : Form
    {
        public FrmNumuneSonucGir()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            //FrmNumuneSonucList formunda bulunan numuneSonucları gridViewini günceller
            FrmNumuneSonucList frmNmnSonucList = (FrmNumuneSonucList)Application.OpenForms["FrmNumuneSonucList"];
            if (frmNmnSonucList != null)
            {
                frmNmnSonucList.ListNumuneSonuclar();
                frmNmnSonucList.ListSonucGirmemisler();
                frmNmnSonucList.UpdateGridviews();
            }
        }
    }
}
