using System;
namespace Array
{
    public class MergeSortedArrays
    {
        public MergeSortedArrays()
        {
        }

        public static void mergeSortedArray(int[] a, int[] b)
        {

            Console.WriteLine("a Arry Length " + a.Length);
            Console.WriteLine("b Arry Length " + b.Length);

            int arryCombinedLength = a.Length + b.Length;
            int[] mergedArray = new int[arryCombinedLength];
            int ai=0, bi = 0;
            int i = 0;

            while (i < arryCombinedLength)
            {
                if (ai < a.Length && (a[ai] <= b[bi] || bi> b.Length))
                {
                    mergedArray[i] = a[ai];
                    ai++;
                }
                else
                { 
                    mergedArray[i] = b[bi];
                    bi++;
                }

                i++;
            }

            DisplayMergedArray(mergedArray);
        }

        private static void DisplayMergedArray(int[] arr)
        {
            Console.WriteLine("Merged Arry Length "+arr.Length);
            for(int i=0;i<arr.Length;i++)
                Console.Write(arr[i]+ "  ");
        }
    }
}
