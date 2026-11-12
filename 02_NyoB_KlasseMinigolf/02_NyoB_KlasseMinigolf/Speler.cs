using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NyoB_KlasseMinigolf
{
    public class Speler
    {
        //Nyo Boone
        //12/11/2026
        //Project Minigolf
        //Velden + properties
        public int _spelerID { get; set; } = -1;
        public string _voornaam { get; set; } = "John";
        public string _achternaam { get; set; } = "Doe";
        public int _totaalSlagen { get; set; } = 0;

        //Functies

        /// <summary>
        /// Maakt volledige naam van voornaam en achternaam en stuurt door
        /// </summary>
        /// <returns></returns>
        public string VolledigeNaam()
        {
            return $"{_voornaam} {_achternaam}";
        }

        /// <summary>
        /// Geeft alle gegevens: volledige naam + aantal slagen van speler
        /// </summary>
        /// <returns></returns>
        public string Allegegevens()
        {
            string antwoord = $"Speler: {VolledigeNaam()} {Environment.NewLine}";
            antwoord += $"       aantal slagen: {_totaalSlagen}";

            return antwoord;
        }

        /// <summary>
        /// Past aantal slagen van speler aan op basis van de ontvangen gegevens
        /// </summary>
        /// <param name="ontvSlagen"> aantal slagen dat toegevoegd moet worden </param>
        public void SlagenToevoegen(int ontvSlagen)
        {
            _totaalSlagen += ontvSlagen;
        }

        //Constructors

        public Speler() { }

        public Speler(int ontvID, string ontvVoornaam, string ontvAchternaam)
        {
            _voornaam = ontvVoornaam;
            _achternaam = ontvAchternaam;
        }

        public Speler(int ontvID, string ontvVoornaam, string ontvAchternaam, int ontvAantSlagen)
        {
            _spelerID = ontvID;
            _voornaam = ontvVoornaam;
            _achternaam = ontvAchternaam;
            _totaalSlagen = ontvAantSlagen;
        }

    }
}
