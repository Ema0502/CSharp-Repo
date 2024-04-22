using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyC
{
    public class JuntarNombres : INotifyPropertyChanged
    {
        private string _Nombre, _Apellido, _Nombre_Completo;

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string property)
        {
        //si la propiedad es diferente de null se devuelve el objeto
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public string Nombre
        {
            get => Nombre;
            set 
            { 
                _Nombre = value; 
                OnPropertyChanged("_Nombre_Completo");
            }
        }
        public string Apellido
        {
            get => _Apellido;
            set
            {
                _Apellido = value;
                OnPropertyChanged("_Nombre_Completo");
            }
        }
        public string Nombre_Apellido
        {
            get => _Nombre_Completo = _Nombre + " " + _Apellido;
            set { }
        }
    }
}
