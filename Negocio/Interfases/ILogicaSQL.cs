using System;
using System.Collections.Generic;
using System.Text;
using Entidades.Entities;

namespace Negocio.Interfases
{
    public interface ILogicaSQL
    {

        #region Bus

        bool AgregarBus(Bus P_Entidad);
        bool ModificarBus(Bus P_Entidad);
        bool EliminarBus(Bus P_Entidad);
        List<Bus> ConsultarBus(Bus P_Entidad);

        #endregion

        #region Chofer

        bool AgregarChofer(Chofer P_Entidad);
        bool ModificarChofer(Chofer P_Entidad);
        bool EliminarChofer(Chofer P_Entidad);
        List<Chofer> ConsultarChofer(Chofer P_Entidad);

        #endregion

        #region Ruta

        bool AgregarRuta(Ruta P_Entidad);
        bool ModificarRuta(Ruta P_Entidad);
        bool EliminarRuta(Ruta P_Entidad);
        List<Ruta> ConsultarRuta(Ruta P_Entidad);

        #endregion

        #region Recorrido

        bool AgregarRecorrido(Recorrido P_Entidad);
        bool ModificarRecorrido(Recorrido P_Entidad);
        bool EliminarRecorrido(Recorrido P_Entidad);
        List<Recorrido> ConsultarRecorrido(Recorrido P_Entidad);

        #endregion

        #region Usuario

        bool AgregarUsuario(USUARIOS P_Entidad);
        bool ModificarUsuario(USUARIOS P_Entidad);
        bool EliminarUsuario(USUARIOS P_Entidad);
        List<USUARIOS> ConsultarUsuario(USUARIOS P_Entidad);

        #endregion
    }
}
