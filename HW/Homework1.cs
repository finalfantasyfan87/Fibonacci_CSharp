using System;

namespace Homework1_jhaywoo2
{
    static class Homework1
    {
        static void Main(string[] args)
        {
            Fibonacci fibonacci = new Fibonacci();
           //requirements were to hard code a value
            //but I could prompt the user and read in values using Console.Readline then convert value to Int32
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
