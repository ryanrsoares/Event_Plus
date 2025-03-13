﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Event_plus.Domains
{
    [Table("Usuarios")]
    [Index(nameof(Email), IsUnique = true)]
    public class Usuarios
    {
        [Key]
        public Guid UsuarioID { get; set; }


        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome é obrigatório!")]

        public string? Nome { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O email é obrigatório!")]

        public string? Email { get; set; }
        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A senha é obrigatória")]
        [StringLength(60, MinimumLength = 6, ErrorMessage ="a senha deve conter no mínimo 6 caracteres e no máximo 60")]

        public string? senha { get; set; }

        [Required(ErrorMessage = "O tipo usuário é obrigatório!")]

        public Guid TipoUsuarioID { get; set; }

        [ForeignKey ("TipoUsuarioID")]
        public TiposUsuarios? TiposUsuarios { get; set; }

    }
}
