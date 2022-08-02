using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Recorrido
    {
        public int Id { get; set; }
        public int IdRutaAsignada { get; set; }
        public string PlacaUnidadAsignada { get; set; }
        public string IdChoferAsignado { get; set; }
        public string Estado { get; set; }
        public int? MontoRecibido { get; set; }

        public virtual Chofer IdChoferAsignadoNavigation { get; set; }
        public virtual Ruta IdRutaAsignadaNavigation { get; set; }
        public virtual Bus PlacaUnidadAsignadaNavigation { get; set; }
    }
}
