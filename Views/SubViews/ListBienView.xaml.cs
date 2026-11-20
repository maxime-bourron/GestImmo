using GestImmo.Data.DAL;
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

namespace GestImmo.Views.SubViews
{
    /// <summary>
    /// Logique d'interaction pour ListBienView.xaml
    /// </summary>
    public partial class ListBienView : Page
    {
        public ListBienView()
        {
            InitializeComponent();
            AddBiens();
        }


        private void lstBiens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    
        public void AddBiens()
        {
            GestImmoContext ctx = new GestImmoContext();
            foreach (Data.Models.Bien bien in ctx.Biens)
            {
                this.lstBiens.Items.Add(bien);
            }
        }
    }
}
