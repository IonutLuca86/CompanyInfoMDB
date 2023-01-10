using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyInfoMongoDB.Data
{
    public class Company
    {
        [BsonId]
        public ObjectId companyId { get; set; }

        [BsonElement("company_name")]
        public string CompanyName { get; set; } = string.Empty;
        [BsonElement("org_nr")]
        public string OrganisationNummer { get; set;} = string.Empty;
        [BsonElement("main_office")]
        public string MainOffice { get; set; } = string.Empty;

    }
}
