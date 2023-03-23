using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_Examen
{
    class RegistroTemp
    {
        string nombreDep;
        double temp;
        DateTime fecha;

        public string NombreDep { get => nombreDep; set => nombreDep = value; }
        public double Temp { get => temp; set => temp = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
