using Microsoft.EntityFrameworkCore.Migrations;

namespace DrawIt.Models.Migrations
{
    public partial class Addedwords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 4,
                column: "wordEng",
                value: "SantaClaus");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 6,
                column: "wordEng",
                value: "Shoppingcart");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 7,
                column: "wordEng",
                value: "Trafficlight");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 10,
                column: "wordEng",
                value: "Ferriswheel");

            migrationBuilder.InsertData(
                table: "Word",
                columns: new[] { "wordId", "DNGuessed", "Guessed", "dislikes", "likes", "wordEng", "wordNl" },
                values: new object[,]
                {
                    { 77, 0, 0, 0, 0, "Fruit", "Fruit" },
                    { 76, 0, 0, 0, 0, "France", "Frankrijk" },
                    { 75, 0, 0, 0, 0, "Fountain", "Fontijn" },
                    { 74, 0, 0, 0, 0, "Fork", "Vork" },
                    { 73, 0, 0, 0, 0, "Flower", "Bloem" },
                    { 72, 0, 0, 0, 0, "Flamingo", "Flamingo" },
                    { 71, 0, 0, 0, 0, "Fish", "Vis" },
                    { 70, 0, 0, 0, 0, "Firefox", "Firefox" },
                    { 68, 0, 0, 0, 0, "Face", "Gezicht" },
                    { 78, 0, 0, 0, 0, "Giraffe", "Giraf" },
                    { 67, 0, 0, 0, 0, "Eye", "Oog" },
                    { 66, 0, 0, 0, 0, "Earring", "Oorbel" },
                    { 65, 0, 0, 0, 0, "Earth", "Aarde" },
                    { 64, 0, 0, 0, 0, "East", "Oost" },
                    { 63, 0, 0, 0, 0, "Dog", "Hond" },
                    { 62, 0, 0, 0, 0, "Dream", "Droom" },
                    { 69, 0, 0, 0, 0, "Feather", "Veer" },
                    { 79, 0, 0, 0, 0, "Fruit", "Fruit" },
                    { 81, 0, 0, 0, 0, "Ghost", "Geest" },
                    { 61, 0, 0, 0, 0, "Dog", "Hond" },
                    { 98, 0, 0, 0, 0, "Love", "Liefde" },
                    { 97, 0, 0, 0, 0, "Lion", "Leeuw" },
                    { 96, 0, 0, 0, 0, "Lighter", "Aansteker" },
                    { 95, 0, 0, 0, 0, "Lava", "Lava" },
                    { 94, 0, 0, 0, 0, "Ladder", "Ladder" },
                    { 93, 0, 0, 0, 0, "Keyboard", "Toetsenbord" },
                    { 92, 0, 0, 0, 0, "Key", "Sleutel" },
                    { 91, 0, 0, 0, 0, "Jump", "Springen" },
                    { 90, 0, 0, 0, 0, "Ketchup", "Ketchup" },
                    { 89, 0, 0, 0, 0, "Iceberg", "Ijsberg" },
                    { 88, 0, 0, 0, 0, "Horse", "Paard" },
                    { 87, 0, 0, 0, 0, "Guitar", "Gitaar" },
                    { 86, 0, 0, 0, 0, "Grenade", "Granaat" },
                    { 85, 0, 0, 0, 0, "Grass", "Gras" },
                    { 84, 0, 0, 0, 0, "Fruit", "Fruit" },
                    { 83, 0, 0, 0, 0, "Goldfish", "Goudvis" },
                    { 82, 0, 0, 0, 0, "Glue", "Lijm" },
                    { 80, 0, 0, 0, 0, "Girl", "Meisje" },
                    { 60, 0, 0, 0, 0, "Diamond", "Diamand" },
                    { 58, 0, 0, 0, 0, "Crab", "Krab" },
                    { 99, 0, 0, 0, 0, "Medusa", "Medusa" },
                    { 37, 0, 0, 0, 0, "Banana", "Banaan" },
                    { 36, 0, 0, 0, 0, "Balloon", "Ballon" },
                    { 35, 0, 0, 0, 0, "Balcony", "Balkon" },
                    { 34, 0, 0, 0, 0, "Backpack", "Rugzak" },
                    { 33, 0, 0, 0, 0, "Backflip", "Koprol" },
                    { 32, 0, 0, 0, 0, "Baby", "Baby" },
                    { 31, 0, 0, 0, 0, "Avatar", "Avatar" },
                    { 30, 0, 0, 0, 0, "Artist", "Artiest" },
                    { 29, 0, 0, 0, 0, "Armpit", "Oksel" },
                    { 28, 0, 0, 0, 0, "Archery", "Boogschieten" },
                    { 27, 0, 0, 0, 0, "Alarm", "Alarm" },
                    { 26, 0, 0, 0, 0, "Angel", "Engel" },
                    { 25, 0, 0, 0, 0, "Pasword", "Paswoord" },
                    { 24, 0, 0, 0, 0, "Pencil", "Potlood" },
                    { 23, 0, 0, 0, 0, "Airport", "Luchthaven" },
                    { 22, 0, 0, 0, 0, "Pie", "Taart" },
                    { 21, 0, 0, 0, 0, "Country", "Land" },
                    { 38, 0, 0, 0, 0, "Crook", "Boef" },
                    { 59, 0, 0, 0, 0, "Crossbow", "Kruisboog" },
                    { 39, 0, 0, 0, 0, "Barber", "Kapper" },
                    { 41, 0, 0, 0, 0, "Battery", "Batterij" },
                    { 57, 0, 0, 0, 0, "Cow", "Koe" },
                    { 56, 0, 0, 0, 0, "Cofee", "Koffie" },
                    { 55, 0, 0, 0, 0, "Clock", "Klok" },
                    { 54, 0, 0, 0, 0, "Cloud", "Wolk" },
                    { 53, 0, 0, 0, 0, "Circus", "Circus" },
                    { 52, 0, 0, 0, 0, "Church", "Kerk" },
                    { 51, 0, 0, 0, 0, "Camp", "Kamp" },
                    { 50, 0, 0, 0, 0, "Castle", "Kasteel" },
                    { 49, 0, 0, 0, 0, "Carrot", "Wortel" },
                    { 48, 0, 0, 0, 0, "Car", "Auto" },
                    { 47, 0, 0, 0, 0, "Candy", "Snoep" },
                    { 46, 0, 0, 0, 0, "Camera", "Camera" },
                    { 45, 0, 0, 0, 0, "Burger", "Burger" },
                    { 44, 0, 0, 0, 0, "Bullet", "Kogel" },
                    { 101, 0, 0, 0, 0, "Bridge", "Brug" },
                    { 43, 0, 0, 0, 0, "Butter", "Boter" },
                    { 42, 0, 0, 0, 0, "Bed", "Bed" },
                    { 40, 0, 0, 0, 0, "Barn", "Schuur" },
                    { 100, 0, 0, 0, 0, "Mermaid", "Zeemeermin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 101);

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 4,
                column: "wordEng",
                value: "Santa Claus");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 6,
                column: "wordEng",
                value: "Shopping cart");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 7,
                column: "wordEng",
                value: "Traffic light");

            migrationBuilder.UpdateData(
                table: "Word",
                keyColumn: "wordId",
                keyValue: 10,
                column: "wordEng",
                value: "Ferris wheel");
        }
    }
}
