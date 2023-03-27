using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePG16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int Valor = 0;

            if (rdbSim1.Checked == true)
            {
                Valor++;
            }
            else
            {
                lblResultado.Text = "Pressione todos os botoes";
            }

            if (rdbSim2.Checked == true)
            {
                Valor++;
            }

            else
            {
                lblResultado.Text = "Pressione todos os botoes";
            }

            if (rdbSim3.Checked == true)
            {
                Valor++;
            }
            else
            {
                lblResultado.Text = "Pressione todos os botoes";
            }

            if (rdbSim4.Checked == true)
            {
                Valor++;
            }
            else
            {
                lblResultado.Text = "Pressione todos os botoes";
            }
            if (rdbSim5.Checked == true)
            {
                Valor++;
            }
            else
            {
                lblResultado.Text = "Pressione todos os botoes";
            }

            switch (Valor)
            {
                case 2:
                    lblResultado.Text = "Ele é suspeito";
                    break;
                case 3:
                case 4:
                    lblResultado.Text = "Ele é cumplice";
                    break;
                case 5:
                    lblResultado.Text = "Ele é o assasino";
                    break;
                default:
                    lblResultado.Text = "Ele é inocente";
                    break;
            }
        }
    }

}
