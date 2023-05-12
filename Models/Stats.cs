namespace GRitiD.Models
{
    public class Stats
    {
        public int NumberOfAllWords { get; set; }

        public int NumberOfWordsThatContainOnlyDigits { get; set; }

        public int NumberOfWordsStartingWithSmallLetter { get; set; }

        public int NumberOfWordsStartingWithCapitalLetter { get; set; }

        public string TheLongestWord { get; set; }

        public string TheShortestWord { get; set; }
    }
}
