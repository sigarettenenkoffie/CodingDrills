using System;

namespace GapfulNumbers.sln
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"582 is gapful? {IsGapful(582)}");
            Console.WriteLine($"583 is gapful? {IsGapful(583)}");

            Console.WriteLine("\nAll gapful numbers from 100 - 1000 :");
            for (int i = 100; i < 1000; i++)
            {
                if (IsGapful(i))
                    Console.Write($"{i} ");
            }
        }

        static bool IsGapful(int number)
        {
            string s = number.ToString();
            int firstAndLast = int.Parse(s[0].ToString() + s[s.Length - 1].ToString());
            return number % firstAndLast == 0;
        }
    }
}
