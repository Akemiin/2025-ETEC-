namespace herança
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
            this.lbl_01 = new System.Windows.Forms.Label();
            this.lbl_02 = new System.Windows.Forms.Label();
            this.lbl_03 = new System.Windows.Forms.Label();
            this.lbl_04 = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_05 = new System.Windows.Forms.Label();
            this.lbl_rg = new System.Windows.Forms.Label();
            this.lbl_06 = new System.Windows.Forms.Label();
            this.lbl_cartao = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_rg = new System.Windows.Forms.TextBox();
            this.txt_cartao = new System.Windows.Forms.TextBox();
            this.cadastro = new System.Windows.Forms.GroupBox();
            this.informações = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cadastro.SuspendLayout();
            this.informações.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(31, 40);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(45, 17);
            this.lbl_01.TabIndex = 0;
            this.lbl_01.Text = "Nome";
            // 
            // lbl_02
            // 
            this.lbl_02.AutoSize = true;
            this.lbl_02.Location = new System.Drawing.Point(31, 92);
            this.lbl_02.Name = "lbl_02";
            this.lbl_02.Size = new System.Drawing.Size(29, 17);
            this.lbl_02.TabIndex = 1;
            this.lbl_02.Text = "RG";
            // 
            // lbl_03
            // 
            this.lbl_03.AutoSize = true;
            this.lbl_03.Location = new System.Drawing.Point(31, 141);
            this.lbl_03.Name = "lbl_03";
            this.lbl_03.Size = new System.Drawing.Size(50, 17);
            this.lbl_03.TabIndex = 2;
            this.lbl_03.Text = "Cartão";
            // 
            // lbl_04
            // 
            this.lbl_04.AutoSize = true;
            this.lbl_04.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_04.Location = new System.Drawing.Point(13, 11);
            this.lbl_04.Name = "lbl_04";
            this.lbl_04.Size = new System.Drawing.Size(49, 17);
            this.lbl_04.TabIndex = 3;
            this.lbl_04.Text = "Nome:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(78, 11);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(65, 17);
            this.lbl_nome.TabIndex = 4;
            this.lbl_nome.Text = "lbl_nome";
            // 
            // lbl_05
            // 
            this.lbl_05.AutoSize = true;
            this.lbl_05.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_05.Location = new System.Drawing.Point(29, 53);
            this.lbl_05.Name = "lbl_05";
            this.lbl_05.Size = new System.Drawing.Size(33, 17);
            this.lbl_05.TabIndex = 5;
            this.lbl_05.Text = "RG:";
            // 
            // lbl_rg
            // 
            this.lbl_rg.AutoSize = true;
            this.lbl_rg.Location = new System.Drawing.Point(78, 53);
            this.lbl_rg.Name = "lbl_rg";
            this.lbl_rg.Size = new System.Drawing.Size(43, 17);
            this.lbl_rg.TabIndex = 6;
            this.lbl_rg.Text = "lbl_rg";
            // 
            // lbl_06
            // 
            this.lbl_06.AutoSize = true;
            this.lbl_06.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_06.Location = new System.Drawing.Point(8, 90);
            this.lbl_06.Name = "lbl_06";
            this.lbl_06.Size = new System.Drawing.Size(54, 17);
            this.lbl_06.TabIndex = 7;
            this.lbl_06.Text = "Cartão:";
            // 
            // lbl_cartao
            // 
            this.lbl_cartao.AutoSize = true;
            this.lbl_cartao.Location = new System.Drawing.Point(78, 90);
            this.lbl_cartao.Name = "lbl_cartao";
            this.lbl_cartao.Size = new System.Drawing.Size(70, 17);
            this.lbl_cartao.TabIndex = 8;
            this.lbl_cartao.Text = "lbl_cartao";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(383, 60);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(133, 85);
            this.btn.TabIndex = 9;
            this.btn.Text = "Armazenar e mostrar";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(95, 37);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(239, 22);
            this.txt_nome.TabIndex = 10;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(95, 89);
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(239, 22);
            this.txt_rg.TabIndex = 11;
            // 
            // txt_cartao
            // 
            this.txt_cartao.Location = new System.Drawing.Point(95, 141);
            this.txt_cartao.Name = "txt_cartao";
            this.txt_cartao.Size = new System.Drawing.Size(239, 22);
            this.txt_cartao.TabIndex = 12;
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cadastro.Controls.Add(this.txt_cartao);
            this.cadastro.Controls.Add(this.txt_rg);
            this.cadastro.Controls.Add(this.txt_nome);
            this.cadastro.Controls.Add(this.btn);
            this.cadastro.Controls.Add(this.lbl_03);
            this.cadastro.Controls.Add(this.lbl_02);
            this.cadastro.Controls.Add(this.lbl_01);
            this.cadastro.Location = new System.Drawing.Point(37, 36);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(558, 200);
            this.cadastro.TabIndex = 13;
            this.cadastro.TabStop = false;
            this.cadastro.Text = "cadastro";
            // 
            // informações
            // 
            this.informações.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.informações.Controls.Add(this.groupBox1);
            this.informações.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.informações.Location = new System.Drawing.Point(37, 254);
            this.informações.Name = "informações";
            this.informações.Size = new System.Drawing.Size(423, 157);
            this.informações.TabIndex = 14;
            this.informações.TabStop = false;
            this.informações.Text = "informações digitadas";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.lbl_cartao);
            this.groupBox1.Controls.Add(this.lbl_06);
            this.groupBox1.Controls.Add(this.lbl_rg);
            this.groupBox1.Controls.Add(this.lbl_05);
            this.groupBox1.Controls.Add(this.lbl_nome);
            this.groupBox1.Controls.Add(this.lbl_04);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(667, 443);
            this.Controls.Add(this.informações);
            this.Controls.Add(this.cadastro);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cadastro.ResumeLayout(false);
            this.cadastro.PerformLayout();
            this.informações.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.Label lbl_02;
        private System.Windows.Forms.Label lbl_03;
        private System.Windows.Forms.Label lbl_04;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_05;
        private System.Windows.Forms.Label lbl_rg;
        private System.Windows.Forms.Label lbl_06;
        private System.Windows.Forms.Label lbl_cartao;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_rg;
        private System.Windows.Forms.TextBox txt_cartao;
        private System.Windows.Forms.GroupBox cadastro;
        private System.Windows.Forms.GroupBox informações;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

