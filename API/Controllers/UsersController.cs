using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext Context) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<AppUser>> GetUsers() 
    {
       return await _context.Users.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<AppUser> GetUserbyId(int id) 
    {
       return await _context.Users.FindAsync(id);
    }
}
