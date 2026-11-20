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

namespace GestImmo.Views
{
    /// <summary>
    /// Logique d'interaction pour NavigationView.xaml
    /// </summary>
    public partial class NavigationView : Page
    {
        public NavigationView()
        {
            InitializeComponent();
            this.MainFrame.Navigate(new HomeView());
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new HomeView());
        }

        private void btnBien_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new BienView());
        }

        private void btnIntervention_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new InterventionView());
        }

        private void btnPret_Click(object sender, RoutedEventArgs e)
        {
            this.MainFrame.Navigate(new PretView());
        }
    }
}
