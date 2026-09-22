using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace NyoB_Lopen
{
    internal class Deelnemer
    {
        //Nyo Boone
        //11/09/2026
        //Project Lopen

        //Velden + Properties
        public String _naam { get; set; } = "";
        public int _afstand { get; set; } = 0;
        public bool _betaald { get; set; } = false;

        //Functies
        //Neemt alle gegevens en zet deze om naar een tekst
        public String AlleGegevens()
        {
            String antwoord = "";

            antwoord = $"Deelnemer: {_naam}, loopt {_afstand}km, ";
            if(_betaald)
            {
                antwoord += $"en heeft betaald";
            }
            else
            {
                antwoord += $"en heeft niet betaald";
            }

            return antwoord;
        }

        //Toont welke afstand een bepaalde loper heeft en of hij betaald heeft
        public String AfstEnBetaald()
        {
            String antwoord = "";

            antwoord = $"De gekozen afstand {_afstand}km, ";
            if(_betaald)
            {
                antwoord += $"heeft betaald";
            }
            else
            {
                antwoord += $"heeft niet betaald";
            }

            return antwoord;
        }

        //Contructors
        //Default constructor
        public Deelnemer() { }
        public Deelnemer(string ontvNaam, int ontvAfst, bool ontvBetaald)
        {
            _naam = ontvNaam;
            _afstand = ontvAfst;
            _betaald = ontvBetaald;
        }

    }
}
