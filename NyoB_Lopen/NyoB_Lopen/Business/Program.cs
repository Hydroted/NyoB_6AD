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

        /// <summary>
        /// ontvangt nieuwe gegevens uit de GUI, maakt een nieuw object aan
        /// en overschrijft het juiste object in de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvAfst"></param>
        /// <param name="ontvBetaald"></param>
        static public void Aanpassen(int ontvIndex, String ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            //Maak een nieuwe object aan van de klasse met de juiste constructor
            Deelnemer aangepasteInschrijving = new Deelnemer(ontvNaam, ontvAfst, ontvBetaald);

            //voeg de nieuwe deelnemer toe aan de lijst
            _deelnemers[ontvIndex] = aangepasteInschrijving;
        }

        /// <summary>
        /// krijgt de index van een object en verwijdert het uit de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        static public void Verwijderen(int ontvIndex)
        {
            //verwijder de inschrijving
            _deelnemers.RemoveAt(ontvIndex);
        }

        /// <summary>
        /// geeft een lijst door met alle namen van de deelnemers
        /// </summary>
        /// <returns></returns>
        static public List<String> Deelnemers()
        {
            //Maak een nieuwe lijst aan
            List<String> antwoord = new List<string>();

            //Overloopt de lijst met deelnemers
            //Vergeet niet dat d een afzonderlijk object is waarin 1 voor 1 de objecten
            //van de lijst deelnemers wordt ingekopieerd
            foreach (Deelnemer d in _deelnemers)
            {
                //Neem de naam van de deelnemer en voeg deze toe aan
                //de antwoordlijst
                antwoord.Add(d._naam);
            }

            //return de antwoordlijst
            return antwoord;
        }

        /// <summary>
        /// stuurt een string door met alle gegevens van alle objecten 
        /// maar mooi geordend
        /// </summary>
        /// <returns></returns>
        static public String AlleGegevens()
        {
            //Maak de antwoord variabele aan
            String antwoord = null;

            //Overloop de lijst met deelnemers
            foreach (Deelnemer d in _deelnemers)
            {
                //Neem de naam van de deelnemer en voeg deze toe aan
                //de antwoordlijst
                antwoord += $"{d.AlleGegevens()}\n";
            }

            //Return de antwoord variabele
            return antwoord;
        }

        /// <summary>
        /// Geeft van 1 specifieke deelnemer weer welke afstand hij loopt
        /// en of hij wel of niet betaald heeft
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public String Geg1Deeln(int ontvIndex)
        {
            String antwoord = null;

            antwoord = _deelnemers[ontvIndex].AfstEnBetaald();

            return antwoord;
        }

        /// <summary>
        /// stuurt de gegevens van 1 deelnemer door
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public Deelnemer GegDeelnemer(int ontvIndex)
        {
            return _deelnemers[ontvIndex];
        }
    }
}
