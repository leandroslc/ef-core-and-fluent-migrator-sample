using EFCoreAndFluentMigrator.Core.Musics;
using EFCoreAndFluentMigrator.Sample;
using EFCoreAndFluentMigrator.Sample.Configuration;
using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();

var connectionString = configuration.GetConnectionString("Test")!;

// Configure services
var services = new ServiceCollection()
    .AddDbContext(connectionString)
    .AddMigrations(connectionString)
    .AddScoped<MusicRepository>();

// Build and get required services
using var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();

var musicsContext = scope.ServiceProvider.GetRequiredService<MusicsDbContext>();
var migrationsRunner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
var musicRepository = scope.ServiceProvider.GetRequiredService<MusicRepository>();

// Creates the database if it does not exist
await musicsContext.Database.EnsureCreatedAsync();

// Runs all migrations
migrationsRunner.MigrateUp();

// And just to show up everything is working fine
Output.Write(await musicRepository.GetAllAsync());
