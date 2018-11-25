using Microsoft.EntityFrameworkCore.Migrations;

namespace DrawIt.Models.Migrations
{
    public partial class Words : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Word",
                columns: new[] { "wordId", "DNGuessed", "Guessed", "dislikes", "likes", "wordEng", "wordNl" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, 0, "Desktop", "Computer" },
                    { 18, 0, 0, 0, 0, "Clothespin", "Wasknijper" },
                    { 17, 0, 0, 0, 0, "Brain", "Hersens" },
                    { 16, 0, 0, 0, 0, "Sleigh", "Slee" },
                    { 15, 0, 0, 0, 0, "Desktop", "Computer" },
                    { 14, 0, 0, 0, 0, "Curtain", "Gordijn" },
                    { 13, 0, 0, 0, 0, "Desktop", "Computer" },
                    { 12, 0, 0, 0, 0, "Red", "Rood" },
                    { 11, 0, 0, 0, 0, "Lamppost", "Lantaarnpaal" },
                    { 10, 0, 0, 0, 0, "Ferris wheel", "Reuzenrad" },
                    { 9, 0, 0, 0, 0, "Sunglasses", "Zonnebril" },
                    { 8, 0, 0, 0, 0, "Heater", "Verwarming" },
                    { 7, 0, 0, 0, 0, "Traffic light", "Koptelefoon" },
                    { 6, 0, 0, 0, 0, "Shopping cart", "Winkelwagen" },
                    { 5, 0, 0, 0, 0, "Toothbrush", "Tandenborstel" },
                    { 4, 0, 0, 0, 0, "Santa Claus", "Kerstman" },
                    { 3, 0, 0, 0, 0, "Island", "Eiland" },
                    { 2, 0, 0, 0, 0, "Popcorn", "Popcorn" },
                    { 19, 0, 0, 0, 0, "Sandwich", "Boterham" },
                    { 20, 0, 0, 0, 0, "Diaper", "Luier" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 20);
        }
    }
}
