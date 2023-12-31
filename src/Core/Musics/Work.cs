namespace EFCoreAndFluentMigrator.Core.Musics;

public class Work
{
    public int Id { get; private set; }

    public required string Name { get; init; }

    public required DateTime CompositionYear { get; init; }

    public required string CatalogNumber { get; init; }

    public required Style Style { get; init; }

    public int StyleId { get; private set; }

    public required Compositor Compositor { get; init; }

    public int CompositorId { get; private set; }
}
