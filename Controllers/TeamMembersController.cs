using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TeamMembersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TeamMembersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TeamMember>>> GetTeamMembers(int? id)
    {
        if (id == null || id == 0)
        {
            return await _context.TeamMembers.Take(5).ToListAsync();
        }
        else
        {
            return await _context.TeamMembers.FindAsync(id);
        }
    }

    [HttpPost]
    public async Task<ActionResult<TeamMember>> PostTeamMember(TeamMember teamMember)
    {
        _context.TeamMembers.Add(teamMember);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTeamMembers), new { id = teamMember.Id }, teamMember);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTeamMember(int id, TeamMember teamMember)
    {
        if (id != teamMember.Id)
        {
            return BadRequest();
        }

        _context.Entry(teamMember).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TeamMemberExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTeamMember(int id)
    {
        var teamMember = await _context.TeamMembers.FindAsync(id);
        if (teamMember == null)
        {
            return NotFound();
        }

        _context.TeamMembers.Remove(teamMember);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TeamMemberExists(int id)
    {
        return _context.TeamMembers.Any(e => e.Id == id);
    }
}

[Route("api/[controller]")]
[ApiController]
public class HobbiesController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public HobbiesController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Hobby>>> GetHobbies(int? id)
    {
        if (id == null || id == 0)
        {
            return await _context.Hobbies.Take(5).ToListAsync();
        }
        else
        {
            return await _context.Hobbies.FindAsync(id);
        }
    }

    [HttpPost]
    public async Task<ActionResult<Hobby>> PostHobby(Hobby hobby)
    {
        _context.Hobbies.Add(hobby);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetHobbies), new { id = hobby.Id }, hobby);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutHobby(int id, Hobby hobby)
    {
        if (id != hobby.Id)
        {
            return BadRequest();
        }

        _context.Entry(hobby).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!HobbyExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHobby(int id)
    {
        var hobby = await _context.Hobbies.FindAsync(id);
        if (hobby == null)
        {
            return NotFound();
        }

        _context.Hobbies.Remove(hobby);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool HobbyExists(int id)
    {
        return _context.Hobbies.Any(e => e.Id == id);
    }
}

[Route("api/[controller]")]
[ApiController]
public class FavoriteFoodsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public FavoriteFoodsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FavoriteFood>>> GetFavoriteFoods(int? id)
    {
        if (id == null || id == 0)
        {
            return await _context.FavoriteFoods.Take(5).ToListAsync();
        }
        else
        {
            return await _context.FavoriteFoods.FindAsync(id);
        }
    }

    [HttpPost]
    public async Task<ActionResult<FavoriteFood>> PostFavoriteFood(FavoriteFood favoriteFood)
    {
        _context.FavoriteFoods.Add(favoriteFood);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFavoriteFoods), new { id = favoriteFood.Id }, favoriteFood);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutFavoriteFood(int id, FavoriteFood favoriteFood)
    {
        if (id != favoriteFood.Id)
        {
            return BadRequest();
        }

        _context.Entry(favoriteFood).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FavoriteFoodExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFavoriteFood(int id)
    {
        var favoriteFood = await _context.FavoriteFoods.FindAsync(id);
        if (favoriteFood == null)
        {
            return NotFound();
        }

        _context.FavoriteFoods.Remove(favoriteFood);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FavoriteFoodExists(int id)
    {
        return _context.FavoriteFoods.Any(e => e.Id == id);
    }
}
[Route("api/[controller]")]
[ApiController]
public class FavoriteTeamsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public FavoriteTeamsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FavoriteTeam>>> GetFavoriteTeams(int? id)
    {
        if (id == null || id == 0)
        {
            return await _context.FavoriteTeams.Take(5).ToListAsync();
        }
        else
        {
            return await _context.FavoriteTeams.FindAsync(id);
        }
    }

    [HttpPost]
    public async Task<ActionResult<FavoriteTeam>> PostFavoriteTeam(FavoriteTeam favoriteTeam)
    {
        _context.FavoriteTeams.Add(favoriteTeam);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFavoriteTeams), new { id = favoriteTeam.Id }, favoriteTeam);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutFavoriteTeam(int id, FavoriteTeam favoriteTeam)
    {
        if (id != favoriteTeam.Id)
        {
            return BadRequest();
        }

        _context.Entry(favoriteTeam).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!FavoriteTeamExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFavoriteTeam(int id)
    {
        var favoriteTeam = await _context.FavoriteTeams.FindAsync(id);
        if (favoriteTeam == null)
        {
            return NotFound();
        }

        _context.FavoriteTeams.Remove(favoriteTeam);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool FavoriteTeamExists(int id)
    {
        return _context.FavoriteFoods.Any(e => e.Id == id);
    }
}