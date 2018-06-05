using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class LivroDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Livro BuscarNomeLivro(Livro l)
        {
            return ctx.Livros.FirstOrDefault(x => x.NomeLivro.Equals(l.NomeLivro));
        }

        public static bool Cadastrar(Livro l)
        {
            if (BuscarNomeLivro(l) != null)
            {
                return false;
            }

            ctx.Livros.Add(l);
            ctx.SaveChanges();
            return true;
        }

    }
}
