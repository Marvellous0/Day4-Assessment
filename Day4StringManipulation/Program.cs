using System;

namespace Day4StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp;

            Console.WriteLine("Enter string: ");
            string word = Console.ReadLine();

            word = word.ToLower();
            char[] charstr = word.ToCharArray();

            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(charstr);
        }

    }
}
