using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("documentosusuarios")]
    public class DocumentosUsuarios : Base
    {
        [Column("idusuario")]
        public int IdUsuario { get; set; }
        [Column("idtema")]
        public int IdTema { get; set; }
        [Column("nomeprojeto")]
        public string NomeProjeto { get; set; }
        [Column("descricao")]
        public string Descricao { get; set; }
        [Column("objetivo")]
        public string Objetivo { get; set; }

    }
}
