using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using WorkoutBuddyBackend.Models;

namespace WorkoutBuddyBackend.Helper
{
    public class DB
    {
        MongoClient client = new("mongodb+srv://bobin13:4K8J276bWqmd5iBr@cluster0.wi0uk9y.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
        string dbName = "workout_buddy";

        //returns a collection, takes name of collection as a parameter.
        public IMongoCollection<T> GetCollection<T>(string collectionName){

            var db = client.GetDatabase(dbName);
            return db.GetCollection<T>(collectionName);
        
        }

        public List<Excercise> GetAllExcercises(){
            var collection = GetCollection<Excercise>("excercises");
            Console.WriteLine(0);
            var list = collection.Find(_ => true);         
            return list.ToList();
        }
        public List<User> GetAllUsers(){
            var collection = GetCollection<User>("users");
            var list = collection.Find(_ => true);
           
            return list.ToList();
        }

        public async void InsertMany(){
                
            var collection = GetCollection<Excercise>("excercises");
            BsonDocument bsonElements = BsonDocument.Parse("");
            await collection.InsertManyAsync([]);
        }


        public async void AddExcercise(Excercise excercise){
             var collection = GetCollection<Excercise>("excercises");
             await collection.InsertOneAsync(excercise);
        }
    }
}