using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.DAL;

namespace Biblioteca.View
{
    class LivroView
    {

        public static void Executar()
        {
            Livro l = new Livro();

            Console.WriteLine("Qual o nome do Livro?");
            l.NomeLivro = Console.ReadLine();

            Console.WriteLine("Quantas páginas tem o Livro?");
            l.QtPaginas = Console.ReadLine();

            l.Data = DateTime.Now;

            if (LivroDAO.Cadastrar(l))
            {
                Console.WriteLine("Livro cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar o livro");
            }

        }
    }
}
