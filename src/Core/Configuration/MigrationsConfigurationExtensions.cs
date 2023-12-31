using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace EFCoreAndFluentMigrator.Core.Configuration;

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
                .ScanIn(typeof(MigrationsConfigurationExtensions).Assembly));
    }
}
