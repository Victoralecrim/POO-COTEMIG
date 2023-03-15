using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += ".";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtresultado.Text, CultureInfo.InvariantCulture);

            //if (operacao == "Soma")
            //{
            //    txtresultado.Text = Convert.ToString(valor1 + valor2);
            //}
            //else if (operacao == "Subtracao")
            //{
            //    txtresultado.Text = Convert.ToString(valor1 - valor2);
            //}
            //else if (operacao == "Multiplicacao")
            //{
            //    txtresultado.Text = Convert.ToString(valor1 * valor2);
            //}
            //else
            //{
            //    txtresultado.Text = Convert.ToString(valor1/valor2);

            //}


            switch (operacao)
            {
                case "Soma":
                    txtresultado.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "Subtracao":
                    txtresultado.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "Multiplicacao":
                    txtresultado.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "Divisao":
                    txtresultado.Text = Convert.ToString(valor1 / valor2);
                    break;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != String.Empty)
            {
                valor1 = double.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "Subtracao";
                lblOperacao.Text = "-";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a subtração");
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != String.Empty)
            {
                valor1 = double.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "Multiplicacao";
                lblOperacao.Text = "X";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a multiplicação");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != String.Empty)
            {
                valor1 = double.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "Divisao";
                lblOperacao.Text = "/";

            }

            else
            {
                MessageBox.Show("Informe um valor para efetuar a divisão");
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtresultado.Text != String.Empty)
            {
                valor1 = double.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
                txtresultado.Text = "";
                operacao = "Soma";
                lblOperacao.Text = "+";

            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar o soma");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }

    }
}
