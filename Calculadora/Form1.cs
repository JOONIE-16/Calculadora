using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //GLOBAL CODE
        private double resultado = 0;
        private string operacion = "";
        private bool operacionPresionada = false;

        private void btnNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if ((txtResultado.Text == "0") || operacionPresionada)
                txtResultado.Clear();

            operacionPresionada = false;
            txtResultado.Text += boton.Text;
        }

        private void btnOperacion_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if (resultado != 0)
            {
                btnIgual.PerformClick();
                operacionPresionada = true;
                operacion = boton.Text;
            }
            else
            {
                operacion = boton.Text;
                resultado = double.Parse(txtResultado.Text);
                operacionPresionada = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (operacion)
            {
                case "+":
                    txtResultado.Text = (resultado + double.Parse(txtResultado.Text)).ToString();
                    break;
                case "-":
                    txtResultado.Text = (resultado - double.Parse(txtResultado.Text)).ToString();
                    break;
                case "*":
                    txtResultado.Text = (resultado * double.Parse(txtResultado.Text)).ToString();
                    break;
                case "/":
                    if (double.Parse(txtResultado.Text) != 0)
                    {
                        txtResultado.Text = (resultado / double.Parse(txtResultado.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir entre cero.");
                    }
                    break;
                default:
                    break;
            }
            resultado = double.Parse(txtResultado.Text);
            operacion = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "0";
            resultado = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //iNICIALIZA EL TEXT BOX
            txtResultado.Text = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            btnOperacion_Click(sender, e);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            btnOperacion_Click(sender, e);
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            btnOperacion_Click(sender,e);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            btnOperacion_Click(sender, e);
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            btnIgual_Click(sender, e);
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            btnBorrar_Click(sender, e);
        }

        private void btncero_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            btnNumero_Click(sender, e);
        }
    }
}
