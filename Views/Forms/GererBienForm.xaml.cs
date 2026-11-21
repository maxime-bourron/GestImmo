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
            cbxAddBienForm.SelectedIndex = 0;
        }

        private void cbxAddBienForm_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxAddBienForm.SelectedIndex == 0)
            {
                this.FormFrame.Navigate(new SubViews.AddMaisonForm());
            }
            else if (cbxAddBienForm.SelectedIndex == 1)
            {
                this.FormFrame.Navigate(new SubViews.AddAppartementForm());
            }
            else if (cbxAddBienForm.SelectedIndex == 2)
            {
                this.FormFrame.Navigate(new SubViews.AddBoxForm());
            }
        }
    }
}
