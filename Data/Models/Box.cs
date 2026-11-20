using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Box : Bien
    {
        // Attributs
        public int BoxId { get; set; }


        // Constructeur
        public Box()
        {

        }
        public Box(string unNom, double uneValeur, string uneAdresse, double uneSurface)
            : base(unNom, uneValeur, uneAdresse, uneSurface)
        {

        }
    }
}
