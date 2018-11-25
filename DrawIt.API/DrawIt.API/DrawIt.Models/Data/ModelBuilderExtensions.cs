using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawIt.Models.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Word>().HasData(
            new Word
            {
                wordId = 1,
                wordNl = "Computer",
                wordEng = "Desktop",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 2,
                wordNl = "Popcorn",
                wordEng = "Popcorn",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 3,
                wordNl = "Eiland",
                wordEng = "Island",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 4,
                wordNl = "Kerstman",
                wordEng = "SantaClaus",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 5,
                wordNl = "Tandenborstel",
                wordEng = "Toothbrush",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 6,
                wordNl = "Winkelwagen",
                wordEng = "Shoppingcart",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 7,
                wordNl = "Koptelefoon",
                wordEng = "Trafficlight",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 8,
                wordNl = "Verwarming",
                wordEng = "Heater",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 9,
                wordNl = "Zonnebril",
                wordEng = "Sunglasses",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 10,
                wordNl = "Reuzenrad",
                wordEng = "Ferriswheel",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 11,
                wordNl = "Lantaarnpaal",
                wordEng = "Lamppost",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 12,
                wordNl = "Rood",
                wordEng = "Red",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 13,
                wordNl = "Computer",
                wordEng = "Desktop",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 14,
                wordNl = "Gordijn",
                wordEng = "Curtain",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 15,
                wordNl = "Computer",
                wordEng = "Desktop",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 16,
                wordNl = "Slee",
                wordEng = "Sleigh",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 17,
                wordNl = "Hersens",
                wordEng = "Brain",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 18,
                wordNl = "Wasknijper",
                wordEng = "Clothespin",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 19,
                wordNl = "Boterham",
                wordEng = "Sandwich",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 20,
                wordNl = "Luier",
                wordEng = "Diaper",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 21,
                wordNl = "Land",
                wordEng = "Country",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 22,
                wordNl = "Taart",
                wordEng = "Pie",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 23,
                wordNl = "Luchthaven",
                wordEng = "Airport",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 24,
                wordNl = "Potlood",
                wordEng = "Pencil",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 25,
                wordNl = "Paswoord",
                wordEng = "Pasword",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 26,
                wordNl = "Engel",
                wordEng = "Angel",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 27,
                wordNl = "Alarm",
                wordEng = "Alarm",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 28,
                wordNl = "Boogschieten",
                wordEng = "Archery",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 29,
                wordNl = "Oksel",
                wordEng = "Armpit",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 30,
                wordNl = "Artiest",
                wordEng = "Artist",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 31,
                wordNl = "Avatar",
                wordEng = "Avatar",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 32,
                wordNl = "Baby",
                wordEng = "Baby",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 33,
                wordNl = "Koprol",
                wordEng = "Backflip",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 34,
                wordNl = "Rugzak",
                wordEng = "Backpack",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 35,
                wordNl = "Balkon",
                wordEng = "Balcony",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 36,
                wordNl = "Ballon",
                wordEng = "Balloon",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 37,
                wordNl = "Banaan",
                wordEng = "Banana",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 38,
                wordNl = "Boef",
                wordEng = "Crook",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 39,
                wordNl = "Kapper",
                wordEng = "Barber",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 40,
                wordNl = "Schuur",
                wordEng = "Barn",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 41,
                wordNl = "Batterij",
                wordEng = "Battery",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 42,
                wordNl = "Bed",
                wordEng = "Bed",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 43,
                wordNl = "Boter",
                wordEng = "Butter",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 101,
                wordNl = "Brug",
                wordEng = "Bridge",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 44,
                wordNl = "Kogel",
                wordEng = "Bullet",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 45,
                wordNl = "Burger",
                wordEng = "Burger",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 46,
                wordNl = "Camera",
                wordEng = "Camera",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 47,
                wordNl = "Snoep",
                wordEng = "Candy",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 48,
                wordNl = "Auto",
                wordEng = "Car",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 49,
                wordNl = "Wortel",
                wordEng = "Carrot",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 50,
                wordNl = "Kasteel",
                wordEng = "Castle",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 51,
                wordNl = "Kamp",
                wordEng = "Camp",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 52,
                wordNl = "Kerk",
                wordEng = "Church",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 53,
                wordNl = "Circus",
                wordEng = "Circus",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 54,
                wordNl = "Wolk",
                wordEng = "Cloud",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 55,
                wordNl = "Klok",
                wordEng = "Clock",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 56,
                wordNl = "Koffie",
                wordEng = "Cofee",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 57,
                wordNl = "Koe",
                wordEng = "Cow",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 58,
                wordNl = "Krab",
                wordEng = "Crab",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 59,
                wordNl = "Kruisboog",
                wordEng = "Crossbow",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 60,
                wordNl = "Diamand",
                wordEng = "Diamond",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 61,
                wordNl = "Hond",
                wordEng = "Dog",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 62,
                wordNl = "Droom",
                wordEng = "Dream",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 63,
                wordNl = "Hond",
                wordEng = "Dog",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 64,
                wordNl = "Oost",
                wordEng = "East",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 65,
                wordNl = "Aarde",
                wordEng = "Earth",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 66,
                wordNl = "Oorbel",
                wordEng = "Earring",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 67,
                wordNl = "Oog",
                wordEng = "Eye",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 68,
                wordNl = "Gezicht",
                wordEng = "Face",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 69,
                wordNl = "Veer",
                wordEng = "Feather",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 70,
                wordNl = "Firefox",
                wordEng = "Firefox",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 71,
                wordNl = "Vis",
                wordEng = "Fish",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 72,
                wordNl = "Flamingo",
                wordEng = "Flamingo",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 73,
                wordNl = "Bloem",
                wordEng = "Flower",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 74,
                wordNl = "Vork",
                wordEng = "Fork",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 75,
                wordNl = "Fontijn",
                wordEng = "Fountain",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 76,
                wordNl = "Frankrijk",
                wordEng = "France",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 77,
                wordNl = "Fruit",
                wordEng = "Fruit",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 78,
                wordNl = "Giraf",
                wordEng = "Giraffe",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 79,
                wordNl = "Fruit",
                wordEng = "Fruit",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 80,
                wordNl = "Meisje",
                wordEng = "Girl",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 81,
                wordNl = "Geest",
                wordEng = "Ghost",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 82,
                wordNl = "Lijm",
                wordEng = "Glue",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 83,
                wordNl = "Goudvis",
                wordEng = "Goldfish",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 84,
                wordNl = "Fruit",
                wordEng = "Fruit",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 85,
                wordNl = "Gras",
                wordEng = "Grass",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 86,
                wordNl = "Granaat",
                wordEng = "Grenade",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 87,
                wordNl = "Gitaar",
                wordEng = "Guitar",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 88,
                wordNl = "Paard",
                wordEng = "Horse",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 89,
                wordNl = "Ijsberg",
                wordEng = "Iceberg",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 90,
                wordNl = "Ketchup",
                wordEng = "Ketchup",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 91,
                wordNl = "Springen",
                wordEng = "Jump",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 92,
                wordNl = "Sleutel",
                wordEng = "Key",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 93,
                wordNl = "Toetsenbord",
                wordEng = "Keyboard",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 94,
                wordNl = "Ladder",
                wordEng = "Ladder",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 95,
                wordNl = "Lava",
                wordEng = "Lava",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 96,
                wordNl = "Aansteker",
                wordEng = "Lighter",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 97,
                wordNl = "Leeuw",
                wordEng = "Lion",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 98,
                wordNl = "Liefde",
                wordEng = "Love",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 99,
                wordNl = "Medusa",
                wordEng = "Medusa",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            }
            ,
            new Word
            {
                wordId = 100,
                wordNl = "Zeemeermin",
                wordEng = "Mermaid",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            }
            );
        }
    }
}
