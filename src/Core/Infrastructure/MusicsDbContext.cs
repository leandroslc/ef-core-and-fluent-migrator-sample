using Microsoft.EntityFrameworkCore;

namespace EFCoreAndFluentMigrator.Core.Infrastructure;

public sealed class MusicsDbContext : DbContext
{
    public MusicsDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(MusicsDbContext).Assembly);
    }
}
