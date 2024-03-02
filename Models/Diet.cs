using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WorkoutBuddyBackend.Models
{
    public class Diet
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public required string id { get; set; }
        public string name { get; set; }
        public int weight { get; set; } //weight in grams
        public string timeOfDay { get; set; } //what time to consume it if there is, morning-afternoon-night
    }
}