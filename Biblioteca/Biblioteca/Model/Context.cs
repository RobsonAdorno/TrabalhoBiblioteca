using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    class Context: DbContext
    {
        public Context() : base("BibliotecaEcoville") { }

        public DbSet<Vendedor> Vendedores { get; set; }
    }
}
