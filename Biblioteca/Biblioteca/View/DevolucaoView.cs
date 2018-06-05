using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL;
using Biblioteca.Model;

namespace Biblioteca.View
{
    class DevolucaoView
    {

       public static void Executar()
        {
            Devolucao dev = new Devolucao();

            Console.WriteLine("Qual o nome do livro que deseja emprestar?");
           dev.NomeLivroDevolvido.NomeLivro = Console.ReadLine();
            if (LivroDAO.BuscarNomeLivro(dev.NomeLivroDevolvido) != null)
            {
                Console.WriteLine("Livro Emprestado com sucesso!");
                Console.WriteLine("Aperte algum botão para continuar a operação!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Qual o nome do cliente?");
                dev.NomeClienteDevolvido.Nome = Console.ReadLine();
                if (ClienteDAO.BuscarClientePorNome(dev.NomeClienteDevolvido) != null)
                {
                    Console.WriteLine("Cliente encontrado na base com sucesso!");
                   dev.DataDevolucao = DateTime.Now;
                    DevolucaoDAO.Cadastrar(dev);
                }
                else
                {
                    Console.WriteLine("Por favor, cadastrar o cliente");
                }

            }
            else
            {
                Console.WriteLine("Erro ao realizar o emprestimo, esse livro não está emprestado!");
            }

            Console.WriteLine("Pressione algum botão para voltar ao Menu anterior!");
            Console.ReadKey();
        }
    }

    }
}
