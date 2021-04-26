using System;

namespace Day4Class
{
    public class Investment
    {
        public double _noOfYears;
        public double _interest;
        public double _principal;
        

        public Investment(double interest, double principal, double noOfYears)
        {
            _interest = interest;
            _principal = principal;
            _noOfYears = noOfYears;
        } 


        public double Value(double interest, double prinipal, double noOfYears)
        {
            double Interest = (1 / 10) * 100;

            double interestRate = _principal * (1 + Interest) * _noOfYears;

            return interestRate;
        }
    }
}