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

    static long[] dp;

    // Complete the fibonacciModified function below.

    static long fibonacciModified(long n)
    {

        //Console.WriteLine(n);

        if (n <= 0)
            return 0;

        if (n == 1)
            return 1;

        if (dp[n] != 0)
            return dp[n];

        dp[n] = fibonacciModified(n - 2) +
        (fibonacciModified(n - 1) * fibonacciModified(n-1));
        return dp[n];
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] t1T2n = Console.ReadLine().Split(' ');

        int t1 = Convert.ToInt32(t1T2n[0]);

        int t2 = Convert.ToInt32(t1T2n[1]);

        int n = Convert.ToInt32(t1T2n[2]);

        dp = new long[n + 2];

        for (int i = 0; i <= n + 1; i++)
            dp[i] = 0;

        dp[1] = t1;
        dp[2] = t2;

        long result = fibonacciModified(n);

        for (int i = 0; i <= n + 1; i++)
            Console.WriteLine(dp[i]);

        //textWriter.WriteLine(result);

        //textWriter.Flush();
        //textWriter.Close();
    }
}
