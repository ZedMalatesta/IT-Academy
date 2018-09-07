using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;

namespace ITAcademyTest.Classes
{
    class Parser
    {

        public static Dictionary<string, IEnumerable<ILettersSequence>> CreateSequencesDictionary(IEnumerable<ILettersSequence> en)
        {
            return en.OrderByDescending(x => x.CountInText)
                .GroupBy(x => x.Value.Substring(0, 1)
                .ToUpper())
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Select(y => y));
        }

        public static IEnumerable<ILettersSequence> UnionLettersSequenceEnumerable(IEnumerable<ILettersSequence> en1, IEnumerable<ILettersSequence> en2)
        {
            return en1.Concat(en2)
                .GroupBy(x => x.Value)
                .Select(x => new LettersSequence(x.Key, x.Sum(y => y.CountInText)));
        }

        public static IEnumerable<ILettersSequence> SplitIntoLettersSequence(string text)
        {
            return Regex.Matches(text, @"\b[A-Za-zА-Яа-я-']+\b")
                .Cast<Match>()
                .Select(x => x.Value.ToLower())
                .GroupBy(x => x)
                .Select(x => new LettersSequence(x.Key, x.Count()));
        }
    }
}
