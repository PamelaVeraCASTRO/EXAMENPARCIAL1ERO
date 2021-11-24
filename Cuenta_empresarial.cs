using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPARCIAL1ERO
{

    class Cuenta_empresarial : Cuenta__joven
    {
        public double ProcesoT()
        {
            double resultadoF;
            if (this.Saldo_C >= 1000)
            {
                Console.WriteLine("Su valor de Prcentaje es de 10%");
                resultadoF = this.Saldo_C * 10 / 100;
            }
            else
            {
                Console.WriteLine("Su valor de Porcentaje es de 5%");
                resultadoF = this.Saldo_C * 5 / 100;
            }
            return resultadoF;
        }
    }
}
