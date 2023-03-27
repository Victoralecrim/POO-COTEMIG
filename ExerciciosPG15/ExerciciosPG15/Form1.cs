using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosPG15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int senha = int.Parse(txtSenha.Text);

            if (senha == 1234)
            {
                lblAcesso.Text = "Acesso Permitido";
            }
            else
            {
                lblAcesso.Text = "Acesso Negado";
            }

        }


        private void btnEnviar2_Click_1(object sender, EventArgs e)
        {
            double desconto = 0;
            int quant = int.Parse(txtQuantidade.Text);
            double preco = double.Parse(txtPreco.Text);
            double R = 0;

            switch (quant)
            {
                case 5:
                    desconto = preco * 0.02;
                    R = quant * (preco - desconto);
                    lblResultado2.Text = R.ToString("C");

                    break;
                case 6-10:
                    desconto = preco * 0.03;
                    R = quant * (preco - desconto);
                    lblResultado2.Text = R.ToString("C");
                    break;
                default:
                    desconto = preco * 0.05;
                    R =  quant * (preco - desconto);
                    lblResultado2.Text = R.ToString("C");
                    break;
            }
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txtValor1.Text),
                valor2 = int.Parse(txtValor2.Text),
                valor3 = int.Parse(txtValor3.Text);

            int[] ordem = new int[3] { valor1, valor2, valor3 };
            Array.Sort(ordem);
            lblResultado1.Text = string.Join(",", ordem);

        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            int ang = int.Parse(txtAngulo.Text);

            if (ang == 90)
            {
                lblResultado3.Text = "Retângulo";
            }
            else if (ang > 90)
            {
                lblResultado3.Text = "Obtusângulo";
            }
            else if (ang < 90)
            {
                lblResultado3.Text = "Acutângulo";
            }
        }
    }


}
