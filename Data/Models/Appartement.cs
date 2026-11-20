using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Appartement : Habitable
    {
        // Attributs 
        public int AppartementId { get; set; }
        public int Etage { get; set; }
        public string Ascenseur { get; set; }
        public string ChauffageCommun { get; set; }


        // Constructeur
        public Appartement()
        {

        }
        public Appartement(string unNom, double uneValeur, string uneAdresse, double uneSurface, int unNbrPiece, int unNbrChambre, int unNbrCave, int unNbrParking, int unEtage, string unAscenseur, string unChauffageCommun)
            : base(unNom, uneValeur, uneAdresse, uneSurface, unNbrPiece, unNbrChambre, unNbrCave, unNbrParking)
        {
            this.Etage = unEtage;
            this.Ascenseur = unAscenseur;
            this.ChauffageCommun = unChauffageCommun;
        }


        // Methodes
        // Affichage
        protected override string EnTete()
        {
            return base.EnTete() + "\n" + "Numéro étage : " + this.Etage + "\n" + "Assenceur : " + this.Ascenseur + "\n" + "Chauffage commun : " + this.ChauffageCommun;
        }

        public override double EstimationBien()
        {
            double prixEstime = 0;

            if (this.ChauffageCommun == "Oui")
            {
                prixEstime += 6500;
            }

            if (this.Ascenseur == "Oui")
            {
                prixEstime += 5000;
            }

            if (this.Etage == 0)
            {
                prixEstime -= 3000;
            }

            return base.EstimationBien() + prixEstime;
        }
    }
}
