using DictionaryApp.Application.Interfaces;
using DictionaryApp.Domain.Entities;
using DictionaryApp.Infrastructure.Settings;
using Microsoft.Extensions.Options;
using System.Net.Http.Json;

namespace DictionaryApp.Infrastructure.Services
{
    public class DictionaryApiService : IDictionaryService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;

        public DictionaryApiService(HttpClient httpClient, IOptions<DictionaryApiSettings> options)
        {
            _httpClient = httpClient;
            _baseUrl = options.Value.BaseUrl;
        }

        public async Task<List<DictionaryResponse>?> GetWordAsync(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return null;
            var url = $"{_baseUrl}{word}";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode) return null;

            var apiResponse = await response.Content.ReadFromJsonAsync<List<DictionaryResponse>>();
            return apiResponse;
        }
    }
}
