using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkoutBuddyBackend.Models
{
    public class HealthPlan
    {
        public List<Excercise> excercises { get; set; }
        public List<Diet> diets { get; set; }
        public List<HealthTip> healthTips { get; set; }
    }
}