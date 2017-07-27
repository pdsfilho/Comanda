using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.pessoa;
using Biblioteca.cliente;
using Biblioteca.funcionario;
using Biblioteca.item;

namespace Biblioteca.comanda
{
    public class Comanda
    {
        private int comandaId;
        private Funcionario funcionario;
        private Cliente cliente;
        private Item item;
        private double total;
        private DateTime data;
        private int status;

        public Comanda()
        {
            this.funcionario = new Funcionario();
            this.cliente = new Cliente();
            this.item = new Item();
        }
        public int ComandaId
        {
            get { return comandaId; }
            set { comandaId = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public Funcionario Funcionario
        {
            get{ return funcionario; }
            set { funcionario = value; }
            
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public Item Item
        {
            get { return item; }
            set { item = value; }
        }
    }
}
