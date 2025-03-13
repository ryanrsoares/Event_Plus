using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Event_plus.Domains
{
    [Table("PresencasEventos")]
    public class PresencasEventos
    {
        [Key]
        public Guid IdPresenca {  get; set; }

        [Column(TypeName = "BIT")]
        public bool? Situacao { get; set; }

        [Required(ErrorMessage = "O evento é obrigatório!")]
        public Guid EventoID { get; set; }

        [ForeignKey("EventoID")]

        public Eventos? Eventos { get; set; }

        [Required(ErrorMessage = "O usuário é obrigatório!")]
        public Guid UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]

        public Usuarios? Usuario { get; set; }

    }
}
