using AccesoDatos.Interfaces;
using Entidades.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public class AaccesoMongo : IAccesoMongo
    {
        #region Atributos

       // private readonly string CadenaConexion = @"mongodb+srv://DataBaseDaf:123456Aa@cluster0.40wct.mongodb.net/BitacoraProyecto2?retryWrites=true&w=majority";
        private readonly string CadenaConexion = @"mongodb://localhost:27017/BitacoraProyecto2";
        private MongoClient InstaciaBD;
        private IMongoDatabase BaseDatos;
        private const string NombreBD = "BitacoraProyecto2";

        #endregion

        #region Metodos

        #region Metodo Privados
 
        private bool ObtenerConexion()
        {
            bool ConexionCorrecta = false;
            try
            {
                InstaciaBD = new MongoClient(CadenaConexion);
                BaseDatos = InstaciaBD.GetDatabase(NombreBD);
                ConexionCorrecta = BaseDatos.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait(1000);
            }
            catch (MongoException exMG)
            {
                throw exMG;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ConexionCorrecta;
        }
        private void LimpiarArtibutosGlobales()
        {
            if (InstaciaBD != null)
                InstaciaBD = null;
            if (BaseDatos != null)
                BaseDatos = null;
        }

        #endregion

        #region Metodos Publicos
        public bool Agregar(Bitacora P_Entidad)
        {
            ObtenerConexion();
            var Coleccion = BaseDatos.GetCollection<Bitacora>("Bitacora");
            Coleccion.InsertOne(P_Entidad);
            LimpiarArtibutosGlobales();
            return true;
        }

        public List<Bitacora> Consutar(Bitacora P_Entidad)
        {
            ObtenerConexion();
            var Coleccion = BaseDatos.GetCollection<Bitacora>("Bitacora");
            if (P_Entidad != null)
                if (!string.IsNullOrEmpty(P_Entidad.id))
                    return Coleccion.Find(d => d.id == P_Entidad.id).ToList();
                else
                    return Coleccion.Find(d => true).ToList();
            else
                return Coleccion.Find(d => true).ToList();
        }

        public bool Eliminar(Bitacora P_Entidad)
        {
            ObtenerConexion();
            var Coleccion = BaseDatos.GetCollection<Bitacora>("Bitacora");
            Coleccion.DeleteOne(d => d.id == P_Entidad.id);
            LimpiarArtibutosGlobales();
            return true;
        }

        public bool Modificar(Bitacora P_Entidad)
        {
            ObtenerConexion();
            var Coleccion = BaseDatos.GetCollection<Bitacora>("Bitacora");
            Coleccion.ReplaceOne(d => d.id == P_Entidad.id, P_Entidad);
            LimpiarArtibutosGlobales();
            return true;
        }
        #endregion

        #endregion
    }
}
