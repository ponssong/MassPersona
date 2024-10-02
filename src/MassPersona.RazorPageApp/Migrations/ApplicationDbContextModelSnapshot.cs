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
                            Category = "Test Category",
                            DateReviewed = new DateTime(2024, 10, 2, 18, 39, 31, 441, DateTimeKind.Local).AddTicks(8240),
                            Rating = 1,
                            ReviewText = "Test Review",
                            Title = "Test Title"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
