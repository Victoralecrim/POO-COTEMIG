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
            public static int player1_vitorias = 0, player2_vitorias = 0, rodadas = 0, empates = 0, LacunaA = 0, LacunaB = 0, LacunaC = 0, LacunaD = 0, LacunaE = 0, LacunaF = 0, LacunaG = 0, LacunaH = 0, LacunaI = 0;
            public static int p1;
        }

        //public void validarJogadas()
        //{
        //    if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
        //    {
        //        MessageBox.Show("Jogador 1 Venceu");
        //    }
        //}

        //Metodo que checa o vencedor do jogo

        //Metodo que verifica as vitorias dos dois jogadores
        private void wins()
        {
            //Se a variavel p1 for igual a 1 a vitoria será do jogador 1,
            //se não for a vitoria será do jogador 2 
            if (Global.p1 == 1)
            {
                Global.player1_vitorias++;
                label4.Text = Convert.ToString(Global.player1_vitorias);
                MessageBox.Show("Jogador 1 venceu!");
                Global.button_disable = true;
            }

            else if (Global.p1 == 2)
            {
                Global.player2_vitorias++;
                label5.Text = Convert.ToString(Global.player2_vitorias);
                MessageBox.Show("Jogador 2 venceu!");
                Global.button_disable = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Verificação do jogador 1(X) 

            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaA == 0)
            {

                button1.Text = "X";
                Global.LacunaA = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }

            //Verificação da jogada do jogador 2(0)


            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaA == 0)
            {
                button1.Text = "O";
                Global.LacunaA = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }

        }

        private void checarVencedor()
        {
            // Verificações de vitórias do jogador 1(X) nas horizontais:
            if (Global.LacunaA == 1 && Global.LacunaB == 1 && Global.LacunaC == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.LacunaD == 1 && Global.LacunaE == 1 && Global.LacunaF == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.LacunaG == 1 && Global.LacunaH == 1 && Global.LacunaI == 1)
            {
                Global.p1 = 1;
                wins();
            }

            // Verificações de vitórias do jogador 1(X) nas verticais:
            if (Global.LacunaA == 1 && Global.LacunaD == 1 && Global.LacunaG == 1)
            {
                Global.p1 =1;
                wins();
            }

            if (Global.LacunaB == 1 && Global.LacunaE == 1 && Global.LacunaH == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.LacunaC == 1 && Global.LacunaF == 1 && Global.LacunaI == 1)
            {
                Global.p1 =1;
                wins();
            }


            // Verificações de vitórias do jogador 1(X) nas diagonais:
            if (Global.LacunaA == 1 && Global.LacunaE == 1 && Global.LacunaI == 1)
            {
                Global.p1 = 1;
                wins();
            }

            if (Global.LacunaC == 1 && Global.LacunaE == 1 && Global.LacunaG == 1)
            {
                Global.p1 = 1;
                wins();
            }

            /*******************************************************************************************************************/


            // Verificações de vitórias do jogador 2(O) nas horizontais:
            if (Global.LacunaA == 2 && Global.LacunaB == 2 && Global.LacunaC == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.LacunaD == 2 && Global.LacunaE == 2 && Global.LacunaF == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.LacunaG == 2 && Global.LacunaH == 2 && Global.LacunaI == 2)
            {
                Global.p1 = 2;
                wins();
            }

            // Verificações de vitórias do jogador 2(O) nas verticais:
            if (Global.LacunaA == 2 && Global.LacunaD == 2 && Global.LacunaG == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.LacunaB == 2 && Global.LacunaE == 2 && Global.LacunaH == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.LacunaC == 2 && Global.LacunaF == 2 && Global.LacunaI == 2)
            {
                Global.p1 = 2;
                wins();
            }

            // Verificações de vitórias do jogador 2(O) nas diagonais:
            if (Global.LacunaA == 2 && Global.LacunaE == 2  && Global.LacunaI == 2)
            {
                Global.p1 = 2;
                wins();
            }

            if (Global.LacunaC == 2  && Global.LacunaE == 2 && Global.LacunaG == 2)
            {
                Global.p1 = 2;
                wins();
            }


            if (Global.p1 == 0 && Global.rodadas == 9)
            {
                Global.empates++;
                label6.Text = Convert.ToString(Global.empates);
                MessageBox.Show("Empate");
                Global.button_disable = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button2.Text = "X";
                Global.LacunaB = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button2.Text = "O";
                Global.LacunaB = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button3.Text = "X";
                Global.LacunaC = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button3.Text = "O";
                Global.LacunaC = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button4.Text = "X";
                Global.LacunaD = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button4.Text = "O";
                Global.LacunaD = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button5.Text = "X";
                Global.LacunaE = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button5.Text = "O";
                Global.LacunaE = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button6.Text = "X";
                Global.LacunaF = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button6.Text = "O";
                Global.LacunaF = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button7.Text = "X";
                Global.LacunaG = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button7.Text = "O";
                Global.LacunaG = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button8.Text = "X";
                Global.LacunaH = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button8.Text = "O";
                Global.LacunaH = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Global.vezJogador == false && Global.button_disable == false && Global.LacunaB == 0)
            {
                button9.Text = "X";
                Global.LacunaI = 1;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = true;
            }
            if (Global.vezJogador == true && Global.button_disable == false && Global.LacunaB == 0)
            {
                button9.Text = "O";
                Global.LacunaI = 2;
                Global.rodadas++;
                checarVencedor();
                Global.vezJogador = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Global.LacunaA = 0;
            Global.LacunaB = 0;
            Global.LacunaC = 0;
            Global.LacunaD = 0;
            Global.LacunaE = 0;
            Global.LacunaF = 0;
            Global.LacunaG = 0;
            Global.LacunaH = 0;
            Global.LacunaI = 0;
            Global.rodadas = 0;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            Global.button_disable = false;

            if (Global.p1 == 1 || Global.p1 == 0)
            {
                Global.vezJogador = false;
                Global.p1 = 0;
            }
            else if (Global.p1 == 2)
            {
                Global.vezJogador = true;
                Global.p1 = 0;
            }
        }
    }
}
