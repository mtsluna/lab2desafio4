using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio4.model
{
    abstract class Inmueble
    {

        public String direccion { get; internal set; }
        public int m2 { get; internal set; }
        public bool esNuevo { get; internal set; }
        public int precioBase { get; internal set; }

        public Inmueble()
        {

        }

        public abstract double calcularPrecio();

    }
}
