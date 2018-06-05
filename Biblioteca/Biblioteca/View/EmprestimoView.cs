using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAL;

namespace Biblioteca.View
{
    class EmprestimoView
    {
        public static void Executar()
        {
            Emprestimo empres = new Emprestimo();

            Console.WriteLine("Qual o nome do livro que deseja emprestar?");
            empres.NomeLivroEmprestado.NomeLivro = Console.ReadLine();
            if (LivroDAO.BuscarNomeLivro(empres.NomeLivroEmprestado) != null)
            {
                Console.WriteLine("Livro Emprestado com sucesso!");
                Console.WriteLine("Aperte algum botão para continuar a operação!");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Qual o nome do cliente?");
                empres.NomeClienteEmprestado.Nome = Console.ReadLine();
                if (ClienteDAO.BuscarClientePorNome(empres.NomeClienteEmprestado) != null)
                {
                    Console.WriteLine("Cliente encontrado na base com sucesso!");
                    empres.DataEmprestimo = DateTime.Now;
                    EmprestimoDAO.Cadastrar(empres);
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
