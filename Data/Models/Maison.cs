using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Maison : Habitable
    {
        // Attributs
        public int MaisonId { get; set; }


        // Constructeur
        public Maison()
        {

        }
        public Maison(string unNom, double uneValeur, string uneAdresse, double uneSurface, int unNbrPiece, int unNbrChambre, int unNbrCave, int unNbrParking)
            : base(unNom, uneValeur, uneAdresse, uneSurface, unNbrPiece, unNbrChambre, unNbrCave, unNbrParking)
        {

        }
    }
}
