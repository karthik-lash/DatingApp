using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<AppUser>> GetUsers() 
    {
       return await context.Users.ToListAsync();
    }

    [HttpGet("{id:int}")]
    public async Task<AppUser> GetUserbyId(int id) 
    {
       return await context.Users.FindAsync(id);
    }
}
