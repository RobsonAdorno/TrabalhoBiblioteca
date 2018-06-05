using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL;
using Biblioteca.Model;

namespace Biblioteca.View
{
    class LoginView
    {

        public static void Executar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine("Digite o seu login!");
            string login = Console.ReadLine();

            Console.WriteLine("Digite a sua senha!");
            string senha = Console.ReadLine();

            if (VendedorDAO.EfetuarLogin(login,senha))
            {
                Console.WriteLine("Login efetuado com sucesso!");
                Apresentation.Login();
            }
            else
            {
                Console.WriteLine("Usuário ou senha inválido!");
            }
        }
    }
}
