﻿using AutoMapper;
using MusicApi.Data.DTOs;
using MusicApi.Data.Models;
using MusicApi.Data.Response;
namespace MusicApi.Helper.Helpers
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper() { 
            CreateMap<Album,AlbumDTO>().ReverseMap();
            CreateMap<Artist, ArtistDTO>().ReverseMap();
            CreateMap<PlayList, PlayListDTO>().ReverseMap();
            CreateMap<Song, SongDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Song, SongResponse>();
            CreateMap<Artist, ArtistResponse>();
            CreateMap<Album, SongResponse>();
        }
    }
}
