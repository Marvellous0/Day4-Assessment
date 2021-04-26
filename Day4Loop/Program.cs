using System;

namespace Day4Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int i, vowel, cons;

            Console.WriteLine("Input the first string : ");
            word = Console.ReadLine();
            word = word.ToLower();

            vowel = 0;
            cons = 0;

            for (i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    vowel++;
                }

                else 
                {
                    cons++;
                }
            }
            Console.WriteLine("The total number of vowel in the string is :{0}", vowel);
            Console.WriteLine("The total number of consonant in the string is: {0}", cons);
        
        }
    }
}
