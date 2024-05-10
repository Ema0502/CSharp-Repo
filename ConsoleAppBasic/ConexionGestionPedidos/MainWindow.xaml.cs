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
using System.Data.Common;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConexion;
        public MainWindow()
        {
            InitializeComponent();

            //cadena de conexion, para conectar con el origen de datos
            string myConnection = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            //consultas sql directas
            //SELECT * FROM cliente
            //SELECT * FROM cliente INNER JOIN pedido ON cliente.Id = pedido.codCliente WHERE poblacion='BARCELONA';

            // se crea y se instancia la clase, se aclara que se haran consultas a la base de datos
            sqlConexion = new SqlConnection(myConnection);
            muestraClientes();
        }

        private void muestraClientes()
        {
            string consultas = "SELECT * FROM CLIENTE";
            //adapta la informarcion de la db a C#
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consultas, sqlConexion);

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();

                miAdaptadorSql.Fill(clientesTabla);
                //campo por mostrar en listbox
                listaClientes.DisplayMemberPath = "nombre";
                //campo clave
                listaClientes.SelectedValuePath = "id";
                //aclarar origen de datos
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }
    }
}
