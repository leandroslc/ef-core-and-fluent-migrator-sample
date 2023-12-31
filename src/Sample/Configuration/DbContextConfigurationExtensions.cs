using EFCoreAndFluentMigrator.Core.Musics;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreAndFluentMigrator.Sample.Configuration;

public static class DbContextConfigurationExtensions
{
    public static IServiceCollection AddDbContext(
        this IServiceCollection services,
        string connectionString)
    {
        return services.AddDbContext<MusicsDbContext>(
            options => options.UseNpgsql(connectionString));
    }
}
