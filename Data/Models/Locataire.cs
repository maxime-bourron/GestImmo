using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Locataire
    {
        // Attributs
        public int LocataireId { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Profession { get; set; }


        // Relations
        public Bail? Location { get; set; }


        // Constructeur
        public Locataire()
        {

        }
        public Locataire(string unNom, string unPrenom, int unAge, string uneProfession, Bail uneLocation)
        {
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Age = unAge;
            this.Profession = uneProfession;
            this.Location = uneLocation;
        }


        // Methodes
        // Affichage
        public override string ToString()
        {
            return "    Nom : " + this.Nom + " " + this.Prenom + "\n" + "    Age : " + this.Age + "\n" + "    Profession : " + this.Profession;
        }
    }
}
