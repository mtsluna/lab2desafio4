using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio4.model
{
    class LocalComercial : Inmueble
    {

        public LocalComercial() : base() 
        {

        }

        public int cantVentas { get; internal set; }

        public override double calcularPrecio()
        {
            double antiguedad = (esNuevo == true) ? -(precioBase * 1 / 100) : -(precioBase * 2 / 100);
            double ventanas = (cantVentas <= 1) ? -(precioBase * 1 / 100) : (cantVentas > 4) ? (precioBase * 2 / 100) : 0;
            double metros = (m2 > 50) ? precioBase * 1 / 100 : 0;
            return precioBase + antiguedad + ventanas + metros;
        }
    }
}
