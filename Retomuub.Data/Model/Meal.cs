using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Retomuub.Data.Model
{
    public class Meal
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public List<string> IngredientsId { get; set; } = new List<string>();
    }
}