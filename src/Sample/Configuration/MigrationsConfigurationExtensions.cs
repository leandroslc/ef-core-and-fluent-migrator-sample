using EFCoreAndFluentMigrator.Core.Musics;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreAndFluentMigrator.Sample.Configuration;

public static class MigrationsConfigurationExtensions
{
    public static IServiceCollection AddMigrations(
        this IServiceCollection services,
        string connectionString)
    {
        return services
            .AddFluentMigratorCore()
            .ConfigureRunner(runner => runner
                .AddPostgres()
                .WithGlobalConnectionString(connectionString)
                .ScanIn(typeof(MusicsDbContext).Assembly));
    }
}
