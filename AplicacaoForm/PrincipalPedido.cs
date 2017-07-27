using Biblioteca;
using Biblioteca.comanda;
using Biblioteca.produto;
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
    public partial class PrincipalPedido : Form
    {
        List<Produto> lista = new List<Produto>();
        Produto p;
        private DadosComanda comanda;
        
        private List<Comanda> listaComanda;
        public PrincipalPedido()
        {
            InitializeComponent();
           
            comanda = new DadosComanda();
            listaComanda = new List<Comanda>();
            CarregarComanda();
        }

        private void CarregarComanda()
        {

            listaComanda = comanda.Select();
            dataGridView1.DataSource = listaComanda;
            //listaComanda
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        

        

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            GerarComanda telaGerarcomanda = new GerarComanda();
            telaGerarcomanda.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para inserir uma nova comanda favor dar um clique  no grid e para alterar o elemento favor clicar na celula após a pesquisa", "Suporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
