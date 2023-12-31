using FluentMigrator;

namespace EFCoreAndFluentMigrator.Core.Migrations;

[Migration(202312311516)]
public sealed class CreateInitialTables : Migration
{
    public override void Down()
    {
        Delete.Table("musics");
        Delete.Table("styles");
        Delete.Table("compositors");
    }

    public override void Up()
    {
        Create
            .Table("compositors")
            .WithColumn("id")
                .AsInt32()
                .NotNullable()
                .Identity()
                .PrimaryKey("pk_compositors")
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
            .WithColumn("compositor_id")
                .AsInt32()
                .NotNullable()
                .ForeignKey("fk_musics_compositors", "compositors", "id");
    }
}
