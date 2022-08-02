using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entities;

namespace AccesoDatos.Interfaces
{
    public interface IAccesoMongo
    {
        bool Agregar(Bitacora P_Entidad);
        bool Modificar(Bitacora P_Entidad);
        bool Eliminar(Bitacora P_Entidad);
        List<Bitacora> Consutar(Bitacora P_Entidad);
    }
}
