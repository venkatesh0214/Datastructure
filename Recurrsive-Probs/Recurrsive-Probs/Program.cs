using System;
using System.Collections.Generic;

namespace RecurrsiveProbs
{
    class MainClass
    {
        public static List<string> strList= new List<string>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = "kannan";
            int i = 0;
            int j = s.Length;
            Recurrsive(s,i,j);
            print();
        }


        public static void Recurrsive(string s,int i,int j)
        {
            if (i > j)
                return;

            Console.WriteLine(i + " - "+ j);

            strList.Add(s.Substring(i,j));
            j--;

            for (int a = 0; a < j; a++)
            {
                Recurrsive(s, i, j);
                i++;
            }
                //Console.WriteLine(i);
                 
        }

        public static void print()
        { 
            foreach(string s in strList)
            {
                Console.WriteLine(s);
            }
        }

    }
}
