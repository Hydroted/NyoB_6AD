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
    public partial class FrmOpz : Form
    {
        public FrmOpz()
        {
            InitializeComponent();
        }

        private void btnAn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmOpz_Load(object sender, EventArgs e)
        {
            VulCmb();
            PasUitzichtAan(1);
        }

        void VulCmb()
        {
            //Haal lijst op
            List<String> namen = Program.Deelnemers();

            //maak cmb leeg
            cmbKies.Items.Clear();

            //overloop de lijst met namen en steek ze 1 voor 1 in de cmb
            foreach (String s in namen)
            {
                cmbKies.Items.Add(s);
            }

        }

        /// <summary>
        /// Deze functie past het uitzicht aan afhankelijk van de gekozen optie
        /// </summary>
        /// <param name="versie"></param>
        void PasUitzichtAan(int versie)
        {
            if(versie == 1)
            {
                lblKies.Visible = false;
                cmbKies.Visible = false;

                lblToon.Location = new Point(17, 98);
                txtToon.Location = new Point(12, 134);
                Size = new Size(681, 538);
            }
            else
            {
                lblKies.Visible = true;
                cmbKies.Visible = true;

                lblToon.Location = new Point(17, 160);
                txtToon.Location = new Point(12, 196);
                Size = new Size(681, 600);
            }
        }

        private void btnAlle_Click(object sender, EventArgs e)
        {
            PasUitzichtAan(1);
        }

        private void btnEen_Click(object sender, EventArgs e)
        {
            PasUitzichtAan(2);
        }
    }
}
