using Microsoft.EntityFrameworkCore;
using MusicParser.Models;

namespace MusicParser.Infrastructure.Context
{
    public class MusicPareserDbContext : DbContext
    {
        public MusicPareserDbContext(DbContextOptions<MusicPareserDbContext> options) : base(options)
        {
#if DEBUG
            Database.EnsureCreated();
#endif
        }

        public DbSet<Playlist> Playlists{ get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
