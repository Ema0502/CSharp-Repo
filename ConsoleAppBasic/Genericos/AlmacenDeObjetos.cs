using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class AlmacenDeObjetos<T>
    {
        private T[] datosElementos;
        private int i = 0;
        public AlmacenDeObjetos(int z)
        {
            datosElementos = new T[z];
        }

        public void Agregar(T obj)
        {
            datosElementos[i] = obj;
            i++;
        }

        public T getElementos(int i)
        {
            return datosElementos[i];
        }
    }
}
