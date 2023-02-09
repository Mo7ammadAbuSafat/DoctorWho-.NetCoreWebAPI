using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DoctorWho.Db.Migrations
{
    /// <inheritdoc />
    public partial class seedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Author1" },
                    { 2, "Author2" },
                    { 3, "Author3" },
                    { 4, "Author4" },
                    { 5, "Author5" }
                });

            migrationBuilder.InsertData(
                table: "companions",
                columns: new[] { "Id", "Name", "WhoPlayed" },
                values: new object[,]
                {
                    { 1, "Companion1", "x" },
                    { 2, "Companion2", "y" },
                    { 3, "Companion3", "z" },
                    { 4, "Companion4", "e" },
                    { 5, "Companion5", "w" }
                });

            migrationBuilder.InsertData(
                table: "doctors",
                columns: new[] { "Id", "BirthDate", "FirstEpisodeDate", "LastEpisodeDate", "Name", "Number" },
                values: new object[,]
                {
                    { 1, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1912, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1941, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor1", 1 },
                    { 2, new DateTime(1950, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1950, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1901, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor2", 2 },
                    { 3, new DateTime(1959, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1900, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1944, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor3", 3 },
                    { 4, new DateTime(1927, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1924, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1941, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor4", 4 },
                    { 5, new DateTime(1992, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1942, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1944, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor5", 5 }
                });

            migrationBuilder.InsertData(
                table: "enemys",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Description1", "Enemy1" },
                    { 2, "Description2", "Enemy2" },
                    { 3, "Description3", "Enemy3" },
                    { 4, "Description4", "Enemy4" },
                    { 5, "Description5", "Enemy5" }
                });

            migrationBuilder.InsertData(
                table: "episodes",
                columns: new[] { "Id", "AuthorId", "Date", "DoctorId", "Notes", "Number", "SeriesNumber", "Title", "Type" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Note1", 1, 1, "Title1", "type1" },
                    { 2, 2, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Note2", 2, 2, "Title2", "type2" },
                    { 3, 2, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Note3", 3, 3, "Title3", "type3" },
                    { 4, 1, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Note4", 4, 4, "Title4", "type4" },
                    { 5, 3, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Note5", 5, 5, "Title5", "type5" },
                    { 6, 2, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Note6", 6, 6, "Title6", "type6" },
                    { 7, 5, new DateTime(1900, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Note7", 7, 7, "Title7", "type7" }
                });

            migrationBuilder.InsertData(
                table: "episodeCompanions",
                columns: new[] { "Id", "CompanionId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 2, 3 },
                    { 2, 1, 1 },
                    { 3, 2, 2 },
                    { 4, 3, 2 },
                    { 5, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "episodeEnemies",
                columns: new[] { "Id", "EnemyId", "EpisodeId" },
                values: new object[,]
                {
                    { 1, 2, 3 },
                    { 2, 1, 2 },
                    { 3, 5, 2 },
                    { 4, 2, 2 },
                    { 5, 5, 1 },
                    { 6, 3, 3 },
                    { 7, 2, 4 },
                    { 8, 2, 1 },
                    { 9, 1, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "companions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "enemys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "episodeCompanions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "episodeCompanions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "episodeCompanions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "episodeCompanions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "episodeCompanions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "episodeEnemies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "companions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "companions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "companions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "companions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "enemys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "enemys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "enemys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "enemys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "episodes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "doctors",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
