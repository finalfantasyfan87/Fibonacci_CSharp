using System;

namespace Homework1_jhaywoo2
{
    static class Homework1
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
           
            int series = 15;
        
            for (int i = 1; i < series; i++)
            {
                Console.WriteLine("Fib {0} = {1}", i, fibonacci.GetFibonacciSeries(i));
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}