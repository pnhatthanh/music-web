﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicApi.Data.Data;

#nullable disable

namespace MusicApi.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240722093109_update-v3")]
    partial class updatev3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MusicApi.Data.Models.Album", b =>
                {
                    b.Property<Guid>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AlbumName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSong")
                        .HasColumnType("int");

                    b.HasKey("AlbumId");

                    b.ToTable("albums");
                });

            modelBuilder.Entity("MusicApi.Data.Models.AlbumSong", b =>
                {
                    b.Property<Guid>("AlbumId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AlbumId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("albumSong");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Artist", b =>
                {
                    b.Property<Guid>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Followers")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfBirth")
                        .HasColumnType("int");

                    b.HasKey("ArtistId");

                    b.ToTable("artists");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("MusicApi.Data.Models.PlayList", b =>
                {
                    b.Property<Guid>("PlayListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfSong")
                        .HasColumnType("int");

                    b.Property<string>("PlayListName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayListId");

                    b.HasIndex("UserId");

                    b.ToTable("playlists");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Song", b =>
                {
                    b.Property<Guid>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SongImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongLyrics")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SongId");

                    b.HasIndex("ArtistId");

                    b.HasIndex("CategoryId");

                    b.ToTable("songs");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Token", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("CreatedAt")
                        .HasColumnType("bigint");

                    b.Property<long>("ExpirationTime")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<string>("RefereshToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("tokens");
                });

            modelBuilder.Entity("MusicApi.Data.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("MusicApi.Data.Models.UserFavourite", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SongId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("userFavourites");
                });

            modelBuilder.Entity("PlayListSong", b =>
                {
                    b.Property<Guid>("PlayListsPlayListId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SongsSongId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlayListsPlayListId", "SongsSongId");

                    b.HasIndex("SongsSongId");

                    b.ToTable("PlayListSong");
                });

            modelBuilder.Entity("MusicApi.Data.Models.AlbumSong", b =>
                {
                    b.HasOne("MusicApi.Data.Models.Album", "Album")
                        .WithMany("AlbumSongs")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Models.Song", "Song")
                        .WithMany("AlbumSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("MusicApi.Data.Models.PlayList", b =>
                {
                    b.HasOne("MusicApi.Data.Models.User", "User")
                        .WithMany("PlayLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Song", b =>
                {
                    b.HasOne("MusicApi.Data.Models.Artist", "artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Models.Category", "category")
                        .WithMany("song")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("artist");

                    b.Navigation("category");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Token", b =>
                {
                    b.HasOne("MusicApi.Data.Models.User", "User")
                        .WithMany("tokens")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("MusicApi.Data.Models.User", b =>
                {
                    b.HasOne("MusicApi.Data.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("MusicApi.Data.Models.UserFavourite", b =>
                {
                    b.HasOne("MusicApi.Data.Models.Song", "Song")
                        .WithMany("UserFavourite")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Models.User", "User")
                        .WithMany("UserFavourite")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Song");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PlayListSong", b =>
                {
                    b.HasOne("MusicApi.Data.Models.PlayList", null)
                        .WithMany()
                        .HasForeignKey("PlayListsPlayListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MusicApi.Data.Models.Song", null)
                        .WithMany()
                        .HasForeignKey("SongsSongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MusicApi.Data.Models.Album", b =>
                {
                    b.Navigation("AlbumSongs");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Artist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Category", b =>
                {
                    b.Navigation("song");
                });

            modelBuilder.Entity("MusicApi.Data.Models.Song", b =>
                {
                    b.Navigation("AlbumSongs");

                    b.Navigation("UserFavourite");
                });

            modelBuilder.Entity("MusicApi.Data.Models.User", b =>
                {
                    b.Navigation("PlayLists");

                    b.Navigation("UserFavourite");

                    b.Navigation("tokens");
                });
#pragma warning restore 612, 618
        }
    }
}
