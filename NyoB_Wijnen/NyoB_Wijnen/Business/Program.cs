using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyoB_Wijnen
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
            Application.Run(new FrmKeuze());
        }

        //Velden
        static List<Wijn> _wijnen = new List<Wijn>();

        //Functies

        /// <summary>
        /// Stuurt een lijst door met de namen van alle wijnen
        /// </summary>
        /// <returns></returns>
        static public List<String> Namen()
        {
            //Maak een nieuwe lijst aan
            List<String> antwoord = new List<string>();

            //Overloopt de lijst met wijnen
            //Vergeet niet dat d een afzonderlijk object is waarin 1 voor 1 de objecten
            //van de lijst wijnen wordt ingekopieerd
            foreach (Wijn w in _wijnen)
            {
                //Neem de naam van de wijn en voeg deze toe aan
                //de antwoordlijst
                antwoord.Add(w._naam);
            }

            //return de antwoordlijst
            return antwoord;
        }

        /// <summary>
        /// Ontvangt gegevens en voegt die toe aan de lijst
        /// </summary>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvJaartal"></param>
        /// <param name="ontvDruif"></param>
        static public void Toevoegen(string ontvNaam, DateTime ontvJaartal, string ontvDruif)
        {
            //Maak nieuwe object aan
            Wijn nieuweWijn = new Wijn(ontvNaam, ontvJaartal, ontvDruif);

            //Voeg wijn toe aan de lijst
            _wijnen.Add(nieuweWijn);
        }

        /// <summary>
        /// Ontvangt index van oude gegevens en nieuwe gegevens en past die aan in de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <param name="ontvNaam"></param>
        /// <param name="ontvJaartal"></param>
        /// <param name="ontvDruif"></param>
        static public void Aanpassen(int ontvIndex, string ontvNaam, DateTime ontvJaartal, string ontvDruif)
        {
            //Maak een nieuwe object aan van de klasse met de juiste constructor
            Wijn aangepasteWijn = new Wijn(ontvNaam, ontvJaartal, ontvDruif);

            //voeg de nieuwe gegevens toe aan de lijst
            _wijnen[ontvIndex] = aangepasteWijn;
        }

        /// <summary>
        /// Krijgt index van wijn en verwijdert uit de lijst
        /// </summary>
        /// <param name="ontvIndex"></param>
        static public void Verwijderen(int ontvIndex)
        {
            //Verwijdert wijn en gegevens uit de lijst
            _wijnen.RemoveAt(ontvIndex);
        }

        /// <summary>
        /// Stuurt een lijst door van alle gegevens
        /// </summary>
        /// <returns></returns>
        static public string Allegegevens()
        {
            //Maak de antwoord variabele aan
            String antwoord = null;

            //Overloop de lijst met deelnemers
            foreach (Wijn w in _wijnen)
            {
                //Neem de naam van de deelnemer en voeg deze toe aan
                //de antwoordlijst
                antwoord += $"{w.AlleGegevens()}\n";
            }

            //Return de antwoord variabele
            return antwoord;
        }

        /// <summary>
        /// Ontvangt de index van een wijn en stuurt daarvan de druivensoort
        /// </summary>
        /// <param name="ontvIndex"></param>
        /// <returns></returns>
        static public string EenTonen(int ontvIndex)
        {
            //Maak de antwoord variabele aan
            String antwoord = null;

            //Vind de druivensoort van de ontvangen index
            antwoord = _wijnen[ontvIndex]._druivensoort;

            //Stuur antwoord door
            return antwoord;

        }

        /// <summary>
        /// Kiest een random wijn uit de collectie en stuurt die naar de gebruiker
        /// </summary>
        /// <returns></returns>
        static public string RandomTonen()
        {
            //Maak de antwoord variabele aan
            string antwoord = null;
            int index = 0;

            //Maak random aan
            Random rnd = new Random();
            index = rnd.Next(_wijnen.Count);

            //Vind de naam van de random index (en zet die in een zin)
            antwoord = $"Je willekeurig gekozen wijn.... {_wijnen[index]._naam}!!!";

            //Stuur antwoord door
            return antwoord;

        }

    }
}
