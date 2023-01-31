using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia_Puntos2 
{
    class Calculos : Cordenadas
    {
        public double Distancia()
        {
            double resultado;
            resultado = ((Math.Pow(Xb - Xa, 2)) + (Math.Pow(Yb - Ya, 2)));
            resultado = (Math.Sqrt(resultado));
            return resultado;
        }
    }
}
