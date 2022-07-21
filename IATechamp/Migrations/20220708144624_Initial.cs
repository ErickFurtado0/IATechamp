using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IATechamp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Championship",
                columns: table => new
                {
                    IdChampionship = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Championship = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Championship", x => x.IdChampionship);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    IdEvent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    IdPlayer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdScoreboard = table.Column<int>(type: "int", nullable: true),
                    SetPoints = table.Column<int>(type: "int", nullable: true),
                    PlayerPoints = table.Column<int>(type: "int", nullable: true),
                    GamePoints = table.Column<int>(type: "int", nullable: true),
                    GamePlayed = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.IdPlayer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Championship");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
