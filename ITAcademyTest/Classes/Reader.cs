using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;

namespace ITAcademyTest.Classes
{
    static class Reader
    {
        public static SequencesDictionary SequencesDictionaryCreator(string textfilepath)
        {
            string sequence;

            IEnumerable<ILettersSequence> stack = Enumerable.Empty<ILettersSequence>();

            using (StreamReader reader = new StreamReader(textfilepath, Encoding.GetEncoding("windows-1251")))
            {
                while (reader.Peek() >= 0)
                {
                    sequence = reader.ReadLine();
                    stack = Parser.UnionLettersSequenceEnumerable(stack, Parser.SplitIntoLettersSequence(sequence));
  
                }
            }

            return new SequencesDictionary(Parser.CreateSequencesDictionary(stack));
        }
    }
}