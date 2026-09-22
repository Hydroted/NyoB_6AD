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
    public partial class FrmIns : Form
    {
        public FrmIns()
        {
            InitializeComponent();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIns_Click(object sender, EventArgs e)
        {
            //kijken of alles werd ingevuld
            if (txtNaam.Text != "" && cmbAfst.SelectedIndex != -1)
            {
                //Sla alle ontvangen gegevens op in een variabele
                String ontvNm = txtNaam.Text;
                int ontvAfst = 0;
                if(cmbAfst.SelectedIndex == 0)
                {
                    ontvAfst = 5;
                }
                else if(cmbAfst.SelectedIndex == 1)
                {
                    ontvAfst = 10;
                }
                else if (cmbAfst.SelectedIndex == 2)
                {
                    ontvAfst = 20;
                }
                
                bool ontvBet = false;
                if(rbBetaald.Checked)
                {
                    ontvBet = true;
                }

                //Stuur door naar de business om op te slaan
                Program.Inschrijven(ontvNm, ontvAfst, ontvBet);

                //Bevestig bij gebruiker
                MessageBox.Show("Deze persoon is ingeschreven.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset form
                txtNaam.Text = "";
                cmbAfst.SelectedIndex = -1;
                cmbAfst.Text = "";
                rbNietbetaald.Checked = true;
            }

            else
            {
                //Toon foutmelding
                MessageBox.Show("U heeft niet alles ingevuld!", "Fout!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmIns_Load(object sender, EventArgs e)
        {
            rbNietbetaald.Checked = true;
        }
    }
}
