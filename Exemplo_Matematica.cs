---------- Form1.cs* ----------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Matematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            //criar variável
            double numero1, numero2, numero3 , soma;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);

            soma = (numero1 + numero2) + numero3;

            //como mostrar o resultado da soma

            txt_resultado.Text = soma.ToString();
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            double numero1 , numero2 , numero3 , subtracao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);

            subtracao = (numero1 - numero2) - numero3;

            txt_resultado.Text = subtracao.ToString();

        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            double numero1 , numero2 , numero3 , divisao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);

            divisao = (numero1 / numero2) / numero3 ;

            txt_resultado.Text = divisao.ToString();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            double numero1, numero2, numero3, multiplicacao;
            numero1 = double.Parse(txt1.Text);
            numero2 = double.Parse(txt2.Text);
            numero3 = double.Parse(txt3.Text);

            multiplicacao = (numero1 * numero2) * numero3;

            txt_resultado.Text = multiplicacao.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt_resultado.Text = "";
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}


---------- Form1.Designer.cs* ----------

namespace Exemplo_Matematica
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_subtracao = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_soma
            // 
            this.btn_soma.BackColor = System.Drawing.Color.Pink;
            this.btn_soma.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.35F);
            this.btn_soma.Location = new System.Drawing.Point(439, 13);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(230, 78);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = false;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.MistyRose;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.35F);
            this.btn_limpar.Location = new System.Drawing.Point(187, 376);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(310, 84);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txt1.Location = new System.Drawing.Point(64, 40);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(223, 46);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txt2.Location = new System.Drawing.Point(64, 120);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(223, 46);
            this.txt2.TabIndex = 3;
            // 
            // txt_resultado
            // 
            this.txt_resultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txt_resultado.Location = new System.Drawing.Point(65, 297);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.Size = new System.Drawing.Size(223, 46);
            this.txt_resultado.TabIndex = 4;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl1.Location = new System.Drawing.Point(61, 17);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 20);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Digite o 1° número";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl2.Location = new System.Drawing.Point(60, 97);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(149, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Digite o 2° número";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_resultado.Location = new System.Drawing.Point(60, 274);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(155, 20);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Mostrar o resultado";
            // 
            // btn_divisao
            // 
            this.btn_divisao.BackColor = System.Drawing.Color.Pink;
            this.btn_divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.35F);
            this.btn_divisao.Location = new System.Drawing.Point(439, 97);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(230, 78);
            this.btn_divisao.TabIndex = 9;
            this.btn_divisao.Text = "Divisão";
            this.btn_divisao.UseVisualStyleBackColor = false;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.BackColor = System.Drawing.Color.Pink;
            this.btn_multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.35F);
            this.btn_multiplicacao.Location = new System.Drawing.Point(439, 265);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(230, 78);
            this.btn_multiplicacao.TabIndex = 10;
            this.btn_multiplicacao.Text = "Multiplicação";
            this.btn_multiplicacao.UseVisualStyleBackColor = false;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_subtracao
            // 
            this.btn_subtracao.BackColor = System.Drawing.Color.Pink;
            this.btn_subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.35F);
            this.btn_subtracao.Location = new System.Drawing.Point(439, 181);
            this.btn_subtracao.Name = "btn_subtracao";
            this.btn_subtracao.Size = new System.Drawing.Size(230, 78);
            this.btn_subtracao.TabIndex = 11;
            this.btn_subtracao.Text = "Subtração";
            this.btn_subtracao.UseVisualStyleBackColor = false;
            this.btn_subtracao.Click += new System.EventHandler(this.btn_subtracao_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl3.Location = new System.Drawing.Point(66, 181);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(149, 20);
            this.lbl3.TabIndex = 12;
            this.lbl3.Text = "Digite o 3° número";
            this.lbl3.Click += new System.EventHandler(this.lbl3_Click);
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.txt3.Location = new System.Drawing.Point(64, 204);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(223, 46);
            this.txt3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 485);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.btn_subtracao);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_soma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
        private System.Windows.Forms.Button btn_subtracao;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txt3;
    }
}
