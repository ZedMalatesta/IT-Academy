using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;


namespace ITAcademyTest.Classes
{
    class LettersSequence : ILettersSequence
    {
        public string Value { get; set; }
        public int CountInText { get; set; }

        public LettersSequence(string value, int countintext)
        {
            Value = value;
            CountInText = countintext;
        }

        public override string ToString()
        {
            return Value + " " + CountInText;
        }
    }
}
