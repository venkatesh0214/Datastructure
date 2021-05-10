using System;

namespace WeightedJobScheduling
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //No two jobs overlab eachother
            //Input will have 3 element 1.Starts time, 2.End Time, 3.Weight
            //Sort based on start time
            Console.WriteLine(" WeightedJobScheduling !");

            int[] pickups = { 1, 5, 6, 8, 9 };
            int[] drops = {  5, 8, 9, 15, 16 };
            int[] weights = { 4, 3, 3, 7,  7};

            JobScheduling(pickups, drops, weights);
        }

        public static void JobScheduling(int[] p, int[] d,int[] w)
        {

        }
    }
}
