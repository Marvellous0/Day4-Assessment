using System;

namespace Day4Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string: ");
            string firstInput = Console.ReadLine();
            firstInput = firstInput.ToLower();

            Console.WriteLine("Enter the second string: ");
            string secondInput = Console.ReadLine();
            secondInput = secondInput.ToLower();

            int index = 0;
            string prefix = " ";
            string lowestString;

            if (firstInput.Length < secondInput.Length)
            {
                lowestString = firstInput;
            }

            else
            {
                lowestString = secondInput;
            }

            for (int i = 0; i < lowestString.Length; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    prefix += firstInput[i];
                    index += i;
                }

                else
                {
                    //Console.WriteLine(firstInput + " and " + secondInput + " have no commmon prefix");
                    break;
                }
            }
            Console.WriteLine(prefix);
        }
    }
}
