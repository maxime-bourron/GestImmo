using System;
using System.Collections.Generic;
using System.Text;

namespace GestImmo.Data.Models
{
    internal class Prestataire
    {
        // Attributs
        public int PrestataireId { get; set; }
        public string RaisonSocial { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }


        // Relations
        public List<Intervention?> Interventions { get; set; }


        // Constructeur
        public Prestataire()
        {

        }
        public Prestataire(string uneRaisonSocial, string unNom, string unPrenom, string unTelephone, string uneAdresse)
        {
            this.RaisonSocial = uneRaisonSocial;
            this.Nom = unNom;
            this.Prenom = unPrenom;
            this.Telephone = unTelephone;
            this.Adresse = uneAdresse;
            this.Interventions = new List<Intervention?>();
        }


        // Methodes
        public void ajouterIntervention(Intervention uneIntervention)
        {
            this.Interventions.Add(uneIntervention);
        }

        // Affichage
        public override string ToString()
        {
            return "    " + this.RaisonSocial + "\n" + "    " + this.Nom + "\n" + "    " + this.Prenom + "\n" + "    " + this.Telephone + "\n" + "    " + this.Adresse;
        }
    }
}
