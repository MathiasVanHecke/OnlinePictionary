using System.Collections.Generic;
using System.Threading.Tasks;
using DrawIt.Models.Data;

namespace DrawIt.Models.Repositories
{
    public interface IWordRepo
    {
        Task<IEnumerable<Word>> GetAllWords();
        Task<Word> GetRandomWord();
    }
}