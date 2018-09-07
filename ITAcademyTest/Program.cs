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
            Console.OutputEncoding = Encoding.UTF8;
            string sequence = "";
            int num = 1, s = 0;
            IEnumerable<ISymbolsSequence> stack = Parser.SplitIntoWords(sequence, num);

            using (StreamReader reader = new StreamReader(@"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\ed.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    while ((char)reader.Peek() != '.' && (char)reader.Peek() != '!' && (char)reader.Peek() != '?')
                    {
                        sequence += Convert.ToString((char)reader.Read());
                    }
                    reader.Read();
                    if (Regex.IsMatch(sequence, @"\b[A-Za-zА-Яа-я-]+\b"))
                    {
                        stack = Parser.UnionEn(stack, Parser.SplitIntoWords(sequence, num));
                        foreach (var a in stack)
                        {

                            Console.Write(a.Value + ":" + a.CountInText + ":");
                            Console.WriteLine();
                        }
                        num++;
                        Console.Write(sequence);
                    }
                    sequence = "";
                }
            }
            using (StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Zedd\source\repos\ITAcademyTest\ITAcademyTest\Resources\out.txt"))
            {
                foreach (var a in stack)
                {
                    file.Write(a.Value + ":" + a.CountInText);
                    file.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
