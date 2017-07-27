using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.produto
{
    public class Produto
    {
        private int produtoId;
        private string nome;
        private string descricao;
        private double preco;
        private int quantidade;

        public Produto()
        {

        }

        public int ProdutoId
        {
            get { return produtoId; }
            set { produtoId = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Descricao
        { 
            get { return descricao;}
            set { descricao = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

    }

  
}


