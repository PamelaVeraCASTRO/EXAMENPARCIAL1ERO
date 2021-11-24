using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPARCIAL1ERO
{
    class Cuenta_tienda : Cuenta__joven
    {
        public double Nivel_Tienda { get; set; }
        public double ProcesosT1()
        {
            double resultadoF = 0;
            switch (this.Nivel_Tienda)
            {
                case 1:
                    Console.WriteLine("Su porcentaje ganado sera de 5%");
                    resultadoF = this.Saldo_C * 5 / 100;

                    break;
                case 2:
                    Console.WriteLine("Su porcentaje Ganado ser adel 10%");
                    resultadoF = this.Saldo_C * 10 / 100;
                    break;
                case 3:

                    Console.WriteLine("Su porcentaje es de 15%");
                    resultadoF = this.Saldo_C * 15 / 100;
                    break;
            }
            return resultadoF;
        }
    }
}
