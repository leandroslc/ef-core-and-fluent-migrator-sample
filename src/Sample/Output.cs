using EFCoreAndFluentMigrator.Core.Musics;
using Spectre.Console;

namespace EFCoreAndFluentMigrator.Sample;

public static class Output
{
    public static void Write(IReadOnlyCollection<Music> musics)
    {
        var table = new Table();

        table.AddColumns(
            "[orange1]Name[/]",
            "[orange1]Catalog[/]",
            "[orange1]Year[/]",
            "[orange1]Style[/]",
            "[orange1]Composer[/]");

        foreach (var music in musics)
        {
            table.AddRow(
                music.Name,
                music.CatalogNumber,
                music.CompositionYear.ToString(),
                $"[purple]{music.Style.Name}[/]",
                $"[cyan]{music.Composer.Name}[/]");
        }

        AnsiConsole.Write(table);
    }
}
