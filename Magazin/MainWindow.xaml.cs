using Magazin.Classes;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
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

namespace Magazin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MagazinDbContext dbContext;
        private ObservableCollection<Produs> produse;
        public MainWindow()
        {
            InitializeComponent();
            dbContext = new MagazinDbContext();
            dbContext.CreateProdusTable();
            produse = new ObservableCollection<Produs>(dbContext.Produse);
            dgProduse.ItemsSource = produse;
        }
        private void AdaugaProdusCommand_Executed(object sender, RoutedEventArgs e)
        {
            AdaugaProdus adaugaProdusWindow = new AdaugaProdus();
            adaugaProdusWindow.ShowDialog();
            produse.Clear();
            foreach (var produs in dbContext.Produse)
            {
                produse.Add(produs);
            }
        }

        private void btnAdaugaProdus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}