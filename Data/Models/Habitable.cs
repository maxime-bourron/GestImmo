using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Habitable : Bien
    {
        // Attributs
        public int HabitableId { get; set; }
        public int NbrPiece { get; set; }
        public int NbrChambre { get; set; }
        public int NbrCave { get; set; }
        public int NbrParking { get; set; }


        // Constructeur
        public Habitable()
        {

        }
        public Habitable(string unNom, double uneValeur, string uneAdresse, double uneSurface, int unNbrPiece, int unNbrChambre, int unNbrCave, int unNbrParking)
            : base(unNom, uneValeur, uneAdresse, uneSurface)
        {
            this.NbrPiece = unNbrPiece;
            this.NbrChambre = unNbrChambre;
            this.NbrCave = unNbrCave;
            this.NbrParking = unNbrParking;
        }


        // Methodes
        // Affichage
        protected override string EnTete()
        {
            return base.EnTete() + "\n" + "Nombre pièces : " + this.NbrPiece + "\n" + "Nombre chambres : " + this.NbrChambre + "\n" + "Nombre caves : " + this.NbrCave + "\n" + "Nombre parking : " + this.NbrParking;
        }

        public override double EstimationBien()
        {
            double prixEstime = 0;

            if (this.NbrCave > 0)
            {
                prixEstime += 5000;
            }

            if (this.NbrParking > 0)
            {
                prixEstime += 8000;
            }

            prixEstime += this.NbrPiece * 2000;

            return base.EstimationBien() + prixEstime;
        }
    }
}
