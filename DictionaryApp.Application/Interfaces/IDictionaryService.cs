using DictionaryApp.Domain.Entities;

namespace DictionaryApp.Application.Interfaces
{
    public interface IDictionaryService
    {
        Task<List<DictionaryResponse>?> GetWordAsync(string word);
    }
}
