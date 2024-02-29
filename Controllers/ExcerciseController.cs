using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkoutBuddyBackend.Helper;

namespace WorkoutBuddyBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExcerciseController : ControllerBase
    {
        DB db = new();
        [HttpGet]
        public IActionResult GetAllExcercises(){
            var list = db.GetAllExcercises();

            if(list == null)
                return BadRequest("Error gettings list!");
            
            return Ok(list);
        }
    }
}