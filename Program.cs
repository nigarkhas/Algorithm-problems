using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just call the methods of static class MyAlgorithms. For example:

            MyAlgorithms.FindFactorial();

        }     
    }
    static class MyAlgorithms
    {
        // Check if the input is palindrome or not 
        public static void CheckForPalindrome()
        {
            string input;
            Console.WriteLine("Please enter the word: ");
            input = Console.ReadLine();

            var symbols = input.ToCharArray();
            Array.Reverse(symbols);

            var reverse = String.Join("", symbols);

            if (reverse == input)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }


        // Convert entered number to list consisting of digits of that number
        public static void NumberToList()
        {
            int number = GetTheNumber(), size;

            size = number.ToString().Length;
            var array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = number % 10;
                number /= 10;
            }

            for (int i = array.Length - 1; i > -1; i--)
            {
                Console.Write($"{array[i]}");

                if (i != 0)
                    Console.Write(", ");
            }

        }

        // Find number in the sentence. Using StringBuilder here.
        public static void FindNumber()
        {
            Console.WriteLine("Please enter the sentence: ");
            string sentence = Console.ReadLine();

            StringBuilder numbers = new StringBuilder();
            StringBuilder positions = new StringBuilder();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (Char.IsDigit(sentence[i]))
                {
                    numbers.Append(sentence[i]).Append(" ");
                    positions.Append(i).Append(" ");
                }
            }

            if (numbers.Length != 0)
                Console.WriteLine($"Numbers: {numbers}and positions: {positions}respectively");
            else
                Console.WriteLine("Your sentence does not contain numbers.");
        }

        // Find factorial of the number
        public static void FindFactorial()
        {
            int number = GetTheNumber(), result = 1;

            if (number > 0)
            {
                for (int i = 1; i < number + 1; i++)
                {
                    result *= i;
                }

                Console.WriteLine($"Factorial of {number} is {result}");
            }
            else if (number < 0)
                Console.WriteLine("Factorial for negative number is not identified.");
            else
                Console.WriteLine("Factorial is 1");
        }

        // Find minimum and the maximum number from the list of numbers
        public static void FindMinMax()
        {
            int size, number, min, max;
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the size for array of numbers: ");
     
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.Clear();
                Console.WriteLine("Invalid. Please enter number: ");
            }

            Console.Clear();
            Console.WriteLine("Now fill the array with numbers. ");
            for (int i = 0; i < size; i++)
            {
                number = GetTheNumber();
                numbers.Add(number);
                Console.Clear();
            }

            min = numbers[0];
            max = numbers[0];

            foreach (var item in numbers)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;

                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Max is {max} and min is {min}");
        }

        // Check two words if they are anagram of each other or not
        public static void CheckForAnagram()
        {
            string first, second;
            Console.WriteLine("Please enter the first word: ");
            first = Console.ReadLine();
            Console.WriteLine("Please enter the second word: ");
            second = Console.ReadLine();

            var firstSymbols = first.ToLower().ToList<char>();
            firstSymbols.Sort();
            first = string.Join("", firstSymbols);

            var secondSymbols = second.ToLower().ToList<char>();
            secondSymbols.Sort();
            second = string.Join("", secondSymbols);

            if (first == second)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }

        // Just to minimize the size of some methods

        private static int GetTheNumber()
        {
            int number; 

            Console.WriteLine("Enter the number: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Clear();
                Console.WriteLine("Invalid. Please enter the number: ");
            }

            return number;
        }
    }

}
