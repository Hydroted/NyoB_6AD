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

        private void btnAanp_Click(object sender, EventArgs e)
        {
            //kijken of alles werd ingevuld
            if (cmbKies.SelectedIndex != -1 && txtNaam.Text != "" && cmbAfst.SelectedIndex != -1)
            {
                //Sla alle ontvangen gegevens op in een variabele
                int ontvInd = cmbKies.SelectedIndex;
                String ontvNm = txtNaam.Text;
                int ontvAfst = 0;
                if (cmbAfst.SelectedIndex == 0)
                {
                    ontvAfst = 5;
                }
                else if (cmbAfst.SelectedIndex == 1)
                {
                    ontvAfst = 10;
                }
                else if (cmbAfst.SelectedIndex == 2)
                {
                    ontvAfst = 20;
                }

                bool ontvBet = false;
                if (rbBetaald.Checked)
                {
                    ontvBet = true;
                }

                //Stuur door naar de business om aan te passen
                Program.Aanpassen(ontvInd, ontvNm, ontvAfst, ontvBet);

                //Bevestig bij gebruiker
                MessageBox.Show("Deze persoon is ingeschreven.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset form
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";
                txtNaam.Text = "";
                cmbAfst.SelectedIndex = -1;
                cmbAfst.Text = "";
                rbNietbetaald.Checked = true;
                VulCmb();
            }

            else
            {
                //Toon foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerw_Click(object sender, EventArgs e)
        {
            //kijken of alles werd ingevuld
            if(cmbKies.SelectedIndex != -1)
            {
                //sla ontvangen gegevens op in een variabele
                int ontvInd = cmbKies.SelectedIndex;

                //Geef gegevens door naar business
                Program.Verwijderen(ontvInd);

                //Bevestig bij gebruiker
                MessageBox.Show("Deze persoon is verwijderd.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset form
                cmbKies.SelectedIndex = -1;
                cmbKies.Text = "";
                txtNaam.Text = "";
                cmbAfst.SelectedIndex = -1;
                cmbAfst.Text = "";
                rbNietbetaald.Checked = true;
                VulCmb();
            }
            else
            {
                //Toon foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
