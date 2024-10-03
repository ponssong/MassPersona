using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MassPersona.RazorPageApp.Migrations
{
    /// <inheritdoc />
    public partial class second_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[] { "Movie", new DateTime(2024, 10, 3, 20, 40, 10, 920, DateTimeKind.Utc).AddTicks(3404), 4, "I enjoyed it more than the first one.", "Dune 2" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                columns: new[] { "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[] { "Game", new DateTime(2024, 10, 3, 20, 40, 10, 920, DateTimeKind.Utc).AddTicks(3408), 4, "Brough back nostalgia as I played it when it first came out.", "Warcraft Classic" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[,]
                {
                    { 3, "Book", new DateTime(2024, 10, 3, 20, 40, 10, 920, DateTimeKind.Utc).AddTicks(3409), 2, "A little difficult to understand, but paked my interest to create Microservice solutions. For example https://github.com/ponssong/EShopMicSer", ".NET Microservices: Architecture for containerized .NET Applications" },
                    { 4, "Show", new DateTime(2024, 10, 3, 20, 40, 10, 920, DateTimeKind.Utc).AddTicks(3411), 3, "I enjoyed the first so i will continue to watch.", "Rings of Power" },
                    { 5, "Show", new DateTime(2024, 10, 3, 20, 40, 10, 920, DateTimeKind.Utc).AddTicks(3413), 4, "I read the manhua. So I wanted to see the anime.", "Solo Leveling" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1,
                columns: new[] { "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[] { "Test Category", new DateTime(2024, 10, 3, 18, 31, 2, 156, DateTimeKind.Utc).AddTicks(5969), 5, "Test Review", "Test Title" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2,
                columns: new[] { "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[] { "A New Test Category", new DateTime(2024, 10, 3, 18, 31, 2, 156, DateTimeKind.Utc).AddTicks(5972), 2, "A New Test Review", "A New Test Title" });
        }
    }
}
