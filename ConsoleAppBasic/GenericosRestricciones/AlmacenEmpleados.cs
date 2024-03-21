using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleado;

        public AlmacenEmpleados(int z)
        {
            datosEmpleado = new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleado[i] = obj;
            i++;
        }

        public T GetEmpleado(int i)
        {
            return datosEmpleado[i];
        }
    }
}
