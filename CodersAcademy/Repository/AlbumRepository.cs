﻿using CodersAcademy.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<IList<Album>> GetAllAsync()
            => await this.Context.Albums.Include(x => x.Musics).ToListAsync();

        public async Task<Album> GetAlbumByIdAsync(Guid id)
            => await this.Context.Albums.Include(x => x.Musics).Where(x => x.Id == id).FirstOrDefaultAsync();

        public async Task DeleteAsync(Album model)
        {
            this.Context.Remove(model);
            await this.Context.SaveChangesAsync();
        }

        public async Task CreateAsync(Album album)
        {
            await this.Context.Albums.AddAsync(album);
            await this.Context.SaveChangesAsync();
        }

        public async Task<Music> GetMusicAsync(Guid musicId)
        => await this.Context.Music.Where(x => x.Id == musicId).FirstOrDefaultAsync();
        
    }
}
