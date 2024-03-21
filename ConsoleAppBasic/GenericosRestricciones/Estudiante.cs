using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosRestricciones
{
    internal class Estudiante
    {
        private double edad;

        public Estudiante(double edad)
        {
            this.edad = edad;
        }

        public double getEdad()
        {
            return this.edad;
        }
    }
}
