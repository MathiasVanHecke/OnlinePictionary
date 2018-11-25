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
                wordEng = "Santa Claus",
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
                wordEng = "Shopping cart",
                likes = 0,
                dislikes = 0,
                Guessed = 0,
                DNGuessed = 0,
            },
            new Word
            {
                wordId = 7,
                wordNl = "Koptelefoon",
                wordEng = "Traffic light",
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
                wordEng = "Ferris wheel",
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
            }
            );
        }
    }
}
