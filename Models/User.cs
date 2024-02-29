using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WorkoutBuddyBackend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public required string Id { get; set; }

        [BsonElement("name")]
        public required string name { get; set; }
        public required string username { get; set; }
        public string  password { get; set; }
        public required string email { get; set; }
        public int height { get; set; }
        public double weight { get; set; }
        public double desiredWeight { get; set; }
        
        public List<Excercise> excercises { get; set; }
        public  List<Diet> diets { get; set; }
    }
}