using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutBuddyBackend.Helper;
using WorkoutBuddyBackend.Models;

namespace WorkoutBuddyBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DietController : ControllerBase
    {
        DB db = new();
        HealthEngine healthEngine = new();

        [HttpGet("{bmi}")]
        public IActionResult GetInitialDiet(double bmi)
        {
            var diets = healthEngine.GetDiets(bmi);
            return Ok(diets);
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var list = db.GetAllDiets();
            return Ok(list);
        }

        [HttpPost]
        public IActionResult AddDiet([FromBody] Diet diet)
        {
            if (diet == null)
                return BadRequest();

            db.AddDiet(diet);

            return Ok(diet);

        }
    }
}