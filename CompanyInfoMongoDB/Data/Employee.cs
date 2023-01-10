using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfoMongoDB.Data
{
    public class Employee
    {
        [BsonId]
        public ObjectId employeeID { get; set; }
        [BsonElement("first_name")]
        public string FirstName { get; set;} = string.Empty;
        [BsonElement("last_name")]
        public string LastName { get; set; } = string.Empty;
        [BsonElement("position")]
        public string[] Position { get; set; } = new string[0];
        [BsonElement("departament_id")]
        public Departaments? Departament { get; set; }
        [BsonElement("salary")]
        public decimal Salary { get; set; }
        [BsonElement("union_member")]
        public bool UnionMember { get; set; }

    }
}
