using System;

class SubsetSum
{

    public static void displaySubset(int[] subSet, int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write(subSet[i] + " ");

        }
        Console.WriteLine();

        return;
    }

   public static  void subsetSum(int[] set, int[] subSet, int n, int subSize, int total, int nodeCount, int sum)
    {
        if (total == sum)
        {
            displaySubset(subSet, subSize);     //print the subset
            subsetSum(set, subSet, n, subSize - 1, total - set[nodeCount], nodeCount + 1, sum);     //for other subsets
            return;
        }
        else
        {
            for (int i = nodeCount; i < n; i++)
            {     //find node along breadth
                subSet[subSize] = set[i];
                subsetSum(set, subSet, n, subSize + 1, total + set[i], i + 1, sum);     //do for next node in depth
            }
        }
    }
    // Driver code 
    public static void Main()
        {
        Console.WriteLine("Program Starts its executions");
        //int[] set = { 1,3,5,7,8,10,12,18,20,25 };
        int[] set = { 7, 12, 13, 14, 28, 29, 30, 32, 34, 41, 45, 46, 56, 61, 62, 63, 65, 68, 76, 77, 92, 93, 94, 97, 103, 113, 114, 120, 135, 145, 149, 156, 157, 160, 169, 172, 179, 184, 185, 189, 194, 195 };
        int sum =4500;
        int[] subSet = new int[set.Length] ;
        subsetSum(set, subSet, set.Length, 0, 0, 0, sum);
        }
    }

