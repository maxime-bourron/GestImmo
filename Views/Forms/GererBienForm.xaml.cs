using System;
using System.Collections.Generic;
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

namespace GestImmo.Views.Forms
{
    /// <summary>
    /// Logique d'interaction pour GererBienForm.xaml
    /// </summary>
    public partial class GererBienForm : Page
    {
        public GererBienForm()
        {
            InitializeComponent();
        }

        private void cbxAddBienForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxAddBienForm.SelectedItem is ComboBoxItem item)
            {
                string? typeBien = item.Content?.ToString();
                // Exemple : afficher ou masquer les champs selon le type de bien
            }
        }
    }
}
