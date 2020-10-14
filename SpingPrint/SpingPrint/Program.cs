using System;

namespace SpingPrint
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Spring Print!");
            printFun(4);
        }

        public static void printFun(int n)
        {
            for (int i = 1; i <= n * n; i++)
            {
                Console.Write(i + " ");

                if (i % n == 0)
                {
                    Console.WriteLine("");
                }
            }
        }


        public static void print1(int n)
        {
            Console.WriteLine("Print1");
            int[,] a = new int[100,100];

            int i = 1, p = 1,temp=0;

            for (i = 1; i <= n; i++)
            for (int j = 1; j <= n; j++)
            {

                a[i, j] = p++;

            }

            for (int l = 1; l <= n; l++)
            {
                for (int k = 1; k <= n; k++)
                {
                    temp = a[l, k];
                    a[l,k] = a[k,l];
                    a[k, l] = temp;
                    Console.Write(a[l, k] + " ");

                }

                Console.WriteLine("");
            }

        }
    }
}
