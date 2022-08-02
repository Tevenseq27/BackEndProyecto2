using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Entities
{
    public class Bitacora
    {

        #region Propiedades
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement("UserId")]
        public string IdUsuario { get; set; }
        [BsonElement("Descripcion")]
        public string descripcion { get; set; }
        #endregion

        #region Constructor
        public Bitacora()
        {
            id = string.Empty;
            IdUsuario = string.Empty;
            descripcion = string.Empty;
        }
        #endregion
    }
}
