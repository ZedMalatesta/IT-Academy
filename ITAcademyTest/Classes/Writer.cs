using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITAcademyTest
{
    class Writer
    {
        public static void SequencesDictionaryWrite(string textfilepath, SequencesDictionary concord)
        {
            using (StreamWriter file = new StreamWriter(textfilepath, false, Encoding.GetEncoding("windows-1251")))
            {
                file.WriteLine(concord.ToString());
            }
        }
    }
}
