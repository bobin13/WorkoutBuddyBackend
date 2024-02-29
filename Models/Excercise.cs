using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorkoutBuddyBackend.Models
{
    public class Excercise
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }
        public string name { get; set; }
        public string type { get; set; } 
        public string muscle { get; set; }
        public string equipment { get; set; }
        public string difficulty { get; set; }
        public string instructions { get; set; }
        public string imageUrl { get; set; }
        public string videoUrl { get; set; }
    }
}