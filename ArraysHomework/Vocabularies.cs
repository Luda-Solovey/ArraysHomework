using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysVocabularyHW
{
    public class Vocabularies
    {
        string[] englishWords = new string[5] { "apple", "banana", "cherry", "date", "elderberry" };
        string[] ukrainienWords = new string[5] { "яблуко", "банан", "вишня", "фінік", "бузина" };

        public void PrintWords()
        {
            for (int i = 0; i < englishWords.Length; i++)
            {
                Console.WriteLine($"{englishWords[i]} - {ukrainienWords[i]}");
            }
        }

        public void AddWord(string englishWord, string ukrainienWord)
        {
            Array.Resize(ref englishWords, englishWords.Length + 1);
            Array.Resize(ref ukrainienWords, ukrainienWords.Length + 1);
            englishWords[englishWords.Length - 1] = englishWord;
            ukrainienWords[ukrainienWords.Length - 1] = ukrainienWord;
        }

        public void TranslateToUkrainien(string englishWord)
        {
            for (int i = 0; i < englishWords.Length; i++)
            {
                if (englishWords[i] == englishWord)
                {
                    Console.WriteLine($"{englishWord} - {ukrainienWords[i]}");
                    return;
                }
            }
            Console.WriteLine("Word not found.");
        }

        public void TranslateToEnglish(string ukrainienWord)
        {
            for (int i = 0; i < ukrainienWords.Length; i++)
            {
                if (ukrainienWords[i] == ukrainienWord)
                {
                    Console.WriteLine($"{ukrainienWord} - {englishWords[i]}");
                    return;
                }
            }
            Console.WriteLine("Слово не знайдено.");
        }
    }
}
