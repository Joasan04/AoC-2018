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
            Console.Write("Set number of iterations: ");
            //Iterations set in method FirstNumberTwice.

            var inputFilePath = @"..\..\Input.txt";
            var numbersAsStringArray = ParseInput(inputFilePath);
            var numbersAsIntArray = ToIntArray(numbersAsStringArray);
            var answer2 = FirstNumberTwice(numbersAsIntArray);
            var answer1 = AddisionOnIntArray(numbersAsIntArray);
            
            
            Console.WriteLine("Answer to problem a: " + answer1);
            Console.WriteLine("Answer to problem b: " + answer2);
            Console.ReadKey();
        }


        private static int FirstNumberTwice(int[] intArray)
        {
            HashSet<int> myList = new HashSet<int>();
            var last = 0;
            myList.Add(0);
            var sum = 0;
            int maxIterations = int.Parse(Console.ReadLine());
            for (int i = 0;i < maxIterations ; i++)
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
            Console.WriteLine("Could not calculate. Too few itarations or imposible senarion.");
            return 0;
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
