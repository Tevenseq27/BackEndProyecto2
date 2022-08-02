using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entities;
using Negocio.Interfases;
using AccesoDatos.Interfaces;

namespace Negocio.Clases
{
    public class CLogicaMongo : ILogicaMongo
    {
        #region Atributos
        private readonly IAccesoMongo _iaccesomongo;
        #endregion

        #region Constructor
        public CLogicaMongo(IAccesoMongo P_IAccesoMongo)
        {
            _iaccesomongo = P_IAccesoMongo;
        }
        #endregion

        #region Metodos Bitacora
        bool ILogicaMongo.Agregar(Bitacora P_Entidad)
        {
            return _iaccesomongo.Agregar(P_Entidad);
        }

        List<Bitacora> ILogicaMongo.Consutar(Bitacora P_Entidad)
        {
            return _iaccesomongo.Consutar(P_Entidad);
        }

        bool ILogicaMongo.Eliminar(Bitacora P_Entidad)
        {
            return _iaccesomongo.Eliminar(P_Entidad);
        }

        bool ILogicaMongo.Modificar(Bitacora P_Entidad)
        {
            return _iaccesomongo.Modificar(P_Entidad);
        }
        #endregion
    }
}
