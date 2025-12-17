using DictionaryApp.Application.Interfaces;
using DictionaryApp.Application.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DictionaryController : Controller
    {
        private readonly IDictionaryService _dictionaryService;

        public DictionaryController(IDictionaryService dictionaryService)
        {
            _dictionaryService = dictionaryService;
        }

        [HttpGet("{word}")]
        public async Task<IActionResult> GetWord(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return BadRequest(new { message = "Word cannot be empty." });

            var result = await _dictionaryService.GetWordAsync(word);

            if (result == null || result.Count == 0)
                return NotFound(new { message = $"Word '{word}' not found." });

            return Ok(result);
        }
    }
}
