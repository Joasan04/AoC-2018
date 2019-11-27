using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ChronalCalibration
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFilePath = @"C:\Users\joakim\repos\AoC-2018\day-1\ChronalCalibration\ChronalCalibration\Input.txt";
            var numbersAsStringArray = ParseInput(inputFilePath);
            var numbersAsIntArray = ToIntArray(numbersAsStringArray);
            var Answer2 = FirstNumberTwice(numbersAsIntArray);
            var Answer = AddisionOnIntArray(numbersAsIntArray);

            Console.WriteLine("Answer to problem a: " + Answer);
            Console.WriteLine("Answer to problem b: " + Answer2);
            Console.ReadKey();
        }


        private static int FirstNumberTwice(int[] intArray)
        {
            HashSet<int> myList = new HashSet<int>();
            var last = 0;
            myList.Add(0);
            var sum = 0;
            while (true)
            {
                foreach(var y in intArray)
                {
                    sum = y + last;
                    if (myList.Contains(sum))
                    {
                        return sum;
                    }
                    myList.Add(sum);
                    last = sum;
                }
            }
        }

        private static int AddisionOnIntArray(int[] intArray)
        {
            var outPut = intArray.Sum();

            return outPut;
        }

        private static int[] ToIntArray(string[] numbersAsStrings)
        {
            int[] myint;
            myint = Array.ConvertAll<string, int>(numbersAsStrings, int.Parse);
            return myint;
        }

        private static string[] ParseInput(string inputFilePath)
        {
            string input = File.ReadAllText(inputFilePath);
            string[] inputNumbersAsStrings = input.Split(null);
            var NumbersAsArray = inputNumbersAsStrings.Where(StringIsNotEmpty).ToArray();

            return NumbersAsArray;
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
