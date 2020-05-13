using ConsoleApp14.Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace ConsoleApp14.Controller
{
    public class Controller
    {
        MongoClient _client = new MongoClient("mongodb+srv://HaciIsma:haci2002@first-g3ifa.mongodb.net/test?retryWrites=true&w=majority");
        public void Control()
        {
            var database = _client.GetDatabase("sample_training");
            var collection = database.GetCollection<BsonDocument>("Product");

            // collection.InsertOne(new Product { Price = 1550, SKU = 5, Description = ">>>" }.ToBsonDocument());

            var filter = Builders<BsonDocument>.Filter.Eq("Price", 1550);
            var jResults = collection.Find(filter).FirstOrDefault();
            Product pr = BsonSerializer.Deserialize<Product>(jResults);

            System.Console.WriteLine(pr.Price);

        }
    }
}