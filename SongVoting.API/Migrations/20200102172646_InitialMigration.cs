using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SongVoting.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpotifyTracks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpotifyId = table.Column<string>(nullable: true),
                    Added = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotifyTracks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Votes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpotifyTrackId = table.Column<int>(nullable: false),
                    Liked = table.Column<bool>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    Added = table.Column<DateTime>(nullable: false),
                    UserToken = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Votes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Votes_SpotifyTracks_SpotifyTrackId",
                        column: x => x.SpotifyTrackId,
                        principalTable: "SpotifyTracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SpotifyTracks",
                columns: new[] { "Id", "Added", "SpotifyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(2575), "3KTikFVuiStwKvcIW0Y0uJ" },
                    { 19, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3058), "0jxIbgW2FoPhqgTh5qhegg" },
                    { 18, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3058), "5SDcksP8En1l6RtTY1wzHc" },
                    { 17, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3057), "0gI1wucmc2djSV3e25LqCd" },
                    { 16, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3057), "6Nenm0bjHwjCbTet7Zb9VH" },
                    { 15, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3056), "4EiKZxDgW0sbT8BZ9Gl6dC" },
                    { 14, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3056), "3i65fj9NX9PPNTDKyhlWvP" },
                    { 13, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3055), "0pvGqtwpBePPYdEVzdtXWe" },
                    { 12, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3054), "5HWBaiVcqnaUf3BI4tfYG5" },
                    { 20, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3059), "3agx8NSEa7IPUxvbQs5Xax" },
                    { 11, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3054), "5lubagonZYGdyrfbBsOYdy" },
                    { 9, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3053), "7mj5fT0Biju5jR41m9ghUl" },
                    { 8, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3052), "78twEEzRCHmOzgRn7wAl8I" },
                    { 7, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3052), "2a1aibn4UgSkeTaxJSWw1L" },
                    { 6, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3051), "5Bp8uC0h4CjxENVBnahOkD" },
                    { 5, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3050), "1Yqj7oGrttZH3JX2RYTmzS" },
                    { 4, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3050), "4G29gmjS7Z2nEFeM7FA6wx" },
                    { 3, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3049), "0rH0mprtecH3grD9HFM5AD" },
                    { 2, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3031), "5vMzNmHm2ec2zrqiYhkQzZ" },
                    { 10, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3053), "5AcdaSVQfLcUKMaqchfBie" },
                    { 21, new DateTime(2020, 1, 2, 17, 26, 45, 869, DateTimeKind.Utc).AddTicks(3060), "50lW1fKoDtyKaiR2bR7ksl" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Votes_SpotifyTrackId",
                table: "Votes",
                column: "SpotifyTrackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Votes");

            migrationBuilder.DropTable(
                name: "SpotifyTracks");
        }
    }
}
