using System;
using System.Collections.Generic;

namespace FibonaciiDynamic
{
    class MainClass
    {
        public static int count = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine( "Output :  " +fibonacci(17));
            Console.WriteLine(count);
            count = 0;
            Console.WriteLine("Output :  " + fibonacciDynamic(17));
            Console.WriteLine(count);
        }

        //N th Fibonacci number
        public static int fibonacci(int n)
        {

            count = count + 1;
            //Console.WriteLine(n);
            int fib = 0;
            if (n <= 2)
                return 1;

            fib = fibonacci(n - 1) + fibonacci(n - 2);
            //Console.WriteLine(n + "  -  " + fib);

            return fib;

        }

        public static int fibonacciDynamic(int n)
        {
            Dictionary<int, int> Memo = new Dictionary<int, int>();
            if (Memo.ContainsKey(n))
                return (Memo[n]);

            count = count + 1;
            //Console.WriteLine(n);
            int fib = 0;
            if (n <= 2)
                return 1;

            fib = fibonacci(n - 1) + fibonacci(n - 2);
            Memo.Add(n, fib);
            //Console.WriteLine(n + "  -  " + fib);

            return fib;

        }
    }
}
