using System;

namespace SQRTBinarySrch
{
    class MainClass
    {
        public static void Main()
        {
            Console.WriteLine("Hello World");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("SQRT of {0} = {1}", n, sqtBinarySearch(n));
        }

        public static double sqtBinarySearch(int num)
        {
            double start = 0.0;
            double end = num;
            double sqrt = 0.0;
            double epsil = 0.000001;
            //Console.WriteLine(Double.Epsilon);
            int i = 0;

            while (start <= end)
            {
                double mid = ((start + end) / 2);

                sqrt = mid;
                Console.WriteLine("sqrt = {0}   mid*mid {1} Math.Abs(mid * mid -num) {2}   counter{3}", sqrt, mid * mid, ((mid * mid) - num), i++);
                if (Math.Abs((mid * mid) - num) <= epsil)
                {
                    break;
                }
                else if (mid * mid < num)
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }
            return sqrt;
        }
    }
}
