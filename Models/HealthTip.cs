using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WorkoutBuddyBackend.Models
{
    public class HealthTip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
    }
}