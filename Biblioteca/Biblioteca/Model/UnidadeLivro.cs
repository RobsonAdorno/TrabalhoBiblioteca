using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    [Table("Unidades")]
    class UnidadeLivro
    {
        [Key]
        public int UnidadeID { get; set; }
        public Livro Livro { get; set; }
        public int Unidade { get; set; }
    }
}
