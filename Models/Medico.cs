using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCClinica.Models
{
    public class Medico
    {
        public int Id { get; set; }


        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(70)]
        public string Especialidad { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int NroMatricula { get; set; }
    }
}