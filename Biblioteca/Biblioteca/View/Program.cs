using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL;
using Biblioteca.Model;

namespace Biblioteca.View
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;

            do
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\n   -----Cadastro-----      \n");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1) - Realizar Login");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("2) - Cadastrar-se");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("0) - Sair do programa");
                Console.WriteLine("---------------------------------------------");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        LoginView.Executar();
                    break;

                    case "2":
                        VendedorView.Executar();
                        break;

                    case "0":
                        Console.WriteLine("Encerrando aplicação");
                        Console.ReadKey();
                        break;
                }

            } while (op != "0");



        }
    }
}
