using FormulaOneApp.Data;
using FormulaOneApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FormulaOneApp.Controllers;

[Route("api/[controller]")] // api/teams
[ApiController]
public class TeamsController : ControllerBase
{
    private static AppDbContext _context;

    public TeamsController(AppDbContext context)
    {
        _context = context;
    }
    
    private static List<Team> teams =
    [
        new Team()
        {
            Id = 1,
            Country = "Germany",
            Name = "Mercedes AMG F1",
            TeamPrincipal = "Toto Wolf"
        },
        new Team()
        {
            Id = 2,
            Country = "Italy",
            Name = "Ferrari",
            TeamPrincipal = "Mattia Binitto"
        },
        new Team()
        {
            Id = 3,
            Country = "Swiss",
            Name = "Alpha Romeo",
            TeamPrincipal = "Fredric Vasseur"
        }
    ];
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {   
        var teams = await _context.Teams.ToListAsync();
        return Ok(teams);
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> Get(int id)
    {
        var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
        
        if (team == null) return BadRequest("Team not found");
        
        return Ok(team);
    }

    [HttpPost]
    public async Task<IActionResult> Post(Team team)
    {   
        await _context.Teams.AddAsync(team);
        await _context.SaveChangesAsync();
        
        return CreatedAtAction("Get", team.Id, team);
    }

    [HttpPatch("{id:int}")]
    public async Task<IActionResult> Patch(int id, string country)
    {   
        var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id); 
        
        if (team == null) return BadRequest("Team Not Found");
        
        team.Country = country;
        
        await _context.SaveChangesAsync();
        
        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        var team = await _context.Teams.FirstOrDefaultAsync(x => x.Id == id);
        if (team == null) return BadRequest("Invalid Id");
        
        _context.Teams.Remove(team);
        await _context.SaveChangesAsync();
        
        return NoContent();
    }
}