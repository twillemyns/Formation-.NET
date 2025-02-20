using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Exercice06.Migrations
{
    /// <inheritdoc />
    public partial class MergePictureInMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Pictures_PictureId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Movies_PictureId",
                table: "Movies");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PictureId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Movies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "PictureId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "IsWatched", "Name", "PictureId", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, true, "The Shawshank Redemption", null, new DateOnly(1994, 10, 14) },
                    { 2, true, "The Godfather", null, new DateOnly(1972, 3, 24) },
                    { 3, true, "The Dark Knight", null, new DateOnly(2008, 7, 18) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_PictureId",
                table: "Movies",
                column: "PictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Pictures_PictureId",
                table: "Movies",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id");
        }
    }
}
