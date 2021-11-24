using System;
using System.Collections.Generic;

namespace EXAMENPARCIAL1ERO
{
    class Program

    {
        static void Main(string[] args)

        {
            // Encabezado del banco 
            Console.WriteLine("\t\t\t\t************************************************************");
            Console.WriteLine("\t\t\t\t************BIENVENIDO AL BANCO DEL PACIFICO***************");
            Console.WriteLine("");
            Cuenta_bancaria dato = new Cuenta_bancaria();
            Console.WriteLine("POR FAVOR INGRESE SU NUMERO DE CUENTA ");
            int cuenta = int.Parse(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE SU NUMERO DE CEDULA ");
            int cedulal = int.Parse(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE SU CORREO");
            string correop = Console.ReadLine();
            dato.NumCuenta = cuenta;
            dato.Cedulal = cedulal;
            dato.correo = correop;
            string tipoC = "";
            Console.WriteLine("Por Favor dijite su numero de cuenta:");
            Console.WriteLine("0.Ahorro  \t\t  1.Bancaria");
            int Dijito = int.Parse(Console.ReadLine());
            switch (Dijito)
            {
                case 0:
                    tipoC = "AHORRO";
                    break;

                case 1:
                    tipoC = "BANCARIA";
                    break;
            }
            dato.TipoCuenta = tipoC;

            Console.WriteLine("POR FAVOR INGRESE EL TITULAR DE LA CUENTA");
            string nombre = Console.ReadLine();
            dato.TitularCuenta = nombre;
            Console.WriteLine(dato.pantalla());

            Cuenta__joven proceso = new Cuenta__joven();
            Console.WriteLine("Ingres esu saldo de cuenta");
            float saldo = float.Parse(Console.ReadLine());
            proceso.Saldo_C = saldo;
            Console.WriteLine("SU PORCENTAJE DE INTERES EN EL BANCO DEL PACIFICO ES DE 25%");
            proceso.Porcentaje_Interes = 0.25;
            Console.WriteLine("El interes con su respectivo valor es de:" + proceso.ProcesoT());

            Cuenta_tienda proceso2 = new Cuenta_tienda();
            Console.WriteLine("Dijite el saldo de su cuenta:");
            double valor1 = double.Parse(Console.ReadLine());
            proceso2.Saldo_C = valor1;
            Console.WriteLine("Ingrese el nivel de tienda 1- 3:");
            double val = double.Parse(Console.ReadLine());
            proceso2.Nivel_Tienda = val;
            Console.WriteLine("Su valor ganado es:" + proceso2.ProcesosT1());

            Cuenta_empresarial proceso3 = new Cuenta_empresarial();
            Console.WriteLine("Dijite el saldo de su cuenta:");
            double valor2 = double.Parse(Console.ReadLine());
            proceso3.Saldo_C = valor2;
            Console.WriteLine("Su valor ganado es:" + proceso3.ProcesoT());

            // Lista  
            List<Cuenta__joven> Calcular = new List<Cuenta__joven>();
            Calcular.Add(proceso2);
            foreach (Cuenta__joven item in Calcular)
            {
                Console.WriteLine(item.Porcentaje_Interes);
            }

        }

    }
}
