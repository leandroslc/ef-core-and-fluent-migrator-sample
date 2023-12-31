using EFCoreAndFluentMigrator.Core.Musics;
using EFCoreAndFluentMigrator.Sample.Configuration;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

// It is also possible to use a ConfigurationBuilder here
var connectionString =
@"
    Server=127.0.0.1;
    Port=5432;
    Database=archives;
    User Id=postgres;
    Password=80d476dddb5d4d799b38f6d9ef44c17f;
";

// Configure services
var services = new ServiceCollection()
    .AddDbContext(connectionString)
    .AddMigrations(connectionString);

// Build and get required services
using var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();

var musicsContext = scope.ServiceProvider.GetRequiredService<MusicsDbContext>();
var migrationsRunner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();

// Creates the database if it does not exist
await musicsContext.Database.EnsureCreatedAsync();

// Runs all migrations
migrationsRunner.MigrateUp();
