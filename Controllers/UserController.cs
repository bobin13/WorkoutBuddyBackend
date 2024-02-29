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
    public class UserController : ControllerBase
    {
        DB db = new();
        [HttpGet]
        public IActionResult GetAllUsers(){

            var users = db.GetAllUsers();
            return Ok(users);
        }
    }
}