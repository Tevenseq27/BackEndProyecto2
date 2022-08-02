using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Usuario
    {
        public string IdUsuario { get; set; }
        public string Nombre1Usuario { get; set; }
        public string Nombre2Usuario { get; set; }
        public string Apellido1Usuario { get; set; }
        public string Apellido2Usuario { get; set; }
        public string CorreoUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public int CodPerfilUsuario { get; set; }

        public virtual Perfil CodPerfilUsuarioNavigation { get; set; }
    }
}
