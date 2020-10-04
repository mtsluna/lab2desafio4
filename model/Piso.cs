using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio4.model
{
    class Piso : Inmueble
    {

        public Piso() : base()
        {

        }

        public int numeroDePiso { get; internal set; }

        public override double calcularPrecio()
        {
            double antiguedad = (esNuevo == true) ? precioBase * 1 / 100 : precioBase * 2 / 100;
            double prefPiso = (numeroDePiso >= 3) ? precioBase * 3 / 100 : 0;
            return precioBase - antiguedad + prefPiso;
        }
    }
}
