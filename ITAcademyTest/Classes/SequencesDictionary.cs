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
        private Dictionary<string, IEnumerable<ILettersSequence>> ABIndex { get; set; }

        public SequencesDictionary(Dictionary<string, IEnumerable<ILettersSequence>> abindex)
        {
            ABIndex = abindex;
        }

        public override string ToString()
        {
            return String.Join("\r\n", (ABIndex.Select(x => x.Key + "\r\n" + String.Join("\r\n", x.Value.Select(y => y.ToString())))));
        }
    }
}
