using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;

namespace Biblioteca
{
    class Apresentation
    {
        public static void Login(){

            Vendedor v = new Vendedor();

            string op;

            do
            {
                Console.Clear();
                
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("\n--Cadastro de Livro--\n");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1) - Cadastrar Livro");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("2) - Cadastrar Cliente");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("3) - Emprestar Livro");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("4) - Devolver Livro");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("5) - Histórico de Movimentação do livro");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("6) - Editar detalhes da conta");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("0) - Voltar ao Menu de Cadastro");
                Console.WriteLine("---------------------------------------------");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":

                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "0":
                        Console.WriteLine("Voltando ao Menu...");
                        break;
                }

            } while (op != "0");

        }
    }
}
