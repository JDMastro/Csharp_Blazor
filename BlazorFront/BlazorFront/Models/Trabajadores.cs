using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorFront.Models
{
    public class Trabajadores
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Salario { get; set; }
        public int AreasId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Sexo { get; set; }
        public int EmpresasId { get; set; }
    }
}
