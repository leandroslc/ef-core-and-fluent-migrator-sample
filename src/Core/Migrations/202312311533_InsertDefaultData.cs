using FluentMigrator;
using FluentMigrator.Postgres;

namespace EFCoreAndFluentMigrator.Core.Migrations;

[Migration(202312311533)]
public sealed class InsertDefaultData : Migration
{
    private const int InitialId = 1;

    public override void Down()
    {
        Delete.FromTable("musics").Row(new { id = InitialId });
        Delete.FromTable("styles").Row(new { id = InitialId });
        Delete.FromTable("compositors").Row(new { id = InitialId });
    }

    public override void Up()
    {
        var style = new
        {
            id = InitialId,
            name = "Romantic",
        };

        var compositor = new
        {
            id = InitialId,
            name = "Fryderyk Franciszek Chopin",
        };

        var music = new
        {
            id = InitialId,
            name = "Ballade no. 4 in F minor",
            catalog_number = "Opus 52",
            composition_year = 1842,
            style_id = InitialId,
            compositor_id = InitialId,
        };

        Insert
            .IntoTable("styles")
            .Row(style)
            .WithOverridingSystemValue();

        Insert
            .IntoTable("compositors")
            .Row(compositor)
            .WithOverridingSystemValue();

        Insert
            .IntoTable("musics")
            .Row(music)
            .WithOverridingSystemValue();
    }
}
