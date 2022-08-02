using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entities;

namespace Negocio.Interfases
{
    public interface ILogicaMongo
    {
        bool Agregar(Bitacora P_Entidad);
        bool Modificar(Bitacora P_Entidad);
        bool Eliminar(Bitacora P_Entidad);
        List<Bitacora> Consutar(Bitacora P_Entidad);

    }
}
