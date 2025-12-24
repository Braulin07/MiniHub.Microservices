using Microsoft.EntityFrameworkCore;
using MiniHub.AuthService.Domain;

namespace MiniHub.AuthService.Infrastructure.Persistence
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options){}

        public DbSet<User> Users => Set<User>();
        
    }
}
