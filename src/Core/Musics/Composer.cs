namespace EFCoreAndFluentMigrator.Core.Musics;

public class Composer
{
    public int Id { get; private set; }

    public required string Name { get; init; }
}
