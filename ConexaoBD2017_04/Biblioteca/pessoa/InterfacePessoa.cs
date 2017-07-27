using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.pessoa
{
    public interface InterfacePessoa
    {
        void Insert(Pessoa pessoa);
        void Update(Pessoa pessoa);
        void Delete(Pessoa pessoa);
        bool VerificaDuplicidade(Pessoa pessoa);
        List<Pessoa> Select(Pessoa filtro);
    }
}
