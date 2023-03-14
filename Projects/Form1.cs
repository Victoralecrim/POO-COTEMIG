using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Global
        {
            public static bool vezJogador, button_disable;
            public static int player1_vitorias = 0, player2_vitorias = 0, empate = 0, rodadas = 0;
            public static int GradeA = 0, GradeB = 0, GradeC = 0, GradeD = 0, GradeE = 0, GradeF = 0, GradeG = 0, GradeH = 0, GradeI = 0;

        }

        //public void validarJogadas()
        //{
        //    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
        //    {
        //        MessageBox.Show("Jogador 1 Venceu");
        //    }
        //}

        private void checkingWinner()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                MessageBox.Show("Jogador 1 Venceu");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Verificação da jogador 1(X) 

            if (Global.vezJogador == false && Global.button_disable == false && Global.GradeA == 0)
            {

                button1.Text = "X";
                Global.GradeA = 1;
                Global.rodadas++;
                checkingWinner();
                Global.vezJogador = true;
            }

            //Verificar o jogador 2(0)


            if (Global.vezJogador == false && Global.button_disable == false && Global.GradeA == 0)
            {
                button1.Text = "O";
                Global.GradeA = 2;
                Global.rodadas++;
                checkingWinner();
                Global.vezJogador = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.GradeB == 0)
            {
                button2.Text = "X";
                Global.GradeB = 1;
                Global.rodadas++;
                checkingWinner();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.GradeB == 0)
            {
                button2.Text = "O";
                Global.GradeB = 2;
                Global.rodadas++;
                checkingWinner();
                Global.vezJogador = false;
            }

        }
    }
}




