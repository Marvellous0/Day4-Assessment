using System;

namespace Day4Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Even numbers from 0 to 100 are: \n");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }
            Console.Write($"Sum of All Even Numbers is: {sum}");
        }
    }
}
