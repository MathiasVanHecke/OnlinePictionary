using System.Collections.Generic;
using System.Threading.Tasks;
using DrawIt.Models.Data;

namespace DrawIt.Models.Repositories
{
    public interface IWordRepo
    {
        new Task<IEnumerable<Word>> GetAllWords();
        Task<Word> GetRndWord();
    }
}