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
//cadena de conexion
using System.Configuration;
// Representa una conexión a una base de datos
using System.Data.SqlClient;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //cadena de conexion, para conectar con el origen de datos
            string myConnection = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            //consultas sql directas
            //SELECT * FROM cliente
            //SELECT * FROM cliente INNER JOIN pedido ON cliente.Id = pedido.codCliente WHERE poblacion='BARCELONA';

            // se crea y se instancia la clase, se aclara que se haran consultas a la base de datos
            SqlConnection sqlConnection = new SqlConnection(myConnection);

        }

        private void showClients()
        {
            string consultas = "SELECT * FROM CLIENTE";

        }
    }
}
