using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class Tarea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdTarea { get; set; }
        [Required]
        [MaxLength(100)]
        public string DescripcionTarea { get; set; }
        [Required]
        public DateTime FechaTarea { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
    }
}
