using Entidades.Entities;
using Negocio.Interfases;
using System;
using System.Collections.Generic;
using System.Text;
using AccesoDatos.Interfaces;


namespace Negocio.Clases
{
    public class CLogicaSQL : ILogicaSQL
    {
        #region Atributos
        private readonly IAccesoSQL _iaccesoSQL;

        #endregion

        #region Constructor
        public CLogicaSQL(IAccesoSQL iaccesoSQL)
        {
            _iaccesoSQL = iaccesoSQL;
        }

        #endregion

        #region Metodos

        #region Bus
        public bool AgregarBus(Bus P_Entidad)
        {
            return _iaccesoSQL.AgregarBus(P_Entidad);
        }

        public bool ModificarBus(Bus P_Entidad)
        {
            return _iaccesoSQL.ModificarBus(P_Entidad);
        }

        public bool EliminarBus(Bus P_Entidad)
        {
            return _iaccesoSQL.EliminarBus(P_Entidad);
        }

        public List<Bus> ConsultarBus(Bus P_Entidad)
        {
            return _iaccesoSQL.ConsultarBus(P_Entidad);
        }

        #endregion

        #region Chofer
        public bool AgregarChofer(Chofer P_Entidad)
        {
            return _iaccesoSQL.AgregarChofer(P_Entidad);
        }

        public List<Chofer> ConsultarChofer(Chofer P_Entidad)
        {
            return _iaccesoSQL.ConsultarChofer(P_Entidad);
        }

        public bool EliminarChofer(Chofer P_Entidad)
        {
            return _iaccesoSQL.EliminarChofer(P_Entidad);
        }

        public bool ModificarChofer(Chofer P_Entidad)
        {
            return _iaccesoSQL.ModificarChofer(P_Entidad);
        }

        #endregion

        #region Perfil
        public bool AgregarPerfil(Perfil P_Entidad)
        {
            return _iaccesoSQL.AgregarPerfil(P_Entidad);
        }

        public List<Perfil> ConsultarPerfil(Perfil P_Entidad)
        {
            return _iaccesoSQL.ConsultarPerfil(P_Entidad);
        }

        public bool EliminarPerfil(Perfil P_Entidad)
        {
            return _iaccesoSQL.EliminarPerfil(P_Entidad);
        }

        public bool ModificarPerfil(Perfil P_Entidad)
        {
            return _iaccesoSQL.ModificarPerfil(P_Entidad);
        }

        #endregion

        #region Recorrido
        public bool AgregarRecorrido(Recorrido P_Entidad)
        {
            return _iaccesoSQL.AgregarRecorrido(P_Entidad);
        }

        public List<Recorrido> ConsultarRecorrido(Recorrido P_Entidad)
        {
            return _iaccesoSQL.ConsultarRecorrido(P_Entidad);
        }

        public bool EliminarRecorrido(Recorrido P_Entidad)
        {
            return _iaccesoSQL.EliminarRecorrido(P_Entidad);
        }

        public bool ModificarRecorrido(Recorrido P_Entidad)
        {
            return _iaccesoSQL.ModificarRecorrido(P_Entidad);
        }

        #endregion

        #region Ruta
        public bool AgregarRuta(Ruta P_Entidad)
        {
            return _iaccesoSQL.AgregarRuta(P_Entidad);
        }

        public List<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            return _iaccesoSQL.ConsultarRuta(P_Entidad);
        }

        public bool EliminarRuta(Ruta P_Entidad)
        {
            return _iaccesoSQL.EliminarRuta(P_Entidad);
        }

        public bool ModificarRuta(Ruta P_Entidad)
        {
            return _iaccesoSQL.ModificarRuta(P_Entidad);
        }

        #endregion

        #region Usuarios
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            return _iaccesoSQL.AgregarUsuario(P_Entidad);
        }
        public List<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            return _iaccesoSQL.ConsultarUsuario(P_Entidad);
        }
        public bool EliminarUsuario(Usuario P_Entidad)
        {
            return _iaccesoSQL.EliminarUsuario(P_Entidad);
        }

        public bool ModificarUsuario(Usuario P_Entidad)
        {
            return _iaccesoSQL.ModificarUsuario(P_Entidad);
        }
        #endregion
    }

    #endregion
}
