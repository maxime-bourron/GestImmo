using GestImmo.Data.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour AddMaisonForm.xaml
    /// </summary>
    public partial class AddMaisonForm : Page
    {
        public AddMaisonForm()
        {
            InitializeComponent();
        }

        private void btnAddMaison_Click(object sender, RoutedEventArgs e)
        {
            string nom = txtNom.Text;
            double valeur = double.Parse(txtValeur.Text);
            string adresse = txtAdresse.Text;
            double surface = double.Parse(txtSurface.Text);
            int nbrPiece = int.Parse(txtNbrPiece.Text);
            int nbrChambre = int.Parse(txtNbrChambre.Text);
            int nbrCave = int.Parse(txtNbrCave.Text);
            int nbrParking = int.Parse(txtNbrParking.Text);
            txtNom.Clear();
            txtValeur.Clear();
            txtAdresse.Clear();
            txtSurface.Clear();
            txtNbrPiece.Clear();
            txtNbrChambre.Clear();
            txtNbrCave.Clear();
            txtNbrParking.Clear();

            GestImmoContext ctx = new GestImmoContext();
            ctx.Biens.Add(new Data.Models.Maison(nom, valeur, adresse, surface, nbrPiece, nbrChambre, nbrCave, nbrParking));
            ctx.SaveChanges();
        }
    }
}
