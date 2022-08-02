using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Negocio.Interfases;
using AccesoDatos;
using Entidades.Entities;

namespace WebApi.Controllers
{

    [Route("api/Proyecto2")]
    [ApiController]
    public class ProjectController : Controller
    {
        #region Atributos
        private readonly ILogicaSQL _ilogica;
        private readonly ILogicaMongo _logicamongo;

        #endregion

        #region Constructor
        public ProjectController(ILogicaSQL ilogica, ILogicaMongo ilogicamongo)
        {
            _ilogica = ilogica;
            _logicamongo = ilogicamongo;
        }

        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Metodos 

        #region Metodos SQL

        #region Bus
        [HttpPost]
        [Route(nameof(AgregarBus))]
        public bool AgregarBus(Bus P_Entidad)
        {
            return _ilogica.AgregarBus(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarBus))]
        public IEnumerable<Bus> ConsultarBus()
        {
            Bus P_Entidad = new Bus();
            return _ilogica.ConsultarBus(P_Entidad).ToList();
        }

        [HttpPost]
        [Route(nameof(ModificarBus))]
        public bool ModificarBus(Bus Entidad)
        {
            return _ilogica.ModificarBus(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarBus))]
        public bool EliminarBus(Bus Entidad)
        {
            return _ilogica.EliminarBus(Entidad);
        }
        #endregion

        #region Chofer
        [HttpPost]
        [Route(nameof(AgregarChofer))]
        public bool AgregarChofer(Chofer P_Entidad)
        {
            return _ilogica.AgregarChofer(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarChofer))]
        public IEnumerable<Chofer> ConsultarChofer()
        {
            Chofer P_Entidad = new Chofer();
            return _ilogica.ConsultarChofer(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarChofer))]
        public bool ModificarChofer(Chofer Entidad)
        {
            return _ilogica.ModificarChofer(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarChofer))]
        public bool EliminarChofer(Chofer Entidad)
        {
            return _ilogica.EliminarChofer(Entidad);
        }
        #endregion

        #region Perfil
        [HttpPost]
        [Route(nameof(AgregarPerfil))]
        public bool AgregarPerfil(Perfil P_Entidad)
        {
            return _ilogica.AgregarPerfil(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarPerfil))]
        public IEnumerable<Perfil> ConsultarPerfil(Perfil P_Entidad)
        {
            return _ilogica.ConsultarPerfil(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarPerfil))]
        public bool ModificarPerfil(Perfil Entidad)
        {
            return _ilogica.ModificarPerfil(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarPerfil))]
        public bool EliminarPerfil(Perfil Entidad)
        {
            return _ilogica.EliminarPerfil(Entidad);
        }
        #endregion

        #region Recorrido
        [HttpPost]
        [Route(nameof(AgregarRecorrido))]
        public bool AgregarRecorrido(Recorrido P_Entidad)
        {
            return _ilogica.AgregarRecorrido(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarRecorrido))]
        public IEnumerable<Recorrido> ConsultarRecorrido(Recorrido P_Entidad)
        {
            return _ilogica.ConsultarRecorrido(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarRecorrido))]
        public bool ModificarRecorrido(Recorrido Entidad)
        {
            return _ilogica.ModificarRecorrido(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarRecorrido))]
        public bool EliminarRecorrido(Recorrido Entidad)
        {
            return _ilogica.EliminarRecorrido(Entidad);
        }
        #endregion

        #region Ruta
        [HttpPost]
        [Route(nameof(AgregarRuta))]
        public bool AgregarRuta(Ruta P_Entidad)
        {
            return _ilogica.AgregarRuta(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarRuta))]
        public IEnumerable<Ruta> ConsultarRuta(Ruta P_Entidad)
        {
            return _ilogica.ConsultarRuta(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarRuta))]
        public bool ModificarRuta(Ruta Entidad)
        {
            return _ilogica.ModificarRuta(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarRuta))]
        public bool EliminarRuta(Ruta Entidad)
        {
            return _ilogica.EliminarRuta(Entidad);
        }
        #endregion

        #region Usuario
        [HttpPost]
        [Route(nameof(AgregarUsuario))]
        public bool AgregarUsuario(Usuario P_Entidad)
        {
            return _ilogica.AgregarUsuario(P_Entidad);
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuario))]
        public IEnumerable<Usuario> ConsultarUsuario(Usuario P_Entidad)
        {
            return _ilogica.ConsultarUsuario(P_Entidad);
        }

        [HttpPost]
        [Route(nameof(ModificarUsuario))]
        public bool ModificarUsuario(Usuario Entidad)
        {
            return _ilogica.ModificarUsuario(Entidad);
        }

        [HttpPost]
        [Route(nameof(EliminarUsuario))]
        public bool EliminarUsuario(Usuario Entidad)
        {
            return _ilogica.EliminarUsuario(Entidad);
        }
        #endregion

        #endregion

        #region Metodos Mongo

        [HttpPost]
        [Route(nameof(AgregarBitacora))]
        public bool AgregarBitacora(Bitacora P_Entidad)
        {
            return _logicamongo.Agregar(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(ModificarBitacora))]
        public bool ModificarBitacora(Bitacora P_Entidad)
        {
            return _logicamongo.Modificar(P_Entidad);
        }
        [HttpPost]
        [Route(nameof(EliminarBitacora))]
        public bool EliminarBitacora(Bitacora P_Entidad)
        {
            return _logicamongo.Eliminar(P_Entidad);
        }
        [HttpGet]
        [Route(nameof(ConsultarBitacora))]
        public IEnumerable<Bitacora> ConsultarBitacora()
        {
            Bitacora u = new Bitacora();
            return _logicamongo.Consutar(u).ToList();
        }

        #endregion

        #endregion

    }
}
