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
    public class UserController : ControllerBase
    {
        DB db = new();
        HealthEngine healthEngine = new HealthEngine();
        [HttpGet]
        public IActionResult GetAllUsers()
        {

            var users = db.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(string id)
        {
            Console.WriteLine(id);
            var user = db.GetUserById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {

            if (user == null)
                return BadRequest("Invalid user object!");

            user.healthTips = healthEngine.GenerateHealthTips();
            if (db.AddUser(user))
                return Ok(user);

            return BadRequest("Error occured while adding user.");
        }

        [HttpGet("healthTips/{id}")]
        public IActionResult GetUserHealthTips(string id)
        {
            var user = db.GetUserById(id);
            if (user == null)
                return NotFound("User Not Found!");
            if (user.healthTips == null || user.healthTips.Count == 0)
                user.healthTips = healthEngine.GenerateHealthTips();

            return Ok(user.healthTips);
        }
    }
}