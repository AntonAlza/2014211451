using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014214451
{
    public class Propietario
    {
        string DNI { get; set; }
        string Nombre { get; set; }
        string Apellidos { get; set; }
        string LicenciaConducir { get; set; }

        public Propietario()
        {
        }

        public Propietario(string _DNI,string _Nombre, string _Apellido, string _LicenciaConducir)
        {
            DNI = _DNI;
            Nombre = _Nombre;
            Apellidos = _Apellido;
            LicenciaConducir = _LicenciaConducir;
        }

    }
}
