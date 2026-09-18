using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyoB_Lopen
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmStart());
        }

        //Velden
        static List<Deelnemer> _deelnemers = new List<Deelnemer>();

        //Functies
        /// <summary>
        /// Ontvangt een naam, afstand en of er betaald is en voegt de deelnemer toe in de lijst
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvAfst"></param>
        /// <param name="ontvBetaald"></param>
        static public void Inschrijven(String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            //Maak een nieuwe object aan van de klasse met de juiste constructor
            Deelnemer nieuweInschrijving = new Deelnemer(ontvNaam, ontvAfst, ontvBetaald);

            //voeg de nieuwe deelnemer toe aan de lijst
            _deelnemers.Add(nieuweInschrijving);
        }

        static public void Aanpassen(int ontvIndex, String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            //Maak een nieuwe object aan van de klasse met de juiste constructor
            Deelnemer aangepasteInschrijving = new Deelnemer(ontvNaam, ontvAfst, ontvBetaald);

            //voeg de nieuwe deelnemer toe aan de lijst
            _deelnemers[ontvIndex] = aangepasteInschrijving;
        }

        static public void Verwijderen(int ontvIndex)
        {
            //verwijder de inschrijving
            _deelnemers.RemoveAt(ontvIndex);
        }

        static public List<String> Deelnemers()
        {

        }

        static public String AlleGegevens()
        {

        }

        static public String Geg1Deeln(int ontvIndex)
        {

        }

    }
}
