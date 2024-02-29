using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace WorkoutBuddyBackend.Models
{
    public class Diet
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public required string Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; } //weight in grams
        public string TimeOfDay { get; set; } //what time to consume it if there is, morning-afternoon-night
    }
}