using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ITAcademyTest
{
    class Program
    {
        static int Main(string[] args)
        {

            string textfilepath = @"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\poe.txt";

            Writer.SequencesDictionaryWrite(@"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\out.txt", Reader.SequencesDictionaryCreator(textfilepath));

            /*
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a path.");
                return 1;
            }

            if (File.Exists(args[0]) == false)
            {
                System.Console.WriteLine("Please enter a right path to reading.");
                return 1;
            }

            if (File.Exists(args[1]) == false)
            {
                System.Console.WriteLine("Please enter a right path to writing.");
                return 1;
            }

            string textfilepath = args[0];

            Writer.SequencesDictionaryWrite(args[1], Reader.SequencesDictionaryCreator(textfilepath));

            */
            return 0;
        }
    }
}