using CodersAcademy.Api.Model;
using CodersAcademy.Api.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CodersAcademy.Api.Repository
{
    public class MusicContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }


        public MusicContext(DbContextOptions<MusicContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlbumMapping());
            modelBuilder.ApplyConfiguration(new MusicMapping());

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory Logger = LoggerFactory.Create(x => x.AddConsole());
            optionsBuilder.UseLoggerFactory(Logger);

            base.OnConfiguring(optionsBuilder);

        }
    }

}
