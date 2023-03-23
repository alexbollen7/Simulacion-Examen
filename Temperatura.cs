using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_Examen
{
    class Temperatura
    {
        int idenDep;
        double temp;
        DateTime fecha;

        public int IdenDep { get => idenDep; set => idenDep = value; }
        public double Temp { get => temp; set => temp = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
