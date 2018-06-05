using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca.DAL
{
    class ClienteDAO
    {
        private static Context ctx = SingletonContext.GetInstance();
        public static Cliente BuscarClientePorCPF(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.CPF.Equals(c.CPF));
        }

        public static Cliente BuscarClientePorNome(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Nome.Equals(c.Nome));
        }

        public static bool Cadastrar(Cliente c)
        {
            if (BuscarClientePorCPF(c) != null)
            {
                return false;
            }
            ctx.Clientes.Add(c);
            ctx.SaveChanges();
            return true;
        }
    }
}
