﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongVoting.API.Models.Database;

namespace SongVoting.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200103134649_UpdateSongs")]
    partial class UpdateSongs
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SongVoting.API.Models.Database.SpotifyTrack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Added")
                        .HasColumnType("datetime2");

                    b.Property<string>("SpotifyId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SpotifyTracks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9059),
                            SpotifyId = "7KVAuyWq49C37WWRgfVFJq"
                        },
                        new
                        {
                            Id = 2,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9505),
                            SpotifyId = "0gI1wucmc2djSV3e25LqCd"
                        },
                        new
                        {
                            Id = 3,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9522),
                            SpotifyId = "5Bp8uC0h4CjxENVBnahOkD"
                        },
                        new
                        {
                            Id = 4,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9523),
                            SpotifyId = "1Yqj7oGrttZH3JX2RYTmzS"
                        },
                        new
                        {
                            Id = 5,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9523),
                            SpotifyId = "6Nenm0bjHwjCbTet7Zb9VH"
                        },
                        new
                        {
                            Id = 6,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9524),
                            SpotifyId = "78twEEzRCHmOzgRn7wAl8I"
                        },
                        new
                        {
                            Id = 7,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9525),
                            SpotifyId = "3agx8NSEa7IPUxvbQs5Xax"
                        },
                        new
                        {
                            Id = 8,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9525),
                            SpotifyId = "7mj5fT0Biju5jR41m9ghUl"
                        },
                        new
                        {
                            Id = 9,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9526),
                            SpotifyId = "5lubagonZYGdyrfbBsOYdy"
                        },
                        new
                        {
                            Id = 10,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9526),
                            SpotifyId = "2a1aibn4UgSkeTaxJSWw1L"
                        },
                        new
                        {
                            Id = 11,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9527),
                            SpotifyId = "3i65fj9NX9PPNTDKyhlWvP"
                        },
                        new
                        {
                            Id = 12,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9527),
                            SpotifyId = "5AcdaSVQfLcUKMaqchfBie"
                        },
                        new
                        {
                            Id = 13,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9528),
                            SpotifyId = "5SDcksP8En1l6RtTY1wzHc"
                        },
                        new
                        {
                            Id = 14,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9529),
                            SpotifyId = "0rH0mprtecH3grD9HFM5AD"
                        },
                        new
                        {
                            Id = 15,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9529),
                            SpotifyId = "4G29gmjS7Z2nEFeM7FA6wx"
                        },
                        new
                        {
                            Id = 16,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9530),
                            SpotifyId = "50lW1fKoDtyKaiR2bR7ksl"
                        },
                        new
                        {
                            Id = 17,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9530),
                            SpotifyId = "0pvGqtwpBePPYdEVzdtXWe"
                        },
                        new
                        {
                            Id = 18,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9531),
                            SpotifyId = "0jxIbgW2FoPhqgTh5qhegg"
                        },
                        new
                        {
                            Id = 19,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9531),
                            SpotifyId = "5vMzNmHm2ec2zrqiYhkQzZ"
                        },
                        new
                        {
                            Id = 20,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9532),
                            SpotifyId = "6tCueZxmTKZYpQMWXQtCiB"
                        },
                        new
                        {
                            Id = 21,
                            Added = new DateTime(2020, 1, 3, 13, 46, 49, 608, DateTimeKind.Utc).AddTicks(9567),
                            SpotifyId = "7L51zRDwhfvQR63Ntzkf0E"
                        });
                });

            modelBuilder.Entity("SongVoting.API.Models.Database.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Added")
                        .HasColumnType("datetime2");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Liked")
                        .HasColumnType("bit");

                    b.Property<int>("SpotifyTrackId")
                        .HasColumnType("int");

                    b.Property<Guid>("UserToken")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SpotifyTrackId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("SongVoting.API.Models.Database.Vote", b =>
                {
                    b.HasOne("SongVoting.API.Models.Database.SpotifyTrack", null)
                        .WithMany("Votes")
                        .HasForeignKey("SpotifyTrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}