using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class EmprestimoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

      public static void Cadastrar(Emprestimo e)
        {
            ctx.Emprestimos.Add(e);
            ctx.SaveChanges();
        }

    }
}
