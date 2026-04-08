using backend.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class AppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid> 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
}