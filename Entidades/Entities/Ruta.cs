using System;
using System.Collections.Generic;

namespace Entidades.Entities
{
    public partial class Ruta
    {
        public Ruta()
        {
            Recorrido = new HashSet<Recorrido>();
        }

        public int IdRuta { get; set; }
        public string TerminalSalida { get; set; }
        public string TerminalLlegada { get; set; }
        public int CantidadParadas { get; set; }
        public int MontoEstimadoRuta { get; set; }

        public virtual ICollection<Recorrido> Recorrido { get; set; }
    }
}
