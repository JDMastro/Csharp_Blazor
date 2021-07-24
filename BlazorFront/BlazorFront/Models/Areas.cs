using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFront.Models
{
    public class Areas
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es requerido un nombre para el area")]
        /*[CheckDescriptionArea]*/
        public string Descripcion { get; set; }

        public int TrabajadoresId { get; set; }
    }
}
