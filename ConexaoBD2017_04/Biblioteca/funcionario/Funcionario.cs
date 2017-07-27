using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pessoa;

namespace Biblioteca.funcionario
{
    public class Funcionario : Pessoa 
    {
        private int funcionarioId;

        public Funcionario()
        {

        }

        public int FuncionarioId
        {
            get { return FuncionarioId; }
            set { FuncionarioId = value; }
        }



    }
}
