using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Usuario
    {
        public int ID_USUARIO { get; set; }
        public string EMAIL { get; set; }
        public string PASS { get; set; }
        public string SALT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDOS { get; set; }
        public string TIPO { get; set; }

    }
}
