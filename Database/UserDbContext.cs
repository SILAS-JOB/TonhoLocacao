using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using TonhoLocacao.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


public class ApplicationUser : IdentityUser
{
    
}


public class UserDbContext : IdentityDbContext<ApplicationUser>
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}



