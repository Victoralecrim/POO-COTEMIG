using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1_pag11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Exercicio 1
        private void btn_exibir_Click(object sender, EventArgs e)
        {

            int horas, minutos, segundos, resultado;

            horas = int.Parse(txthoras.Text);
            minutos = int.Parse(txtminutos.Text);
            segundos = int.Parse(txtsegundos.Text);

            resultado = (horas * 60 * 60) + (minutos * 60) + segundos;

            MessageBox.Show("" + resultado);

        }

        //Exercicio 2 

        private void button1_Click(object sender, EventArgs e)
        {
            int quantidade;
            double valor, real;

            valor = int.Parse(txtvalorpago.Text);
            quantidade = int.Parse(txt_quantidade.Text);

            real = valor * 5.29 * quantidade;
            MessageBox.Show("" + real);

        }

        //Exercicio 3

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int idadeAnos, idadeMes, idadeDias, idadeF;

            if (int.TryParse(txtAnos.Text, out idadeAnos) && int.TryParse(txtMeses.Text, out idadeMes) && int.TryParse(txtDias.Text, out idadeDias))
            {
                idadeF = idadeAnos * 365 + idadeMes * 30 + idadeDias;
                lblResultado.Text = "Sua idade em dias é: " + idadeF;
            }
            else
            {
                MessageBox.Show("Digite um valor válido para idade em anos, meses e dias.");
            }
        }

        private void btnCalc_click(object sender, EventArgs e)
        {
            int dias;
            double valor, total;

            dias = int.Parse(txt_atraso.Text);
            valor = double.Parse(txt_conta.Text);

            total = dias * valor;
        }
    }
}
