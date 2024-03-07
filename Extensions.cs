using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2
{
    public static class Extensions
    {
        public static void WordCounter(this string text)
        {
            string[] arrayWords = text.Split(' ');

            Console.WriteLine($"Text has {arrayWords.Length} words");
        }

        public static bool IsEven(this int number)
        { 
            return number % 2 == 0;
        }

        public static List<string> GetListOfUniqNames(this List<string> names)
        {
            return names.Distinct().ToList();
        }

    }
}
