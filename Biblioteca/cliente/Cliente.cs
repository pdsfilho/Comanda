using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pessoa;

namespace Biblioteca.cliente
{
    public class Cliente : Pessoa 
    {
        private int clienteId;

        public Cliente()
        {

        }
        public int ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }
    }
   
}
