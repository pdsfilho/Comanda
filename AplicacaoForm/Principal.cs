using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoForm
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            btCliente.Visible = true;
            btFuncionario.Visible = true;
            btProduto.Visible = true;
            btFecharComanda.Visible = false;
            btRegPedido.Visible = false;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btCliente.Visible = false;
            btFuncionario.Visible = false;
            btProduto.Visible = false;
            btFecharComanda.Visible = true;
            btRegPedido.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "Bem Vindo, Hoje: "+DateTime.Now.ToString();
        }

        private void btRegPedido_Click(object sender, EventArgs e)
        {
            PrincipalPedido tela = new PrincipalPedido();
            tela.ShowDialog();
        }
    }
}
