using DrawIt.API.Models;
using DrawIt.Models.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DrawIt.Models.Repositories
{
    public class WordRepo : IWordRepo
    {
        private readonly DrawItAPIContext _context;

        public WordRepo(DrawItAPIContext context)
        {
            this._context = context;
        }

        // GET: api/Words
        public async Task<IEnumerable<Word>> GetAllWords()
        {
            var words = await this._context.Word
                .AsNoTracking()
                .ToListAsync();
            return words;
        }

        //GET: api/rwords/random
        public async Task<Word> GetRandomWord()
        {
            List<Word> words = await this._context.Word.AsNoTracking().ToListAsync();
            Random r = new Random();
            return words[r.Next(0, words.Count - 1)];
        }
    }
}
