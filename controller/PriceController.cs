using desafio4.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio4.controller
{
    class PriceController
    {

        public void calculatePrice(Form1 form)
        {
            if(form.piso.Checked == true)
            {
                Piso piso = new Piso();
                piso.direccion = form.direccion.Text;
                piso.m2 = Int16.Parse(form.m.Text.ToString());
                if(form.nuevo.Checked == true)
                {
                    piso.esNuevo = true;
                }
                else
                {
                    piso.esNuevo = false;
                }
                piso.numeroDePiso = Int16.Parse(form.numeroPiso.Text);
                piso.precioBase = Int16.Parse(form.basePrice.Text);
                form.price.Text = "$" + piso.calcularPrecio();
            }
            else
            {
                LocalComercial local = new LocalComercial();
                local.direccion = form.direccion.Text;
                local.m2 = Int16.Parse(form.m.Text);
                if (form.nuevo.Checked == true)
                {
                    local.esNuevo = true;
                }
                else
                {
                    local.esNuevo = false;
                }
                local.cantVentas = Int16.Parse(form.cantVentas.Text);
                local.precioBase = Int16.Parse(form.basePrice.Text);
                form.price.Text = "$" + local.calcularPrecio();
            }
        }

    }
}
