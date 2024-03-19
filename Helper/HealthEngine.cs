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
        DB dB = new();

        public double GetBMI(int height,double weight){
            if(height == 0 && weight == 0.0)
                return 0;

            var bmi = (weight / ((height*height)/10000.0));
            return bmi;
           
        }

        public string GetBMIState(double bmi){
             if(bmi < 18.5)
                return "underweight";
            else if(bmi >= 18.5 && bmi <= 24.9)
                return "normal";
            else if(bmi >= 25.0 && bmi <= 29.9)
                return "overweight";
            else if(bmi > 30)
                return "obese";
            //deafult value
            return "Easy on them Sandwiches my Guy!!";
        }

        public HealthPlan GetExcercisePlan(string bmiState){
            var list = 0;
            // switch (bmiState){
            //     case "underweight":

            // }

            return null;
        }

        public List<Excercise> GetExcercises(string difficulty){
            return null;
        }

        

        
    }
}