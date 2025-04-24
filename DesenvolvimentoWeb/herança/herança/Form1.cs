using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            funcionario f = new funcionario();

            f.setNome(txt_nome.Text);
            f.setRg(txt_rg.Text);
            f.setCartao(txt_cartao.Text);

            lbl_nome.Text = f.getNome();
            lbl_rg.Text = f.getRg();
            lbl_cartao.Text = f.getCartao();
        }
    }
}
