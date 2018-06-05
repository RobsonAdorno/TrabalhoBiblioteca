﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    [Table("Cliente")]
    class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public DateTime Data { get; set; }
    }
}
