using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DrawIt.API.Models;
using DrawIt.Models.Data;
using DrawIt.Models.Repositories;

namespace DrawIt.API.Controllers
{
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly IWordRepo _wordRepo;

        public WordsController(IWordRepo wordRepo)
        {
            _wordRepo = wordRepo;
        }

        // GET: api/Words
        [Route("api/words")]
        [HttpGet]
        public async Task<IActionResult> GetAllWords()
        {
            //return _context.Word;
            var words = await _wordRepo.GetAllWords();
            return Ok(words);
        }


        // GET: api/Words/random
        [Route("api/words/random")]
        [HttpGet]
        public async Task<IActionResult> GetRandomWord()
        {
            Word rndWord =  await _wordRepo.GetRandomWord();
            return Ok(rndWord);
        }


    }
}