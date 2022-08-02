using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Bus
    {
        public Bus()
        {
            Recorrido = new HashSet<Recorrido>();
        }

        public string PlacaUnidad { get; set; }
        public int NumeroUnidad { get; set; }
        public string EstadoUnidad { get; set; }

        public virtual ICollection<Recorrido> Recorrido { get; set; }
    }
}
