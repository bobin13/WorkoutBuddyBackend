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
        public int proteinLevel { get; set; } //level of protein from 1-3 1 being low 3 being high.
        public int fatLevel { get; set; }
        public int nutritionLevel { get; set; }
        public int weight { get; set; } //weight in grams
        //public string timeOfDay { get; set; } //what time to consume it if there is, morning-afternoon-night
    }
}