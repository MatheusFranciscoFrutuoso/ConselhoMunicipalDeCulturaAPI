using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("usuario")]
    public class Usuario : Base
    {
        [Column("nome")]
        public string Nome { get; set; }
        [Column("senha")]
        public string Senha { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("email")]
        public string Email { get; set; }
    }
}
