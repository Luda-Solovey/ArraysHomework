using ArraysVocabularyHW;

namespace ArraysHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vocabularies vocabularies = new Vocabularies();
            vocabularies.TranslateToUkrainien("banana");
            vocabularies.TranslateToUkrainien("grape");

            vocabularies.TranslateToEnglish("вишня");
            vocabularies.TranslateToEnglish("шоколад");

            vocabularies.AddWord("grape", "виноград");

            vocabularies.PrintWords();
        }
    }
}
