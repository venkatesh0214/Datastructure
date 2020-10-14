using System;
using System.Linq;
namespace Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Provide your Input");
            string i1= Console.ReadLine();
            string i2 = Console.ReadLine();

            int[] in1 = i1.Split(',').Select(n => int.Parse(n)).ToArray();
            int[] a=i2.Split(',').Select(n => int.Parse(n)).ToArray();


            ArrayLeftRotation(in1[1], a);
        }


        public static void ArrayLeftRotation(int i1, int[] i2)
        {


            int temp, k = 1;

            while (i1 >= k)
            {
                //Console.WriteLine(i1);

                for (int i = 0; i < i2.Length - 1; i++)
                {
                    
                    temp = i2[i];
                    i2[i] = i2[i + 1];
                    i2[i + 1] = temp;

                }

                displayArray(i2);
                k++;
            }
        }


        public static void displayArray(int[] a)
        {
            for (int i = 0; i < a.Length;i++)
                Console.Write( a[i] + "   " );
            Console.WriteLine();
        }
    }
}
