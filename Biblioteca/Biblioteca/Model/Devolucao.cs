using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.Model
{
    class Devolucao
    {
        public Devolucao()
        {

            NomeLivroDevolvido = new Livro();
            NomeClienteDevolvido = new Cliente();
        }


        public int DevolucaoID {get;set;}
        public Livro NomeLivroDevolvido { get; set; }
        public Cliente NomeClienteDevolvido { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
