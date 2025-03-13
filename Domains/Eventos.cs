using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Event_plus.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]

        public Guid EventoID { get; set; }


        [Column(TypeName  = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória")]

        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome do evento é obrigatório")]

        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A descrção do evento é obrigatória")]

        public string? Descricao { get; set; }

        [Required(ErrorMessage = "O tipo do evento é obrigatório!")]
        public Guid TipoEventoID { get; set; }

        [ForeignKey ("TipoEventoID")]

        public TiposEventos? TipoEvento { get; set; }


        [Required(ErrorMessage = "A instituição é obrigatória!")]
        public Guid InstituicaoID { get; set; }


        [ForeignKey("InstituicaoID")]

        public Instituicoes? InstuicoesID { get; set; }

        public PresencasEventos? PresencasEventos { get; set; }
    }
}
