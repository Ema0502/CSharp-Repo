using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_con_Objetos
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Gugul" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Pildoras Informaticas" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "Soy Henry" });

            listaEmpleados.Add(new Empleado { 
                Id = 1,
                Nombre = "Sergio Gomez",
                Genero = "Masculino",
                Cargo = "CEO",
                EmpesaId = 1,
                Salario = 15332.54
            });
            listaEmpleados.Add(new Empleado
            {
                Id = 2,
                Nombre = "Lionel Messi",
                Genero = "Masculino",
                Cargo = "Supremo",
                EmpesaId = 3,
                Salario = 15003132.59
            });
            listaEmpleados.Add(new Empleado
            {
                Id = 3,
                Nombre = "Eden Hazard",
                Genero = "Masculino",
                Cargo = "Co-CEO",
                EmpesaId = 1,
                Salario = 1003138.21
            });
            listaEmpleados.Add(new Empleado
            {
                Id = 4,
                Nombre = "Irina Shayk",
                Genero = "Femenino",
                Cargo = "Co-CEO",
                EmpesaId = 2,
                Salario = 2013183.17
            });
        }

        public void ObtenerCargoCEO()
        {
            IEnumerable<Empleado> empleadosCEO = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleado in empleadosCEO)
            {
                empleado.ObtenerDatosEmpleado();
            }
        }

        public void ObtenerGeneroMasculino()
        {
            IEnumerable<Empleado> empleadosMasculinos = from empleado in listaEmpleados where empleado.Genero == "Masculino" select empleado;

            foreach (Empleado empleado in empleadosMasculinos)
            {
                empleado.ObtenerDatosEmpleado();
            }
        }

        public void ObtenerGeneroFemenino()
        {
            IEnumerable<Empleado> empleadosFemeninos = from empleado in listaEmpleados where empleado.Genero == "Femenino" select empleado;

            foreach (Empleado empleado in empleadosFemeninos)
            {
                empleado.ObtenerDatosEmpleado();
            }
        }

        public void ObtenerSupremo()
        {
            IEnumerable<Empleado> empleadoSupremo = from empleado in listaEmpleados where empleado.Salario > 10000000 select empleado;

            foreach(Empleado empleadoSupremoF in empleadoSupremo)
            {
                empleadoSupremoF.ObtenerDatosEmpleado();
            }
        }

        public void OrdenarEmpleados()
        {
            IEnumerable<Empleado> listaEmpleadosOrdenados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado empleado in listaEmpleadosOrdenados)
            {
                empleado.ObtenerDatosEmpleado();
            } 
        }

        public void ObtenerEmpleadosId(int id)
        {
            try
            {
                IEnumerable<Empleado> listaEmpleadosGugul = from empleado in listaEmpleados
                                                            join empresa in listaEmpresas
                                                            on empleado.EmpesaId equals empresa.Id //equivalencia en la busqueda, fk = id empresa
                                                            where empresa.Id == id
                                                            select empleado;

                foreach (Empleado empleado1 in listaEmpleadosGugul)
                {
                    empleado1.ObtenerDatosEmpleado();
                }
            } catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}
