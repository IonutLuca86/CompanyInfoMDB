using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfoMongoDB.Data
{
    public class Departaments
    {
        [BsonId]
        public ObjectId departamentId { get; set; }
        [BsonElement("departament_name")]
        public string DepartamentName { get; set; } = string.Empty;
        [BsonElement("company_id")]
        [BsonRequired]
        public Company? Company { get; set; }


    }
}
