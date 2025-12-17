using System.Net.Http.Json;
using DictionaryApp.Application.Interfaces;
using DictionaryApp.Domain.Entities;

namespace DictionaryApp.Infrastructure.Services
{
    public class DictionaryApiService1 : IDictionaryService
    {
        private readonly HttpClient _httpClient;

        public DictionaryApiService1(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DictionaryResponse?> GetWordAsync(string word)
        {
            var response = await _httpClient.GetAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");

            if (!response.IsSuccessStatusCode) return null;

            var data = await response.Content.ReadFromJsonAsync<List<DictionaryResponse>>();

            return data?.FirstOrDefault();
        }

        Task<List<DictionaryResponse>?> IDictionaryService.GetWordAsync(string word)
        {
            throw new NotImplementedException();
        }
    }
}


