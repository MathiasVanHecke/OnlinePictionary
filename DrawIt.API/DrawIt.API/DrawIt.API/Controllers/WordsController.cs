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
    [Route("api/[controller]")]
    [ApiController]
    public class WordsController : ControllerBase
    {
        private readonly IWordRepo _wordRepo;

        public WordsController(IWordRepo wordRepo)
        {
            _wordRepo = wordRepo;
        }

        // GET: api/Words
        [HttpGet]
        public async Task<IActionResult> GetAllWords()
        {
            //return _context.Word;
            var words = await _wordRepo.GetAllWords(); //met include van platforms
            return Ok(words);
        }


        // GET: api/Words/rnd
        [HttpGet("{rnd}")]
        public ActionResult<string> Get(string rnd)
        {
            if (rnd == "rnd") ;
            //return _context.Word;
            var rndWord = _wordRepo.GetRndWord(); //met include van platforms
            return Ok(rndWord);
        }


    }
}