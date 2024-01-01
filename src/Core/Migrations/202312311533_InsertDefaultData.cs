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
        Delete.FromTable("composers").Row(new { id = InitialId });
    }

    public override void Up()
    {
        var style = new
        {
            id = InitialId,
            name = "Romantic",
        };

        var composer = new
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
            composer_id = InitialId,
        };

        Insert
            .IntoTable("styles")
            .Row(style)
            .WithOverridingSystemValue();

        Insert
            .IntoTable("composers")
            .Row(composer)
            .WithOverridingSystemValue();

        Insert
            .IntoTable("musics")
            .Row(music)
            .WithOverridingSystemValue();
    }
}
