using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using WorkoutBuddyBackend.Helper;

namespace WorkoutBuddyBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : ControllerBase
    {
        HealthEngine healthEngine = new();
        DB db = new();
        
        [HttpGet]
        public IActionResult test(){
            int height = default;
            double weight = default;
            

            return Ok(healthEngine.GetBMI(183,95));
        }
    }
}
