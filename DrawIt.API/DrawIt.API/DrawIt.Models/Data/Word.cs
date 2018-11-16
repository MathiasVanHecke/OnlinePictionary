using System;
using System.Collections.Generic;
using System.Text;

namespace DrawIt.Models.Data
{
    public class Word
    {
        public int wordId { get; set; }
        public String wordNl { get; set; }
        public String wordEng { get; set; }
        public int likes { get; set; }
        public int dislikes { get; set; }
        public int Guessed { get; set; }
        public int DNGuessed { get; set; }
    }
}
