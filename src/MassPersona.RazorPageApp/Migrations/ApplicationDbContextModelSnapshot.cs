﻿// <auto-generated />
using System;
using MassPersona.RazorPageApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MassPersona.RazorPageApp.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MassPersona.RazorPageApp.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ReviewID");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReviewID"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Category");

                    b.Property<DateTime>("DateReviewed")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DateReviewed");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("Rating");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ReviewText");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Title");

                    b.HasKey("ReviewID");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewID = 1,
                            Category = "Movie",
                            DateReviewed = new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4387),
                            Rating = 4,
                            ReviewText = "I enjoyed it more than the first one.",
                            Title = "Dune 2"
                        },
                        new
                        {
                            ReviewID = 2,
                            Category = "Game",
                            DateReviewed = new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4393),
                            Rating = 4,
                            ReviewText = "Brough back nostalgia as I played it when it first came out.",
                            Title = "Warcraft Classic"
                        },
                        new
                        {
                            ReviewID = 3,
                            Category = "Book",
                            DateReviewed = new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4397),
                            Rating = 2,
                            ReviewText = "A little difficult to understand, but peaked my interest to create Microservice solutions. For example https://github.com/ponssong/EShopMicSer",
                            Title = ".NET Microservices: Architecture for containerized .NET Applications"
                        },
                        new
                        {
                            ReviewID = 4,
                            Category = "Show",
                            DateReviewed = new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4401),
                            Rating = 3,
                            ReviewText = "I enjoyed the first season so i will continue to watch.",
                            Title = "Rings of Power"
                        },
                        new
                        {
                            ReviewID = 5,
                            Category = "Show",
                            DateReviewed = new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4406),
                            Rating = 5,
                            ReviewText = "I read the manhua. So I wanted to see the anime.",
                            Title = "Solo Leveling"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
