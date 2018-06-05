using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    [Table("Livros")]
    class Livro
    {
        [Key]
        public int LivroID { get; set; }
        public string NomeLivro { get; set; }
        public string QtPaginas { get; set; }
        public DateTime Data { get; set; }
    }
}
