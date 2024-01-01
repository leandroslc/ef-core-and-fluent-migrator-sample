using FluentMigrator;

namespace EFCoreAndFluentMigrator.Core.Migrations;

[Migration(202312311516)]
public sealed class CreateInitialTables : Migration
{
    public override void Down()
    {
        Delete.Table("musics");
        Delete.Table("styles");
        Delete.Table("composers");
    }

    public override void Up()
    {
        Create
            .Table("composers")
            .WithColumn("id")
                .AsInt32()
                .NotNullable()
                .Identity()
                .PrimaryKey("pk_composers")
            .WithColumn("name")
                .AsString(200)
                .NotNullable();

        Create
            .Table("styles")
            .WithColumn("id")
                .AsInt32()
                .NotNullable()
                .Identity()
                .PrimaryKey("pk_styles")
            .WithColumn("name")
                .AsString(200)
                .NotNullable();

        Create
            .Table("musics")
            .WithColumn("id")
                .AsInt32()
                .NotNullable()
                .Identity()
                .PrimaryKey("pk_musics")
            .WithColumn("name")
                .AsString(200)
                .NotNullable()
            .WithColumn("catalog_number")
                .AsString(50)
                .NotNullable()
            .WithColumn("composition_year")
                .AsInt32()
                .NotNullable()
            .WithColumn("style_id")
                .AsInt32()
                .NotNullable()
                .ForeignKey("fk_musics_styles", "styles", "id")
            .WithColumn("composer_id")
                .AsInt32()
                .NotNullable()
                .ForeignKey("fk_musics_composers", "composers", "id");
    }
}
