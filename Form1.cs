using desafio4.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desafio4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calcular.Enabled = checkValidForm();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcular.Enabled = checkValidForm();
        }

        private void keyPressIsNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calcular.Enabled = checkValidForm();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calcular.Enabled = checkValidForm();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calcular.Enabled = checkValidForm();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            cantVentas.Enabled = false;
            numeroPiso.Enabled = true;
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            PriceController priceController = new PriceController();
            priceController.calculatePrice(this);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            numeroPiso.Enabled = false;
            cantVentas.Enabled = true;
        }

        private bool checkValidForm()
        {
            if(!direccion.Text.Equals("") && !m.Text.Equals("") && !basePrice.Text.Equals("") && (!cantVentas.Text.Equals("") || !numeroPiso.Text.Equals("")))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
