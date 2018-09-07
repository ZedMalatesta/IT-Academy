using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;

namespace ITAcademyTest.Classes
{
    class SequencesDictionary
    {
        private Dictionary<string, IEnumerable<ISymbolsSequence>> ABIndex { get; set; }

        public SequencesDictionary(Dictionary<string, IEnumerable<ISymbolsSequence>> abindex)
        {
            ABIndex = abindex;
        }
    }
}
