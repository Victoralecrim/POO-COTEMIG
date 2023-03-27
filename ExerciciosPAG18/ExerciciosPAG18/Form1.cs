using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosPAG18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;

            numero = int.Parse(textBox1.Text);

            switch (numero)
            {
                case 1:
                    MessageBox.Show("Janeiro");
                    break;
                case 2:
                    MessageBox.Show("Fevereiro");
                    break;
                case 3:
                    MessageBox.Show("Março");
                    break;
                case 4:
                    MessageBox.Show("Abril");
                    break;
                case 5:
                    MessageBox.Show("Maio");
                    break;
                case 6:
                    MessageBox.Show("Junho");
                    break;
                case 7:
                    MessageBox.Show("Julho");
                    break;
                case 8:
                    MessageBox.Show("Agosto");
                    break;
                case 9:
                    MessageBox.Show("Setembro");
                    break;
                case 10:
                    MessageBox.Show("Outubro");
                    break;
                case 11:
                    MessageBox.Show("Novembro");
                    break;
                case 12:
                    MessageBox.Show("Dezembro");
                    break;
                default:
                    MessageBox.Show("Não existe mês correspondente a esse numero");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int escolha;
            double valorProd;

            escolha = int.Parse(textBox2.Text);
            valorProd = int.Parse(textBox3.Text);

            if (escolha == 1)
            {
                valorProd = int.Parse(textBox3.Text) * 5.27;
                MessageBox.Show($"O produto é importado, seu valor é {valorProd}");
            }
            else if (escolha == 2)
            {
                MessageBox.Show("O produto é nacional e custa: " + textBox3.Text);
            }
        }

        private void btnCalcular3_Click(object sender, EventArgs e)
        {
            lblResultado3.MaximumSize = new Size(250, 0);
            lblResultado3.AutoSize = true;
            int mes = int.Parse(txtMes.Text);
            string dias = " ";

            switch (mes)
            {
                case 1:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Janeiro" + dias;
                    break;
                case 2:
                    dias = " com 28 ou 29 dias";
                    lblResultado3.Text = "Fevereiro" + dias;
                    break;
                case 3:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Março" + dias;
                    break;
                case 4:
                    dias = " com 30 dias";
                    lblResultado3.Text = "Abril" + dias;
                    break;
                case 5:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Maio" + dias;
                    break;
                case 6:
                    dias = " com 30 dias";
                    lblResultado3.Text = "Junho" + dias;
                    break;
                case 7:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Julho" + dias;
                    break;
                case 8:
                    dias = " com 31 dias";
                    lblResultado3.Text ="Agosto" + dias;
                    break;
                case 9:
                    dias = " com 30 dias";
                    lblResultado3.Text = "Setembro" + dias;
                    break;
                case 10:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Outubro" + dias;
                    break;
                case 11:
                    dias = " com 30 dias";
                    lblResultado3.Text = "Novembro" + dias;
                    break;
                case 12:
                    dias = " com 31 dias";
                    lblResultado3.Text = "Dezembro" + dias;
                    break;

                default:
                    lblResultado3.Text = "Número Inválido";
                    break;
            }
        }
    }
}
