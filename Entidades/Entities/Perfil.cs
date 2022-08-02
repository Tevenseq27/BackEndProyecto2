using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Perfil
    {
        public Perfil()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int CodigoPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
