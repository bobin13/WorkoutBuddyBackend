using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using WorkoutBuddyBackend.Models;

namespace WorkoutBuddyBackend.Helper
{
    public class HealthEngine
    {
        DB db = new();

        //return bmi as a double
        public double GetBMI(int height, double weight)
        {
            if (height == 0 && weight == 0.0)
                return 0;

            var bmi = (weight / ((height * height) / 10000.0));
            return bmi;

        }

        //returns a string to depict health status of a user.
        public string GetBMIState(double bmi)
        {
            if (bmi < 18.5)
                return "underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "normal";
            else if (bmi >= 25.0 && bmi <= 29.9)
                return "overweight";
            else if (bmi > 30)
                return "obese";
            //default value
            return "Easy on them Sandwiches my Guy!!";
        }

        //returns 3 integers representing protein,fat and nutrition level respectively.
        public List<int> GetDietVariables(double bmi)
        {
            List<int> variables = [];
            var fatState = GetBMIState(bmi);
            if (fatState == "underweight")
            {
                variables.Add(3);
                variables.Add(3);
                variables.Add(3);
            }
            else if (fatState == "normal")
            {
                variables.Add(2);
                variables.Add(2);
                variables.Add(2);
            }
            else if (fatState == "overweight")
            {
                variables.Add(1);
                variables.Add(1);
                variables.Add(3);
            }
            else if (fatState == "obese")
            {
                variables.Add(1);
                variables.Add(1);
                variables.Add(1);
            }
            return variables;
        }

        public HealthPlan GetHealthPlan(string bmiState)
        {
            var list = 0;

            return null;
        }

        public List<Excercise> GetExcercises(string difficulty)
        {
            if (difficulty == "")
            {
                return db.GetAllExcercises();
            }

            var list = db.GetExcercisesByDifficulty(difficulty);
            return list.ToList();
        }

        public List<Diet> GetDiets(double bmi)
        {
            var dietVaribles = GetDietVariables(bmi);
            var list = db.GetDietsByVariables(dietVaribles);

            return null;

        }

        //HealthTips Specific to a user
        public List<HealthTip> GetHealthTips(User user)
        {

            var list = db.GetAllHealthTips();
            return list.ToList();

        }

        //returns all HealthTips from DataBase
        public List<HealthTip> GenerateHealthTips(double bmi)
        {
            //returning 5 random Tips for now. Logic to be implemented.
            Random random = new();

            var list = GetHealthTips(null).OrderBy(x => random.Next()).Take(5);
            return list.ToList();
        }


    }
}