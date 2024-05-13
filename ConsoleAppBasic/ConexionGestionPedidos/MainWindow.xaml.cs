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
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();

            //cadena de conexion, para conectar con el origen de datos
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            //SELECT * FROM cliente
            //SELECT * FROM cliente INNER JOIN pedido ON cliente.Id = pedido.codCliente WHERE poblacion='BARCELONA';

            //hara consultas a la base de datos
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
            //adapta la informarcion de la db a C#
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();

                miAdaptadorSql.Fill(clientesTabla);
                //campo por mostrar en listbox
                listaClientes.DisplayMemberPath = "nombre";
                //campo clave
                listaClientes.SelectedValuePath = "Id";
                //aclarar origen de datos
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }

        private void MuestraPedidos()
        {
            string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.codCliente" + 
                " WHERE C.ID=@ClienteId";

            SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);

                DataTable pedidosTabla = new DataTable();

                miAdaptadorSql.Fill(pedidosTabla);

                pedidosCliente.DisplayMemberPath = "fechaPedido";
                pedidosCliente.SelectedValuePath = "Id";
                pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
            }
        }

        private void MuestraTodosPedidos()
        {
            //consulta de campo nuevo calculado
            string consulta = "SELECT *, CONCAT(codCliente, ' ', fechaPedido, ' ', formaPago) AS INFOCOMPLETA FROM PEDIDO";

            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable pedidosTabla = new DataTable();

                miAdaptadorSql.Fill(pedidosTabla);

                todosPedidos.DisplayMemberPath = "INFOCOMPLETA";
                todosPedidos.SelectedValuePath = "Id";
                todosPedidos.ItemsSource = pedidosTabla.DefaultView;
            }
        }


        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                MuestraPedidos();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(todosPedidos.SelectedValue.ToString());
            string consulta = "DELETE FROM PEDIDO WHERE ID = @PEDIDOID";

            SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
            miConexionSql.Open();
            //especifica el parametro y de donde viene
            miSqlCommand.Parameters.AddWithValue("@PEDIDOID", todosPedidos.SelectedValue);
            //ejecuta consulta de accion delete
            miSqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            MuestraTodosPedidos();
        }
    }
}
