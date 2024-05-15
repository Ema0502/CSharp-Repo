using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para ActualizarCliente.xaml
    /// </summary>
    public partial class ActualizarCliente : Window
    {
        SqlConnection miConexionSql;
        private int numId;

        public ActualizarCliente(int parmID)
        {
            InitializeComponent();
            numId = parmID;
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string consulta = "UPDATE CLIENTE SET nombre=@nombre WHERE Id=" + numId;

                SqlCommand miSqlCommand = new SqlCommand(consulta, miConexionSql);
                miConexionSql.Open();

                miSqlCommand.Parameters.AddWithValue("@nombre", cuadroActualiza.Text);

                miSqlCommand.ExecuteNonQuery();
                miConexionSql.Close();
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
