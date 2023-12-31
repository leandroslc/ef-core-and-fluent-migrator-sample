using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCoreAndFluentMigrator.Core.Musics;

public sealed class WorkEntityMap : IEntityTypeConfiguration<Work>
{
    public void Configure(EntityTypeBuilder<Work> builder)
    {
        builder.ToTable(
            "works",
            options => options.ExcludeFromMigrations());

        builder.HasKey(w => w.Id);

        builder
            .Property(w => w.Id)
            .HasColumnName("id");

        builder
            .Property(w => w.Name)
            .HasColumnName("name");

        builder
            .Property(w => w.CatalogNumber)
            .HasColumnName("catalog_number");

        builder
            .Property(w => w.CompositionYear)
            .HasColumnName("composition_year");

        builder
            .Property(w => w.StyleId)
            .HasColumnName("style_id");

        builder
            .Property(w => w.CompositorId)
            .HasColumnName("compositor_id");

        builder
            .HasOne(w => w.Style)
            .WithMany()
            .HasForeignKey(w => w.StyleId);

        builder
            .HasOne(w => w.Compositor)
            .WithMany()
            .HasForeignKey(w => w.CompositorId);
    }
}
