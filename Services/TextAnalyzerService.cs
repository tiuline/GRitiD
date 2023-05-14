using GRitiD.Models;
using GRitiD.Servces.Interfaces;

namespace GRitiD.Servces
{
    internal class TextAnalyzerService : ITextAnalyzerService
    {
        public Stats Analyze(string text)
        {
            // Creating the stats object
            Stats stats = new Stats();

            //separate into individual words
            string[] words = text.Split(' ');

            // lets get the longest words in document
            string longestWords = words.OrderByDescending(w => w.Length).FirstOrDefault();
            string shortestWords = words.OrderBy(w => w.Length).FirstOrDefault();

            // count the words
            stats.NumberOfAllWords = words.Count();

            // lets make a function to see if the word is a number.
            stats.NumberOfWordsThatContainOnlyDigits = words.Count(word => IsNumericWord(word));

            // using char class to see if the first letter is lowerCase
            stats.NumberOfWordsStartingWithSmallLetter = words.Count(word => Char.IsLower(word[0]));

            // same as before but to UpperCase letters
            stats.NumberOfWordsStartingWithCapitalLetter = words.Count(word => Char.IsUpper(word[0]));

            stats.TheLongestWord = words.FirstOrDefault(w => w.Length == longestWords.Length);
            stats.TheShortestWord = words.FirstOrDefault(w => w.Length == shortestWords.Length);

            Console.WriteLine(stats.NumberOfAllWords);
            Console.WriteLine(stats.NumberOfWordsThatContainOnlyDigits);
            Console.WriteLine(stats.NumberOfWordsStartingWithSmallLetter);
            Console.WriteLine(stats.NumberOfWordsStartingWithCapitalLetter);
            Console.WriteLine(stats.TheLongestWord);
            Console.WriteLine(stats.TheShortestWord);

            return stats;
        }

        public static bool IsNumericWord(string word)
        {
            if (int.TryParse(word, out int number))
                return true;
            return false;
        }
    }
}
