using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.produto;

namespace Biblioteca.item
{
    public class Item
    {
        private int itemId;
        public List<Produto> produtos;

        public Item()
        {
            this.produtos = new List<Produto>();
        }

        public int ItemId
            {
            get { return itemId; }
            set { itemId = value; }
            }
    }
}

