using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyoB_Wijnen
{
    internal class Wijn
    {
        //Nyo Boone
        //13/10/2026
        //Project Wijnen

        //Velden + Properties
        public String _naam { get; set; } = "";
        public String _druivensoort { get; set; } = "";
        public DateTime _jaartal { get; set; } = DateTime.Now;

        //Functies
        //Neemt alle gegevens en zet deze om naar een tekst
        public String AlleGegevens()
        {
            String antwoord = "";

            antwoord = $"De wijn {_naam}, komt uit het jaar {_jaartal} en is gemaakt uit {_druivensoort}.";

            return antwoord;
        }

        //Contructors
        //Default constructor
        public Wijn() { }
        public Wijn(string ontvNaam, DateTime ontvJaartal, string ontvDruif)
        {
            _naam = ontvNaam;
            _jaartal = ontvJaartal;
            _druivensoort = ontvDruif;
        }
    }
}
