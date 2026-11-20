using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Pret
    {
        // Attributs
        public int PretId { get; set; }
        public double Apport { get; set; }
        public double Montant { get; set; }
        public double TauxInteret { get; set; }
        public int Duree { get; set; }
        public DateTime DateDebut { get; set; }


        // Relations
        public Bien Bien { get; set; }


        // Constructeur
        public Pret()
        {

        }
        public Pret(double unApport, double unMontant, double unTauxInteret, int uneDuree, DateTime uneDateDebut)
        {
            this.Apport = unApport;
            this.Montant = unMontant;
            this.TauxInteret = unTauxInteret;
            this.Duree = uneDuree;
            this.DateDebut = uneDateDebut;
        }

        public Pret(double unApport, double unMontant, double unTauxInteret, int uneDuree, DateTime uneDateDebut, Bien unBien)
        {
            this.Apport = unApport;
            this.Montant = unMontant;
            this.TauxInteret = unTauxInteret;
            this.Duree = uneDuree;
            this.DateDebut = uneDateDebut;
            this.Bien = unBien;
        }


        // Methodes
        public double calculerMensualite()
        {
            double mensualite = 0;

            if (this.TauxInteret == 0)
            {
                mensualite = this.Montant / this.Duree;
            }
            else
            {
                mensualite = (this.Montant * (this.TauxInteret / 100 / 12)) / (1 - Math.Pow(1 + (this.TauxInteret / 100 / 12), -this.Duree));
            }

            return mensualite;
        }

        public int moisRestant()
        {
            int nbrMoisEcoules = (DateTime.Now.Year - DateDebut.Year) * 12 + DateTime.Now.Month - DateDebut.Month;
            int moisRestants = this.Duree - nbrMoisEcoules;

            return moisRestants;
        }

        public double montantRestant()
        {
            double restant = calculerMensualite() * moisRestant();
            return restant;
        }

        // Affichage
        public override string ToString()
        {
            return "Apport : " + this.Apport + " euros\n" + "Mensualité : " + calculerMensualite() + " euros\n" + "Durée : " + this.Duree + " mois\n" + "Date de début : " + this.DateDebut.ToShortDateString() + "\n" + "Montant restant : " + montantRestant() + " euros";
        }
    }
}
