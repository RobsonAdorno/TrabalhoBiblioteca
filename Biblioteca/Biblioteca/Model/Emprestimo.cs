using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    [Table("Emprestimos")]
    class Emprestimo
    {
        public Emprestimo()
        {
            NomeLivroEmprestado = new Livro();
            NomeClienteEmprestado = new Cliente();
        }


        [Key]
        public int EmprestimoID { get; set; }
        public Livro NomeLivroEmprestado { get; set; }
        public Cliente NomeClienteEmprestado { get; set; }

        public DateTime DataEmprestimo { get; set; }
    }
}
