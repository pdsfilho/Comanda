using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.pessoa
{
    public class Pessoa
    {
        private string cpf;
        private string nome;
        private string telefone; 

        public Pessoa()
        {
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }

        }
    }
}
