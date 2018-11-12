using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DrawIt.Models.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Word",
                columns: table => new
                {
                    wordId = table.Column<Guid>(nullable: false),
                    wordNl = table.Column<string>(nullable: true),
                    wordEng = table.Column<string>(nullable: true),
                    likes = table.Column<int>(nullable: false),
                    dislikes = table.Column<int>(nullable: false),
                    Guessed = table.Column<int>(nullable: false),
                    DNGuessed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Word", x => x.wordId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Word");
        }
    }
}
