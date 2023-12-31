using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAndFluentMigrator.Core.Musics;

public sealed class StyleEntityMap : IEntityTypeConfiguration<Style>
{
    public void Configure(EntityTypeBuilder<Style> builder)
    {
        builder.ToTable(
            "styles",
            options => options.ExcludeFromMigrations());

        builder.HasKey(s => s.Id);

        builder
            .Property(s => s.Id)
            .HasColumnName("id");

        builder
            .Property(s => s.Name)
            .HasColumnName("name");
    }
}
