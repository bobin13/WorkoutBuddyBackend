using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace WorkoutBuddyBackend.Helper
{
    public class HealthEngine
    {

        public String GetBMI(int height,double weight){
            if(height == 0 && weight == 0.0)
                return "error";

            var bmi = (weight / ((height*height)/10000.0));
            
            if(bmi < 18.5)
                return "underweight";
            else if(bmi >= 18.5 && bmi <= 24.9)
                return "normal";
            else if(bmi >= 25.0 && bmi <= 29.9)
                return "overweight";
            else if(bmi > 30)
                return "obese";
            //deafult value
            return "fat";
        }

        
    }
}