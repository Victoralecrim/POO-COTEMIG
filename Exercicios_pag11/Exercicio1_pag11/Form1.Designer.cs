using System;

namespace Exercicio1_pag11
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtminutos = new System.Windows.Forms.TextBox();
            this.txtsegundos = new System.Windows.Forms.TextBox();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.txtvalorpago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_valorpago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAnos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lbl_atraso = new System.Windows.Forms.Label();
            this.txt_atraso = new System.Windows.Forms.TextBox();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Location = new System.Drawing.Point(250, 90);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(78, 13);
            this.lbl_tempo.TabIndex = 0;
            this.lbl_tempo.Text = "Digite o tempo:";
            // 
            // txthoras
            // 
            this.txthoras.Location = new System.Drawing.Point(92, 168);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(100, 20);
            this.txthoras.TabIndex = 1;
            // 
            // txtminutos
            // 
            this.txtminutos.Location = new System.Drawing.Point(237, 168);
            this.txtminutos.Name = "txtminutos";
            this.txtminutos.Size = new System.Drawing.Size(100, 20);
            this.txtminutos.TabIndex = 2;
            // 
            // txtsegundos
            // 
            this.txtsegundos.Location = new System.Drawing.Point(373, 168);
            this.txtsegundos.Name = "txtsegundos";
            this.txtsegundos.Size = new System.Drawing.Size(100, 20);
            this.txtsegundos.TabIndex = 3;
            // 
            // btn_exibir
            // 
            this.btn_exibir.Location = new System.Drawing.Point(253, 227);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(75, 23);
            this.btn_exibir.TabIndex = 4;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = true;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minutos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Exibir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(810, 168);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(100, 20);
            this.txt_quantidade.TabIndex = 11;
            // 
            // txtvalorpago
            // 
            this.txtvalorpago.Location = new System.Drawing.Point(614, 168);
            this.txtvalorpago.Name = "txtvalorpago";
            this.txtvalorpago.Size = new System.Drawing.Size(100, 20);
            this.txtvalorpago.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(807, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade em dolar:";
            // 
            // lbl_valorpago
            // 
            this.lbl_valorpago.AutoSize = true;
            this.lbl_valorpago.Location = new System.Drawing.Point(599, 117);
            this.lbl_valorpago.Name = "lbl_valorpago";
            this.lbl_valorpago.Size = new System.Drawing.Size(115, 13);
            this.lbl_valorpago.TabIndex = 8;
            this.lbl_valorpago.Text = "valor a pagar em dolar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Exercicio 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(715, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Exercicio 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1218, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Exercicio3";
            // 
            // txtAnos
            // 
            this.txtAnos.Location = new System.Drawing.Point(1115, 123);
            this.txtAnos.Name = "txtAnos";
            this.txtAnos.Size = new System.Drawing.Size(128, 20);
            this.txtAnos.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1114, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Digite sua idade em anos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1282, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Digite sua idade em meses:";
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(1283, 123);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(128, 20);
            this.txtMeses.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1116, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Digite sua idade em dias:";
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(1117, 203);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(128, 20);
            this.txtDias.TabIndex = 20;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(1224, 244);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 22;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(1255, 286);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 23;
            this.lblResultado.Text = "0";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(237, 538);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 28;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lbl_atraso
            // 
            this.lbl_atraso.AutoSize = true;
            this.lbl_atraso.Location = new System.Drawing.Point(324, 431);
            this.lbl_atraso.Name = "lbl_atraso";
            this.lbl_atraso.Size = new System.Drawing.Size(78, 13);
            this.lbl_atraso.TabIndex = 27;
            this.lbl_atraso.Text = "Dias de atraso:";
            // 
            // txt_atraso
            // 
            this.txt_atraso.Location = new System.Drawing.Point(317, 468);
            this.txt_atraso.Name = "txt_atraso";
            this.txt_atraso.Size = new System.Drawing.Size(100, 20);
            this.txt_atraso.TabIndex = 26;
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(142, 431);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(79, 13);
            this.lbl_conta.TabIndex = 25;
            this.lbl_conta.Text = "Valor da conta:";
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(134, 468);
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(100, 20);
            this.txt_conta.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(233, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Exercicio4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 656);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lbl_atraso);
            this.Controls.Add(this.txt_atraso);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.txt_conta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAnos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.txtvalorpago);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_valorpago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.txtsegundos);
            this.Controls.Add(this.txtminutos);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.lbl_tempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtminutos;
        private System.Windows.Forms.TextBox txtsegundos;
        private System.Windows.Forms.Button btn_exibir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.TextBox txtvalorpago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_valorpago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lbl_atraso;
        private System.Windows.Forms.TextBox txt_atraso;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.Label label11;
    }
}

