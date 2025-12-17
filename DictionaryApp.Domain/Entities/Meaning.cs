namespace DictionaryApp.Domain.Entities
{
    public class Meaning
    {
        public string? PartOfSpeech { get; set; }
        public List<Definitions>? Definitions { get; set; }
        public List<string>? Synonyms { get; set; } // top-level synonyms in meanings
        public List<string>? Antonyms { get; set; } // top-level antonyms in meanings
    }
}
