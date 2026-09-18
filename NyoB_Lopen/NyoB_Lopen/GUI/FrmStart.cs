using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyoB_Lopen
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void btnAfs_Click(object sender, EventArgs e)
        {
            //Afsluiten
            Close();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            //object aanmaken van form
            FrmIns nieuwFrm = new FrmIns();

            //deze form hiden
            Hide();

            //object tonen
            nieuwFrm.ShowDialog();

            //deze form tonen
            Show();

        }

        private void btnOpz_Click(object sender, EventArgs e)
        {
            //object aanmaken van form
            FrmOpz nieuwFrm = new FrmOpz();

            //deze form hiden
            Hide();

            //object tonen
            nieuwFrm.ShowDialog();

            //deze form tonen
            Show();
        }

        private void btnBew_Click(object sender, EventArgs e)
        {
            //object aanmaken van form
            FrmBew nieuwFrm = new FrmBew();

            //deze form hiden
            Hide();

            //object tonen
            nieuwFrm.ShowDialog();

            //deze form tonen
            Show();
        }
    }
}
