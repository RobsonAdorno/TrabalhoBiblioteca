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
            Login l = new Login();
            Console.WriteLine("Por favor, digite o Usuário!");
            Login.Usuario = Console.ReadLine();
            Console.WriteLine("Por favor, digite a Senha!");
            Login.Senha = Convert.ToInt32(Console.ReadLine());

            if (LoginDAO.Cadastrar(l))
            {
                Console.WriteLine("Login efetuado com sucesso!");
                Apresentation.Login();
            }
            
        }
    }
}
