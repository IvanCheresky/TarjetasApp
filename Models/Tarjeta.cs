﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetasApp.Models
{
    public class Tarjeta
    {
        [Key]
        [ForeignKey("Persona")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTarjeta { get; set; }
        [MaxLength(50)]
        [Required]
        public string Nombre { get; set; }
        [MaxLength(50)]
        [Required]
        public string Numero { get; set; }
        [MaxLength(50)]
        [Required]
        public int IdPersona { get; set; }
        public virtual Persona Persona { get; set; }
    }
    public enum Marca
    {
        SQUA,
        SCO,
        PERE
    }
}
