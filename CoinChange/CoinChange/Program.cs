using System;

namespace CoinChange
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            int[] arr = {2,4,6,10 };
            Console.WriteLine(arr.Length);

            Console.WriteLine("Arr[4]s");

            for (int i = 0; i < 10; i++)
            {
                if (i > arr.Length - 1)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[i] = i;
                }

                Console.Write(arr[i] + " ");
            }


            Console.ReadKey();
        }
    }
}
