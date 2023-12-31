using Microsoft.EntityFrameworkCore;

namespace EFCoreAndFluentMigrator.Core.Musics;

public class MusicRepository
{
    private readonly MusicsDbContext context;

    public MusicRepository(MusicsDbContext context)
    {
        this.context = context;
    }

    public async Task<IReadOnlyCollection<Work>> GetAllAsync()
    {
        return await context
            .Set<Work>()
            .Include(w => w.Compositor)
            .Include(w => w.Style)
            .ToListAsync();
    }
}
