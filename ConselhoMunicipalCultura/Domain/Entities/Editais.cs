using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("editais")]
    public class Editais : Base
    {
        [Column("idusuario")]
        public int IdUsuario { get; set; }
        [Column("titulo")]
        public string Titulo { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("arquivo")]
        public string Arquivo { get; set; }
    }
}
