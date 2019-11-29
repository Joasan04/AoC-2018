using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\Input.txt";
            var idAsStringArray = ParseInput(inputFilePath);
            var answer = Output(idAsStringArray);

            Console.WriteLine(answer);
            Console.ReadKey();
        }
        private static int Output(string[] idAsArray)
        {

            for (int i = 0; i < 1;)
            {
                char[] charArray = idAsArray.ElementAt(i).ToCharArray();
                var dictionary = new Dictionary<char, int>();

                for (int n = 0; n < charArray.Length; n++)
                {
                    var currentLetter = charArray[n];
                    if (dictionary.ContainsKey(currentLetter))
                    {
                        dictionary[currentLetter] += 1;
                    }
                    else
                    {
                        dictionary.Add(currentLetter,1);
                    }
                }
            }
                return 8;
        }

        private static Dictionary<char, int> CharCounts(string input)
        {
            var counts = new Dictionary<char, int>();

            foreach (var c in input.Distinct())
                counts.Add(c, 0);

            foreach (var c in input)
                counts[c] += 1;

            return counts;
        }

        private static string[] ParseInput(string inputFilePath)
        {
            string input = File.ReadAllText(inputFilePath);
            string[] inputIdAsStrings = input.Split(null);
            var idAsArray = inputIdAsStrings.Where(StringIsNotEmpty).ToArray();

            return idAsArray;
        }
        private static bool StringIsNotEmpty(string s)
        {
            if (s == "")
                return false;
            else
                return true;
        }
    }
}
