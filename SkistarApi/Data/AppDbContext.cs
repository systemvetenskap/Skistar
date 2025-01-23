using Microsoft.EntityFrameworkCore;
using SkistarApi.Models;

namespace SkistarApi.Data;

public class AppDbContext : DbContext
{
    public DbSet<Skier> Skiers { get; set; }
    public DbSet<Lift> Lifts { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
}
