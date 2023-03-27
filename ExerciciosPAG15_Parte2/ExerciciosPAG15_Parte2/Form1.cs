using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosPAG15_Parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            int parcela = int.Parse(txtParcelas.Text);
            double salario = int.Parse(txtSalario.Text);
            int valorEmprestimo = int.Parse(txtEmprestimo.Text);
            double valor_parcela = 0;

            double maximo_permitido = salario * 0.30;
            valor_parcela = valorEmprestimo / parcela;


            if (valor_parcela > maximo_permitido)
            {
                lblResultado1.Text = "O empréstimo não pode ser aprovado!";
            }
            else
            {
                lblResultado1.Text = "O empréstimo foi aprovado!";
            }
        }

        private void btnEnviar2_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtValor1.Text),
              n2 = int.Parse(txtValor2.Text),
              n3 = int.Parse(txtValor3.Text);

            int maxValue = 0;

            if (n1 > n2 && n1 > n3)
            {
                maxValue = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maxValue = n2;
            }
            else if (n3 > n1 && n3 > n2)
            {
                maxValue = n3;
            }

            lblResultado2.Text = "O maior valor é: " + maxValue.ToString();
        }

        private void btnEnviar3_Click(object sender, EventArgs e)
        {
            int diarias = int.Parse(txtDiarias.Text);
            string nome = txtNome.Text;
            double total = 0;

            if (diarias == 15)
            {
                diarias = diarias * 12;
                total = 180 + diarias;
            }
            else if (diarias > 15)
            {
                diarias = diarias * 10;
                total = 180 + diarias;
            }
            else if (diarias < 15)
            {
                diarias = diarias * 15;
                total = 180 + diarias;
            }

            lblResultado3.Text = nome+ ", " + total.ToString("C");
        }

        private void btnEnviar4_Click(object sender, EventArgs e)
        {
            int matricula = 0;

            if (txtMatricula.Text.Length == 6)
            {
                matricula = int.Parse(txtMatricula.Text);
                string nome = txtNome2.Text;

                int nta1 = int.Parse(txtNota1.Text),
                    nta2 = int.Parse(txtNota2.Text),
                    nta3 = int.Parse(txtNota3.Text);


                string classificacao = "";
                int notaFinal = nta1 + nta2 + nta3;

                if (notaFinal <= 3)
                {
                    classificacao = "Conceito R";
                }
                else if (notaFinal >= 3 && notaFinal < 5)
                {
                    classificacao = "Conceito D";
                }
                else if (notaFinal >= 5 && notaFinal < 7)
                {
                    classificacao = "Conceito C";
                }
                else if (notaFinal >= 7 && notaFinal < 9)
                {
                    classificacao = "Conceito B";
                }
                else if (notaFinal >= 9 && notaFinal <= 10)
                {
                    classificacao = "Conceito A";
                }
                else
                {
                    classificacao = "Nulo";
                }
                lblResultado4.Text = nome.ToString() + "," + matricula.ToString() + "," + notaFinal.ToString() + "," + classificacao;
            }
            else
            {
                lblResultado4.Text = "Numero de matrícula inválido";
            }
        }
    }
}
