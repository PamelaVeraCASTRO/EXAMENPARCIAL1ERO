using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPARCIAL1ERO
{
    class Cuenta__joven
    {
        // Saldo de cuenta; porcentaje de interes
        public double Porcentaje_Interes { get; set; }
        public double Saldo_C { get; set; }
        public double ProcesoT()
        {
            double resultadoF = Saldo_C * Porcentaje_Interes / 100;
            return resultadoF;
        }
    }

}
