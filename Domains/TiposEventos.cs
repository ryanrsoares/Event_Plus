using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_plus.Domains
{
    [Table("TiposEventos")]
    public class TiposEventos
    {
        [Key]

        public Guid TipoEventoID { get; set; }

        [Column(TypeName = "VARCHAR (100)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório!")]

        public string? TituloTipoEvento { get; set; }
    }
}
