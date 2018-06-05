using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.View
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;

            do
            {
                Console.WriteLine("\n   -----Cadastro-----      \n");
                Console.WriteLine("1) - Realizar Login");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("2) - Cadastro Vendedor");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("0) - Sair do programa");
                Console.WriteLine("---------------------------------------------");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        
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
