using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMENPARCIAL1ERO
{
    class Cuenta_bancaria
    {

        public int NumCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public string TitularCuenta { get; set; }
        public int Cedulal { get; set; }
        public string correo { get; set; }
        public string pantalla()
        {
            return "\n Su numero de cuenta es:" + this.NumCuenta + "\n Titula Cuenta:" + this.TitularCuenta + "\n Tipo de Cuenta:" + this.TipoCuenta + "\n  Cedula del titualr es:" + this.Cedulal + "Correo personal del titular:" + this.correo;
        }

    }

}
