using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
    {

    }

    public DbSet<Platform> Plateforms { get; set; } = null!;
  }
}