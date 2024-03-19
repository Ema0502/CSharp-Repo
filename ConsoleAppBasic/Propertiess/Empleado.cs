using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertiess
{
    internal class Empleado
    {
        private string _name;
        private double _salary;
        public Empleado(string name) {
            this._name = name;
        }

        private double testSalary(double salary)
        {
            if (this._salary < 0) return 0;
            else return salary;
        }

        //PROPERTY CREATE

        public double SALARY
        {
            get => this._salary;
            set => this._salary = testSalary(value);
        }

    }
}
