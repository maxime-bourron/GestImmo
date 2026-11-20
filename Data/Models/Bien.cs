using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Bien
    {
        // Attributs
        public int BienId { get; set; }
        public string Nom { get; set; }
        public double Valeur { get; set; }
        public string Adresse { get; set; }
        public double Surface { get; set; }


        // Relations
        public List<Pret?> Prets { get; set; }
        public List<Bail?> Baux { get; set; }
        public List<Intervention?> Interventions { get; set; }


        // Constructeur
        public Bien()
        {

        }
        public Bien(string unNom, double uneValeur, string uneAdresse, double uneSurface)
        {
            this.Nom = unNom;
            this.Valeur = uneValeur;
            this.Adresse = uneAdresse;
            this.Surface = uneSurface;
            this.Prets = new List<Pret?>();
            this.Baux = new List<Bail?>();
            this.Interventions = new List<Intervention?>();
        }


        // Methodes
        public void ajouterPret(Pret unPret)
        {
            this.Prets.Add(unPret);
        }

        public void ajouterBail(Bail unBail)
        {
            this.Baux.Add(unBail);
        }

        public void ajouterIntervention(Intervention uneIntervention)
        {
            this.Interventions.Add(uneIntervention);
        }

        public double calculerRentabiliteNetMensuel()
        {
            double benefice = 0;

            foreach (Pret pret in this.Prets)
            {
                if (pret.moisRestant() > 0)
                {
                    benefice -= pret.calculerMensualite();
                }
            }

            foreach (Bail bail in this.Baux)
            {
                if (bail.DateFin == null)
                {
                    benefice += bail.Loyer;
                }
            }

            foreach (Intervention intervention in this.Interventions)
            {
                if (intervention.DateIntervention.Year == DateTime.Now.Year && intervention.DateIntervention.Month == DateTime.Now.Month)
                {
                    benefice -= intervention.MontantIntervention;
                }
            }

            return benefice;
        }

        // Affichage
        public override string ToString()
        {
            string resultat = EnTete();

            if (Prets.Count > 0)
            {
                resultat += "\n======= Prets =======";
                foreach (Pret pret in Prets)
                {
                    resultat += "\n" + pret;
                }
            }
            if (Baux.Count > 0)
            {
                resultat += "\n======= Baux =======";
                foreach (Bail bail in Baux)
                {
                    resultat += "\n" + bail;
                }
            }
            if (Interventions.Count > 0)
            {
                resultat += "\n======= Interventions =======";
                foreach (Intervention intervention in Interventions)
                {
                    resultat += "\n" + intervention;
                }
            }

            return resultat;
        }

        protected virtual string EnTete()
        {
            return "==================== " + this.Nom + " ====================\n" + "Adresse : " + this.Adresse + "\n" + "Valeur : " + this.Valeur + " euros\n" + "Surface : " + this.Surface + " m²\n" + "Bénéfice : " + calculerRentabiliteNetMensuel() + " euros";
        }

        public virtual double EstimationBien()
        {
            double prixEstime = 0;
            prixEstime = this.Surface * 1400;

            return prixEstime;
        }
    }
}
