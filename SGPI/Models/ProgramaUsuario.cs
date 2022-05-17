using System.Collections.Generic;

#nullable disable

namespace SGPI.Models
{
    public partial class ProgramaUsuario
    {
        public ProgramaUsuario()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int IdProgramaUsuario { get; set; }
        public int? IdPrograma { get; set; }

        public virtual Programa IdProgramaNavigation { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
