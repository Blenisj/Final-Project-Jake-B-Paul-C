using Final_Project.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MembersController : Controller
    {
       ITM ctx;

        public MembersController(ITM context)
        {
            ctx = context;
        }

        
        [HttpGet]
        [Route("api/findmembers")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllMembers());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetMembersById(id));
        }

        [HttpPost]
        public IActionResult Post(TeamMember tm)
        {
            var result = ctx.AddMember(tm);
            if (result == null)
            {
                return StatusCode(500, "this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TeamMember tm)
        {
            var result = ctx.UpdateMembers(tm);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var result = ctx.GetMembersById(id);
            if (result == null)
            {
                return NotFound(id);
            }
            var del = ctx.RemoveMembersById(id);
            if (del == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
    
    [Route("api/[controller]")]
    [ApiController]
    public class HobbyController : ControllerBase
    {
        private readonly IH ctx;

        public HobbyController(IH context)
        {
            ctx = context;
        }


        [HttpGet]
        [Route("api/gethobbys")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllHobbys());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetHobbysById(id));
        }

        [HttpPost]
        public IActionResult Post(Hobby h)
        {
            var result = ctx.AddHobby(h);
            if (result == null)
            {
                return StatusCode(500, " this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Hobby h)
        {
            var result = ctx.UpdateHobbys(h);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetHobbysById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveHobbysById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFF ctx;

        public FoodController(IFF context)
        {
            ctx = context;
        }


        [HttpGet]
        [Route("api/gethobbys")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllFoods());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetFoodsById(id));
        }

        [HttpPost]
        public IActionResult Post(FavoriteFood h)
        {
            var result = ctx.AddFood(h);
            if (result == null)
            {
                return StatusCode(500, "A this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(FavoriteFood h)
        {
            var result = ctx.UpdateFoods(h);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetFoodsById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveFoodsById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly IFT ctx;

        public TeamController(IFT context)
        {
            ctx = context;
        }


        [HttpGet]
        [Route("api/gethobbys")]
        public IActionResult Get()
        {
            return Ok(ctx.GetAllTeams());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(ctx.GetTeamsById(id));
        }

        [HttpPost]
        public IActionResult Post(FavoriteTeam h)
        {
            var result = ctx.AddTeam(h);
            if (result == null)
            {
                return StatusCode(500, "this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(FavoriteTeam h)
        {
            var result = ctx.UpdateTeams(h);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("id")]
        [Route("api/delete")]
        public IActionResult Delete(int id)
        {
            var product = ctx.GetTeamsById(id);
            if (product == null)
            {
                return NotFound(id);
            }
            var result = ctx.RemoveTeamsById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }
    }
}