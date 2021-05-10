using System;
namespace CombinationProblem
{
    public class DynamicPrograming
    {
        /*public static void Main(string[] args)
        {
            int f = 0;
            int n = 6;
            //Console.WriteLine(n+"th Fibanachi number : "+FebonnaciNthnumber( n, f));

            
        }*/

        public DynamicPrograming()
        {
            
        }

        //Recursivealogoritham
        public static int FebonnaciNthnumber(int n,int f)
        {
            if (n == 1 || n==0)
                return 1;
          
            f = FebonnaciNthnumber(n - 1,f) + FebonnaciNthnumber(n - 2,f);

            return f;
            
        }
    }
}
