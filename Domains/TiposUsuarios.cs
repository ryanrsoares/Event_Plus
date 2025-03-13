using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_plus.Domains
{
    [Table("TiposUsuarios")]
    public class TiposUsuarios
    {
        [Key]
        public Guid TipoUsuarioID { get; set; }

        [Column(TypeName = "VARCHAR (15)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string? TituloTipoUsuario {  get; set; }
    }
}
