using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Chofer
    {
        public Chofer()
        {
            Recorrido = new HashSet<Recorrido>();
        }

        public string IdChofer { get; set; }
        public string Nombre1Chofer { get; set; }
        public string Nombre2Chofer { get; set; }
        public string Apellido1Chofer { get; set; }
        public string Apellido2Chofer { get; set; }
        public string TelefonoChofer { get; set; }

        public virtual ICollection<Recorrido> Recorrido { get; set; }
    }
}
