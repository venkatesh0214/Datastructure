using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{
    static int sum = 0;

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr)
    {

        int l = arr.Length;
        int i = 0;
        maxSubsetSumm(arr,l,i);
        return 0;

    }

    static int maxSubsetSumm(int[] arr, int l, int i)
    { 
        if (i >= l)
            return 0;

        //int sum += arr[i];
        Console.WriteLine(arr[i]+" " + l + " " + i);

        sum += maxSubsetSumm(arr, l, i );
        return 0;
    }

    static void Main(string[] args)
    {
      //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = maxSubsetSum(arr);

        //textWriter.WriteLine(res);
        //textWriter.Flush();
       // textWriter.Close();
    }
}
