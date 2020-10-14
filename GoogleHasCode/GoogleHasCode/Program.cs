using System;

namespace GoogleHasCode
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1,2, 5, 7, 10, 16, 17, 19, 21, 25, 26, 28 };
            int total = 68;

            // findSum(arr,arr.Length,total);
           bool b= isSubsetSum(arr, arr.Length, total);
            Console.WriteLine(b.ToString());
            Console.ReadLine();
        }

        public static void findSum(int[] arr,int n,int total)
        {
            int subTotal =0,a = 0;
            Console.WriteLine("in functions");

            for (int i = n-1; i >= 0; i--)
            {
                subTotal += arr[i];

                a = total - arr[i];

                Console.WriteLine("a => " + a);

                if (a < 0)
                {
                    a += arr[i];

                }
                
            }

           // Console.WriteLine("a => " + a)
        }

        static bool isSubsetSum(int[] set, int n, int sum)
        {
            // Base Cases 
            if (sum == 0)
                return true;
            if (n == 0 && sum != 0)
                return false;

            // If last element is greater than sum,  
            // then ignore it 
            if (set[n - 1] > sum)
                return isSubsetSum(set, n - 1, sum);

            /* else, check if sum can be obtained  
            by any of the following 
            (a) including the last element 
            (b) excluding the last element */
            return isSubsetSum(set, n - 1, sum) ||
                           isSubsetSum(set, n - 1, sum - set[n - 1]);
        }

    }
}
