using Magazin.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Magazin
{
    /// <summary>
    /// Interaction logic for AdaugaProdus.xaml
    /// </summary>
    public partial class AdaugaProdus : Window
    {

        private readonly ProdusManager produsManager;
        public AdaugaProdus()
        {
            InitializeComponent();

            produsManager = new ProdusManager();
        }
        private void BtnSalveaza_Click(object sender, RoutedEventArgs e)
        {
            Produs produs = new Produs
            {
                Denumire = txtDenumire.Text,
                DataProducției = dpDataProducției.SelectedDate ?? DateTime.Now,
                TermenValabilitate = dpTermenValabilitate.SelectedDate ?? DateTime.Now,
                Pret = double.Parse(txtPret.Text)
            };
            produsManager.AdaugaProdus(produs);
            Close();
        }

        private void BtnAnuleaza_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
