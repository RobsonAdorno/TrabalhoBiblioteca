using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAL;

namespace Biblioteca.View
{
    class VendedorView
    {

        public static void Executar()
        {

            Vendedor v = new Vendedor();
            Console.Clear();
            Console.WriteLine("Digite o seu nome");
            v.Nome = Console.ReadLine();

            Console.WriteLine("Digite o seu CPF");
            v.CPF = Console.ReadLine();

            Console.WriteLine("Digite o seu Login");
            v.Login = Console.ReadLine();

            Console.WriteLine("Digite a sua Senha");
            v.Senha = Console.ReadLine();

            if (VendedorDAO.Cadastrar(v)){
                Apresentation.Login();
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar vendedor!");
            }

        }
    }
}
