using System;

namespace Day4Class
{
    public class Investment
    {
        public double _noOfYears;
        public double _interest;
        public double _principal;
        

        public Investment(double principal, double noOfYears, double interest)
        {
            //_interest = interest;
            _principal = principal;
            _noOfYears = noOfYears;
            _interest = interest;
        } 

        public double Value()
        {

            double value = 0; 
            value = _principal * (1 + _interest) * _noOfYears;

            Console.WriteLine($"Interest rate is {value}");
            return value;

        }
    }
}