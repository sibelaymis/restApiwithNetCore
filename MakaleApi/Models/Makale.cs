using MakaleApi.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakaleApi.Models
{
    public class Makale:MongoBaseModel

    {
        

        [BsonElement("Name")]
        public string Name { get; set; }


        public string Author { get; set; }
    }

}
