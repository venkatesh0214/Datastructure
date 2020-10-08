using System;

namespace CombinationProblem
{
    class MainClass
    {
        /*public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] arr = { 1, 2, 3, 4, 5 };
            int r = 3;
            int n = arr.Length;
            int[] data = new int[r];

            //CombinationProblem(arr,data,0,n-1,0,r);

            char[] arr1 = { '1', '2', '3', '4' };
            int r1 = 3;
            int n1 = arr.Length;
            char[] data1 = new char[arr.Length-1];

            CombinationProblemChar(arr1,data1,0,arr1.Length);
            Console.ReadKey();
        }*/

        public static void CombinationProblem(int[] arr, int[] data, int start,int end, int index, int r)
        {
            
            if(index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j]+" ");
                Console.WriteLine("");
                return;
            }
            for (int i=start; i <= end && end - i +1 >= r-index; i++)
            {
                data[index] = arr[i];
                CombinationProblem(arr, data, i + 1, end, index + 1, r);
            }
        }


        public static void CombinationProblemChar(char[] arr, char[] data, int start, int end)
        {
            
            if (start == end)
            {
                for (int j = 0; j < arr.Length; j++)
                    Console.Write(arr[j] + " ");
                Console.WriteLine("");
                return;
            }

            for (int i = start; i < end; i++)
            {
                swap(arr,start,i);
                CombinationProblemChar(arr, data, start+ 1, end);
                swap(arr, start, i);
            }
        }

        public static void swap(char[] a, int i,int j)
        {
            char temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
