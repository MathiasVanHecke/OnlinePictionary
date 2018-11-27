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
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace DrawIt.API.Controllers
{
    [Authorize]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class WordsController : ControllerBase
    {
        private readonly IWordRepo _wordRepo;
        private readonly ILogger _logger;

        public WordsController(IWordRepo wordRepo, ILogger logger)
        {
            _wordRepo = wordRepo;
            _logger = logger;
        }

        // GET: api/Words
        [Route("api/words")]
        [HttpGet]
        public async Task<IActionResult> GetAllWords()
        {
            try
            {
                var words = await _wordRepo.GetAllWords();
                return Ok(words);
            }
            catch (Exception)
            {
                _logger.LogWarning(2000, "Het is niet gelukt om alle woorden op te halen");
                throw;
            }
        }

        // GET: api/Words/random
        [Route("api/words/random")]
        [HttpGet]
        public async Task<IActionResult> GetRandomWord()
        {
            try
            {
                Word rndWord = await _wordRepo.GetRandomWord();
                return Ok(rndWord);
            }
            catch (Exception)
            {
                _logger.LogWarning(2000, "Het is niet gelukt om een willekeurig woord op te halen");
                throw;
            }

        }


    }
}