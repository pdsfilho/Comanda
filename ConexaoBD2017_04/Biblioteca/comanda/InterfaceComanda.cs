using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.comanda
{
  public  interface InterfaceComanda
    {
        void Insert(Comanda comanda);
        void Update(Comanda comanda);
        void Delete(Comanda comanda);
    }
}
