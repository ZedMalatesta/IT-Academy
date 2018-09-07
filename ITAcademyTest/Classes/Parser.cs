using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;
using ITAcademyTest.Classes;

namespace ITAcademyTest.Classes
{
    class Parser
    {
        public static IEnumerable<ISymbolsSequence> UnionEn(IEnumerable<ISymbolsSequence> en1, IEnumerable<ISymbolsSequence> en2)
        {
            var union = en1.Concat(en2)
                .GroupBy(x => x.Value)
                .Select(x => new SymbolsSequence { Value = x.Key, CountInText = x.Sum(y => y.CountInText) });

            return union;
        }

        public static IEnumerable<ISymbolsSequence> SplitIntoWords(string text, int number)
        {
            var concat = Regex.Matches(text, @"\b[A-Za-zА-Яа-я-']+\b")
                .Cast<Match>()
                .Select(x => x.Value.ToLower())
                .GroupBy(x => x)
                .Select(x => new SymbolsSequence { Value = x.Key, CountInText = x.Count() });

            return concat;
        }
    }
}
