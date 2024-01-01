using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAndFluentMigrator.Core.Musics;

public sealed class ComposerEntityMap : IEntityTypeConfiguration<Composer>
{
    public void Configure(EntityTypeBuilder<Composer> builder)
    {
        builder.ToTable(
            "composers",
            options => options.ExcludeFromMigrations());

        builder.HasKey(c => c.Id);

        builder
            .Property(c => c.Id)
            .HasColumnName("id");

        builder
            .Property(c => c.Name)
            .HasColumnName("name");
    }
}
