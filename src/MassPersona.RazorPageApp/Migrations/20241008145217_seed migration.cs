using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MassPersona.RazorPageApp.Migrations
{
    /// <inheritdoc />
    public partial class seedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    ReviewText = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    DateReviewed = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[,]
                {
                    { 1, "Movie", new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4387), 4, "I enjoyed it more than the first one.", "Dune 2" },
                    { 2, "Game", new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4393), 4, "Brough back nostalgia as I played it when it first came out.", "Warcraft Classic" },
                    { 3, "Book", new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4397), 2, "A little difficult to understand, but peaked my interest to create Microservice solutions. For example https://github.com/ponssong/EShopMicSer", ".NET Microservices: Architecture for containerized .NET Applications" },
                    { 4, "Show", new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4401), 3, "I enjoyed the first season so i will continue to watch.", "Rings of Power" },
                    { 5, "Show", new DateTime(2024, 10, 8, 14, 52, 16, 628, DateTimeKind.Utc).AddTicks(4406), 5, "I read the manhua. So I wanted to see the anime.", "Solo Leveling" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
