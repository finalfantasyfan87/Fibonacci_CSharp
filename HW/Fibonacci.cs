using System;

namespace Homework1_jhaywoo2
{
    public class Fibonacci
    {
        //fibonacci sequence includes summing every two numbers
        //f(n) = f(n - 1) + f(n - 2);
        public int GetFibonacciSeries(int i)
        {
            switch (i)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return GetFibonacciSeries(i - 1) + GetFibonacciSeries(i - 2);
            }
        }
    }
}