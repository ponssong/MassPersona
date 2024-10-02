using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MassPersona.RazorPageApp.Migrations
{
    /// <inheritdoc />
    public partial class seedmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Category", "DateReviewed", "Rating", "ReviewText", "Title" },
                values: new object[] { 1, "Test Category", new DateTime(2024, 10, 2, 18, 39, 31, 441, DateTimeKind.Utc).AddTicks(8240), 1, "Test Review", "Test Title" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);
        }
    }
}
