using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Intervention
    {
        // Attributs
        public int InterventionId { get; set; }
        public DateTime DateIntervention { get; set; }
        public double MontantIntervention { get; set; }
        public string Description { get; set; }


        // Relations
        public Bien Bien { get; set; }
        public Prestataire Prestataire { get; set; }


        // Constructeur
        public Intervention()
        {

        }
        public Intervention(DateTime uneDateIntervention, double unMontantIntervention, string uneDescription, Bien unBien, Prestataire unPrestataire)
        {
            this.DateIntervention = uneDateIntervention;
            this.MontantIntervention = unMontantIntervention;
            this.Description = uneDescription;
            this.Bien = unBien;
            this.Prestataire = unPrestataire;
        }


        // Methodes
        // Affichage
        public override string ToString()
        {
            return "Date : " + this.DateIntervention.ToShortDateString() + "\n" + "Montant : " + this.MontantIntervention + " euros\n" + "Description : " + this.Description + "\n" + "Prestataire : \n" + this.Prestataire;
        }
    }
}
