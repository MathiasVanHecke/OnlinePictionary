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
        public new async Task<IEnumerable<Word>> GetAllWords()
        {
            var words = await this._context.Word
                .AsNoTracking()
                .ToListAsync();
            return words;
        }

        //GET: api/rndWord
        public async Task<Word> GetRndWord()
        {
            var rndWord = await this._context.Word.SingleOrDefaultAsync();
            return rndWord;
        }
    }
}
