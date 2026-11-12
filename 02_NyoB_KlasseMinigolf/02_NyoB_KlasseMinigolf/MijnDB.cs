using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _02_NyoB_KlasseMinigolf
{
    public class MijnDB
    {
        // Velden
        String _mijnPad = "";
        OleDbConnection _mijnConnectie = new OleDbConnection(_mijnPad);

        // Methode
        /// <summary>
        /// Stuurt list door met objecten van alle spelers uit databank
        /// </summary>
        /// <returns></returns>
        public List<Speler> HaalSpelersUitDB()
        {

        }

        /// <summary>
        /// Voegt speler toe in databank
        /// </summary>
        /// <param name="ontvSpeler"></param>
        public void SpelerToevInDB(Speler ontvSpeler)
        {
            //haal gegevens uit object
            string voornaam = ontvSpeler._voornaam;
            string achternaam = ontvSpeler._achternaam;

            //maak de sql
            string sql = $"INSERT INTO Speler (Voornaam, Achternaam) VALUES ('{voornaam}', '{achternaam}')";

            //maak commando dat deze sql uitvoerd in onze databank
            OleDbCommand mijnComm = new OleDbCommand(sql, _mijnConnectie);
        }

        /// <summary>
        /// Update speler in databank
        /// </summary>
        /// <param name="ontvSpeler"></param>
        public void SpelerAanpInDB(Speler ontvSpeler)
        {

        }

        /// <summary>
        /// Verwijdert speler uit databank
        /// </summary>
        /// <param name="ontvSpeler"></param>
        public void SpelerVerwInDB(Speler ontvSpeler)
        {

        }

        public void ResetSpelInDB()
        {

        }

    }
}
