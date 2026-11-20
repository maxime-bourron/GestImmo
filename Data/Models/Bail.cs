using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Bail
    {
        // Attributs
        public int BailId { get; set; }
        public double Loyer { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime? DateFin { get; set; }


        // Relations
        public Bien Bien { get; set; }
        public List<Locataire> Locataires { get; set; }


        // Constructeur
        public Bail()
        {

        }
        public Bail(double unLoyer, DateTime uneDateDebut, DateTime? uneDateFin, Bien unBien)
        {
            this.Loyer = unLoyer;
            this.DateDebut = uneDateDebut;
            this.DateFin = uneDateFin;
            this.Bien = unBien;
            this.Locataires = new List<Locataire>();
        }


        // Methodes
        public void ajouterLocataire(Locataire unLocataire)
        {
            this.Locataires.Add(unLocataire);
        }

        // Affichage
        public override string ToString()
        {
            string resultat = "Loyer : " + this.Loyer + " euros\n" + "Date de début : " + this.DateDebut.ToShortDateString() + "\n" + "Date de fin : " + (this.DateFin.HasValue ? this.DateFin.Value.ToShortDateString() : "En cours") + "\n" + "Locataires : ";

            foreach (Locataire locataire in Locataires)
            {
                resultat += "\n" + locataire;
            }

            return resultat;
        }
    }
}
