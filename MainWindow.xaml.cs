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

namespace zjeMY
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int cena = 0;
        public int kosztDostawy = 0;
        public int cenaZDostawą;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {
            cena += 34;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Burger_Click(object sender, RoutedEventArgs e)
        {
            cena += 40;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Barszcz_Click(object sender, RoutedEventArgs e)
        {
            cena += 15;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Spaghetti_Click(object sender, RoutedEventArgs e)
        {
            cena += 38;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            cena += 8;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Woda_Click(object sender, RoutedEventArgs e)
        {
            cena += 6;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Lipton_Click(object sender, RoutedEventArgs e)
        {
            cena += 8;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Fanta_Click(object sender, RoutedEventArgs e)
        {
            cena += 8;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
        private void Zamow_Click(object sender, RoutedEventArgs e)
        {
            if(cena == 0 || cena== kosztDostawy)
            {
                MessageBox.Show("Musisz dodać jakiś produkt do zamówienia");
            }
            else
            {
                sumatxtBlock.Text = "Dziękujemy za złożenia zamówienia o wartości " + cena + " ZŁ";
            }
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            cena = 0;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }

        private void dostawaRadio_Checked(object sender, RoutedEventArgs e)
        {
            kosztDostawy = 15;
            cena += kosztDostawy;
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }

        private void odbiorRadio_Checked(object sender, RoutedEventArgs e)
        {
            if(kosztDostawy == 15)
            {
                cena -= kosztDostawy;
                kosztDostawy = 0;
                if (cena < 0)
                {
                    cena = 0;
                }
            }
            sumatxtBlock.Text = "Suma: " + cena + " ZŁ";
        }
    }
}