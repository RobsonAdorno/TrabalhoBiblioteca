using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAL;

namespace Biblioteca.View
{
    class ClienteView
    {
        public static void Executar()
        {
            Cliente c = new Cliente();

            Console.WriteLine("Por favor, digite o nome do cliente");
            c.Nome = Console.ReadLine();
            Console.WriteLine("Por favor, digite o CPF do cliente");
            c.CPF = Console.ReadLine();
            c.Data = DateTime.Now;

            if (ClienteDAO.Cadastrar(c))
            {
                Console.WriteLine("Cliente cadastrado com sucesso!");
                
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar cliente!");
            }
            Console.WriteLine("Pressione um botão para voltar ao Menu Principal");
            Console.ReadKey();
        }

    }
}
