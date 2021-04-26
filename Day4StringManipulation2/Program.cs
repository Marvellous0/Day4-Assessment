using System;

namespace Day4StringManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string s1: ");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter string s2: ");
            string s2 = Console.ReadLine();

            if (s1.IndexOf(s2) != -1)
            {
                Console.WriteLine($"{s2} is a substring of {s1}");
            }

            else
            {
                Console.WriteLine($"{s2} is not a substring of {s1}");
            }
            
        }
    }
}
