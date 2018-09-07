using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;


namespace ITAcademyTest.Classes
{
    class SymbolsSequence : ISymbolsSequence
    {
        public string Value { get; set; }
        public int CountInText { get; set; }

        /*public SymbolsSequence(string value, int countintext)
        {
            Value = value;
            CountInText = countintext;
        }*/
    }
}
