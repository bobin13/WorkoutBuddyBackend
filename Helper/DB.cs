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
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {

            var db = client.GetDatabase(dbName);
            return db.GetCollection<T>(collectionName);

        }

        //-----------------------------------------------------------------------------------------------------------------
        //----------------------------Excercise Collection Methods---------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public List<Excercise> GetAllExcercises()
        {
            var collection = GetCollection<Excercise>("excercises");

            var list = collection.Find(_ => true);
            return list.ToList();
        }

        public List<Excercise> GetExcercisesByDifficulty(string difficulty)
        {
            var collection = GetCollection<Excercise>("excercises");

            var list = collection.Find(e => e.difficulty == difficulty);
            return list.ToList();
        }

        public async void InsertMany()
        {

            var collection = GetCollection<Excercise>("excercises");
            BsonDocument bsonElements = BsonDocument.Parse("");
            await collection.InsertManyAsync([]);
        }


        public async void AddExcercise(Excercise excercise)
        {
            var collection = GetCollection<Excercise>("excercises");
            await collection.InsertOneAsync(excercise);
        }

        //-----------------------------------------------------------------------------------------------------------------
        //----------------------------User Collection Methods--------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public List<User> GetAllUsers()
        {
            var collection = GetCollection<User>("users");
            var list = collection.Find(_ => true);

            return list.ToList();
        }

        public Boolean AddUser(User user)
        {
            if (user == null)
                return false;

            var collection = GetCollection<User>("users");
            collection.InsertOne(user);

            return true;
        }
        public User GetUserById(string id)
        {
            var collection = GetCollection<User>("users");
            User user = collection.Find(x => x.id == id).Single();

            return user;
        }


        //-----------------------------------------------------------------------------------------------------------------
        //----------------------------Diet Collection Methods---------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public Boolean AddDiet(Diet diet)
        {
            if (diet == null)
                return false;

            var collection = GetCollection<Diet>("diets");
            collection.InsertOne(diet);

            return true;
        }

        public List<Diet> GetAllDiets()
        {
            var collection = GetCollection<Diet>("diets");
            var list = collection.Find(e => true);

            return list.ToList();

        }

        public List<Diet> GetDietsByVariables(List<int> variables)
        {
            var collection = GetCollection<Diet>("diets");
            var list = collection.Find(e => e.proteinLevel <= variables[0] && e.fatLevel <= variables[1] && e.nutritionLevel <= variables[2]);
            return list.ToList();
        }

        //-----------------------------------------------------------------------------------------------------------------
        //----------------------------HealthTip Collection Methods---------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------------------

        public List<HealthTip> GetAllHealthTips()
        {
            var collection = GetCollection<HealthTip>("health_tips");
            var list = collection.Find(e => true);

            return list.ToList();

        }




    }
}