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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxCheckBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid"});
            ListaCapitales.Add(new Capitales { NombreCapital = "Df" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogota" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });

            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodasC_Checked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = true;
            Lima.IsChecked = true;
            Df.IsChecked = true;
            Santiago.IsChecked = true;
            Bogota.IsChecked = true;
        }

        private void TodasC_Unchecked(object sender, RoutedEventArgs e)
        {
            Madrid.IsChecked = false;
            Lima.IsChecked = false;
            Df.IsChecked = false;
            Santiago.IsChecked = false;
            Bogota.IsChecked = false;
        }

        private void Individual_Checked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == true && Lima.IsChecked == true && Df.IsChecked == true && Santiago.IsChecked == true && Bogota.IsChecked == true)
            {
                TodasC.IsChecked = true;
            }
            else TodasC.IsChecked = null;
        }

        private void Individual_NoChecked(object sender, RoutedEventArgs e)
        {
            if (Madrid.IsChecked == false && Lima.IsChecked == false && Df.IsChecked == false && Santiago.IsChecked == false && Bogota.IsChecked == false)
            {
                TodasC.IsChecked = false;
            }
            else TodasC.IsChecked = null;
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
