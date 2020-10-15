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
    static int[] dp;

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr)
    {

        int l = arr.Length;
        int i = 0;
        Console.WriteLine("MaxSum => "+maxSubsetSumm(arr,l,i));
        return 0;

    }

    static int maxSubsetSumm(int[] arr, int l, int start)
    { 
        if (start >= l)
            return 0;

        if (dp[start]!=0)
                return dp[start];

        dp[start] = Math.Max(arr[start]+maxSubsetSumm(arr,l,start+2),maxSubsetSumm(arr,l,start+1));


        return dp[start];
    }

    static void Main(string[] args)
    {
      //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;

        dp = new int[n];
        for (int i = 0; i < n; i++)
        {
            dp[i] = 0;
        }

        dp[n - 1] = arr[n - 1];
        int res = maxSubsetSum(arr);

        //textWriter.WriteLine(res);
        //textWriter.Flush();
       // textWriter.Close();
    }
}
