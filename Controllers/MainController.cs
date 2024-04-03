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
        public IActionResult test()
        {
            //var list = db.GetDietsByVariables(healthEngine.GetDietVariables(15.0));

            var list = db.GetAllHealthTips();
            return Ok(list);
        }
    }
}
