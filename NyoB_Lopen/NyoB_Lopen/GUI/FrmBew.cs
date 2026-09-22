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
    public partial class FrmBew : Form
    {
        public FrmBew()
        {
            InitializeComponent();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBew_Load(object sender, EventArgs e)
        {
            rbNietbetaald.Checked = true;
            VulCmb();
        }

        void VulCmb()
        {
            //Haal lijst op
            List<String> namen = Program.Deelnemers();

            //maak cmb leeg
            cmbKies.Items.Clear();

            //overloop de lijst met namen en steek ze 1 voor 1 in de cmb
            foreach(String s in namen)
            {
                cmbKies.Items.Add(s);
            }
        }

        private void cmbKies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sla de geselecteerde index op
            int index = cmbKies.SelectedIndex;

            //Haal de deelnemer op die bij deze index hoort
            Deelnemer ontvDeelnemer = Program.GegDeelnemer(index);

            //vul de gegevens in
            txtNaam.Text = ontvDeelnemer._naam;
            if(ontvDeelnemer._afstand == 5)
            {
                cmbAfst.SelectedIndex = 0;
            }
            else if (ontvDeelnemer._afstand == 10)
            {
                cmbAfst.SelectedIndex = 1;
            }
            if (ontvDeelnemer._afstand == 20)
            {
                cmbAfst.SelectedIndex = 2;
            }
            
            if(ontvDeelnemer._betaald)
            {
                rbBetaald.Checked = true;
            }
            else
            {
                rbNietbetaald.Checked = false;
            }
        }
    }
}
