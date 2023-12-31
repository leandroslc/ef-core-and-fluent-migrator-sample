using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAndFluentMigrator.Core.Musics;

public sealed class CompositorEntityMap : IEntityTypeConfiguration<Compositor>
{
    public void Configure(EntityTypeBuilder<Compositor> builder)
    {
        builder.ToTable(
            "compositors",
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
