namespace DictionaryApp.Domain.Entities
{
    public class DictionaryResponse
    {
        public string? Word { get; set; }
        public List<Phonetic>? Phonetics { get; set; }
        public List<Meaning>? Meanings { get; set; }
        public License? License { get; set; }
        public List<string>? SourceUrls { get; set; }
    }
}
