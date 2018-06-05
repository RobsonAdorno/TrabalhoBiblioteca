using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class VendedorDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Vendedor BuscarVendedorPorCPF(Vendedor v)
        {
            return ctx.Vendedores.FirstOrDefault(x => x.CPF.Equals(v.CPF));
        }

        public static Vendedor BuscarVendedorPorLogin(Vendedor v)
        {
            return ctx.Vendedores.FirstOrDefault(x => x.Login.Equals(v.Login));
        }



        public static bool ValidarCPF(Vendedor v)
        {
            if (BuscarVendedorPorCPF(v) != null)
            {
                return false;
            }else if (BuscarVendedorPorLogin(v) != null)
            {
                return false;
            }

            return true;
        }


        public static bool Cadastrar(Vendedor v)
        {
            if (!ValidarCPF(v))
            {
                return false;
            }

            ctx.Vendedores.Add(v);
            ctx.SaveChanges();
            return true;
        }

        public static List<Vendedor> Listagem()
        {
            return ctx.Vendedores.ToList();
        }

        public static bool EfetuarLogin(string login, string senha)
        {
        Vendedor a =   ctx.Vendedores.FirstOrDefault(x => x.Login.Equals(login));
        Vendedor  b =  ctx.Vendedores.FirstOrDefault(x => x.Senha.Equals(senha));

            if (a != null && b != null)
            {
                return true;
            }
            return false;
        }

    }
}
