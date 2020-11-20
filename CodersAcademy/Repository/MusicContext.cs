using CodersAcademy.Api.Model;
using CodersAcademy.Api.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CodersAcademy.Api.Repository
{
    public class MusicContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }

        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new MusicMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
