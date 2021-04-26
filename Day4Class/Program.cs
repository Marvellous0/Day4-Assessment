using System;

namespace Day4Class
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Principal value: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of years: " );
            double noOfYears = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter interest rate: " );
            double interest = Convert.ToDouble(Console.ReadLine());

            Investment investment = new Investment(principal, noOfYears, interest);
            investment.Value();
        }
    }
}
