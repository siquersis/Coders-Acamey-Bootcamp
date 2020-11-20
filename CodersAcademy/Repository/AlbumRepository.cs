using CodersAcademy.Api.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CodersAcademy.Api.Repository
{
    public class AlbumRepository
    {
        private MusicContext Context { get; init; }

        public AlbumRepository(MusicContext context)
        {
            this.Context = context;
        }

        public async Task<IList<Album>> GetAllAsync() =>
            await this.Context.Albuns.ToListAsync();
    }
}
