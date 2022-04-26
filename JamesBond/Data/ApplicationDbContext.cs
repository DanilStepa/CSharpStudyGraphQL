using Microsoft.EntityFrameworkCore;

namespace JamesBond.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Bond> Bond => Set<Bond>();
    public DbSet<Movie> Movies => Set<Movie>();
    public DbSet<Director> Directors => Set<Director>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
   
}