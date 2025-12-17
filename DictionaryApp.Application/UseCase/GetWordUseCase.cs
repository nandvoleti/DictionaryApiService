using DictionaryApp.Application.Interfaces;
using DictionaryApp.Domain.Entities;

namespace DictionaryApp.Application.UseCase
{
    public class GetWordUseCase
    {
        private readonly IDictionaryService _dictionaryService;

        public GetWordUseCase(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        public async Task<DictionaryResponse?> ExecuteAsync(string word)
        {
            var list = await _dictionaryService.GetWordAsync(word);
            return list?.FirstOrDefault();
        }
    }
}
