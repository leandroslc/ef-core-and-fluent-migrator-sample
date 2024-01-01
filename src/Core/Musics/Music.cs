namespace EFCoreAndFluentMigrator.Core.Musics;

public class Music
{
    public int Id { get; private set; }

    public required string Name { get; init; }

    public required int CompositionYear { get; init; }

    public required string CatalogNumber { get; init; }

    public required Style Style { get; init; }

    public int StyleId { get; private set; }

    public required Composer Composer { get; init; }

    public int ComposerId { get; private set; }
}
