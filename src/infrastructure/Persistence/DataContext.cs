using domain;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Activity> Activities { get; set; }
}