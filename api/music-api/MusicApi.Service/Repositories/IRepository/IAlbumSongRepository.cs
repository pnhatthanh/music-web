﻿using MusicApi.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApi.Infracstructure.Repositories.IRepository
{
    public interface IAlbumSongRepository : IBaseRepository<AlbumSong>
    {
        Task<IEnumerable<Song?>> GetSongs(Guid idAlbum);
    }
}
