﻿// <auto-generated />
using System;
using CodersAcademy.Api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodersAcademy.Api.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20201120233630_CreateUserAndUSerFavoriteMusic")]
    partial class CreateUserAndUSerFavoriteMusic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CodersAcademy.Api.Model.Album", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Backdrop")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Band")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Albuns");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.Music", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("AlbumId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.ToTable("Music");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.UserFavoriteMusic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MusicId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MusicId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserFavoriteMusic");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.Music", b =>
                {
                    b.HasOne("CodersAcademy.Api.Model.Album", "Album")
                        .WithMany("Musics")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Album");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.UserFavoriteMusic", b =>
                {
                    b.HasOne("CodersAcademy.Api.Model.Music", "Music")
                        .WithOne()
                        .HasForeignKey("CodersAcademy.Api.Model.UserFavoriteMusic", "MusicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodersAcademy.Api.Model.User", "User")
                        .WithMany("FavoriteMusics")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Music");

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.Album", b =>
                {
                    b.Navigation("Musics");
                });

            modelBuilder.Entity("CodersAcademy.Api.Model.User", b =>
                {
                    b.Navigation("FavoriteMusics");
                });
#pragma warning restore 612, 618
        }
    }
}
