using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ConsoleApp14.Model
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("SKU")]
        public int SKU { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("Price")]
        public Double Price { get; set; }
    }
}
