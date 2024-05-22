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
using System.Configuration;

namespace CrudLinq
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            //conexion con origen de datos
            string miConexion = ConfigurationManager.ConnectionStrings["CrudLinq.Properties.Settings.CrudLinqSql"].ConnectionString;
            //data context, mapea la BBDD y obtiene una representacion de objetos de la db
            dataContext = new DataClasses1DataContext(miConexion);

            //InsertaEmpresas();
            //InsertaEmpleados();
            //InsertaCargos();
            //InsertaEmpleadoCargo();
            //ActualizaEmpleado();
            EliminaEmpleado();
        }
        public void InsertaEmpresas()
        {
            //elimina todo en la db para cada prueba
            dataContext.ExecuteCommand("delete from Empresa");

            Empresa empresaGoogle = new Empresa();
            empresaGoogle.Nombre = "Google";
            dataContext.Empresa.InsertOnSubmit(empresaGoogle);

            Empresa empresaTesla = new Empresa();
            empresaTesla.Nombre = "Tesla";
            dataContext.Empresa.InsertOnSubmit(empresaTesla);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empresa;
        }

        public void InsertaEmpleados()
        {
            Empresa empresaGoogle = dataContext.Empresa.First((empresa) => empresa.Nombre.Equals("Google"));
            Empresa empresaTesla = dataContext.Empresa.First((empresa) => empresa.Nombre.Equals("Tesla"));

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(new Empleado { Nombre = "Lio", Apellido = "Messi", EmpresaId = empresaGoogle.Id});
            listaEmpleados.Add(new Empleado { Nombre = "Eden", Apellido = "Hazard", EmpresaId = empresaTesla.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Isao", Apellido = "Machi", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "Diaz", EmpresaId = empresaTesla.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Wei", Apellido = "Ying", EmpresaId = empresaGoogle.Id });
            listaEmpleados.Add(new Empleado { Nombre = "Maria", Apellido = "Lopez", EmpresaId = empresaTesla.Id });

            dataContext.Empleado.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();

            Principal.ItemsSource = dataContext.Empleado;
        }

        public void InsertaCargos()
        {
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Director/a"});
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Gerente" });
            dataContext.Cargo.InsertOnSubmit(new Cargo { NombreCargo = "Administrativo/a" });
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Cargo;
        }

        public void InsertaEmpleadoCargo()
        {
            
            List<CargoEmpleado> listaCargoEmpleados = new List<CargoEmpleado>();
            //se crean los empleados y se asignan los cargos
            listaCargoEmpleados.Add( new CargoEmpleado { 
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Lio")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Director/a"))
            });

            listaCargoEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Eden")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Gerente"))
            });

            listaCargoEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Isao")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Administrativo/a"))
            });

            listaCargoEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Ana")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Administrativo/a"))
            });

            listaCargoEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Wei")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Administrativo/a"))
            });

            listaCargoEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Maria")),
                Cargo = dataContext.Cargo.First((cargo) => cargo.NombreCargo.Equals("Administrativo/a"))
            });

            dataContext.CargoEmpleado.InsertAllOnSubmit(listaCargoEmpleados);

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.CargoEmpleado;
        }

        public void ActualizaEmpleado()
        {
            //ejemplo para actualizar informacion de registro
            Empleado lionelMessi = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Lio"));
            lionelMessi.Nombre = "Lionel Andres";
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }

        public void EliminaEmpleado()
        {
            Empleado empleadoEliminar = dataContext.Empleado.First((empleado) => empleado.Nombre.Equals("Ana"));
            dataContext.Empleado.DeleteOnSubmit(empleadoEliminar);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleado;
        }
    }
}
