using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ITAcademyTest.Interfaces;
using ITAcademyTest.Classes;


namespace ITAcademyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string textfilepath = @"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\poe.txt";

            Writer.SequencesDictionaryWrite(@"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\out.txt", Reader.SequencesDictionaryCreator(textfilepath));
        }
    }
}
