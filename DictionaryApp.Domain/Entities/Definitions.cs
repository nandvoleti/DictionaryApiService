namespace DictionaryApp.Domain.Entities
{
    public class Definitions
    {
        public string? Definition { get; set; }
        public string? Example { get; set; }
        public List<string>? Synonyms { get; set; }
        public List<string>? Antonyms { get; set; }
    }
}
