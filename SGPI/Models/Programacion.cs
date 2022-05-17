using System;

#nullable disable

namespace SGPI.Models
{
    public partial class Programacion
    {
        public int IdProgramacion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? Bloque { get; set; }
        public string Salon { get; set; }
        public string Semestre { get; set; }
        public int? IdModulo { get; set; }

        public virtual Modulo IdModuloNavigation { get; set; }
    }
}
