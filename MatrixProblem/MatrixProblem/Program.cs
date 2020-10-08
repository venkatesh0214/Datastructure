using System;

namespace MatrixProblem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Matrix Spiral Display!");

            int[,] mat = new int[,]
                   {
                    { 1, 2, 3, 4},
                    { 5, 6, 7, 9},
                    { 9,10,11,12},
                    {13,14,15,16}               
                   };

           

            spiralDisplay(mat, 0, mat.GetLength(0)-1, mat.GetLength(1) - 1, 0);

        }

        public static void spiralDisplay(int[,] mat,int top,int bottom,int right,int left)
        {
            if (left > right)
                return;

            //Print top
            for (int i = left; i <= right; i++)
            {
                Console.Write(mat[top,i] + " ");
            }
            top++;

            if (top > bottom)
            {
                return;
            }

            //Print right
            for (int i = top; i <= bottom; i++)
            {
                Console.Write(mat[i, bottom] + " ");
            }
            bottom--;

            if (left > right)
            {
                return;
            }
            //Print bottom
            for (int i = right-1 ; i>= left; i--)
            {
                Console.Write(mat[right, i] + " ");
            }
            right--;

            

            if (top > bottom)
            {
                return;
            }

            //Print left
            for (int i = bottom; i >= top; i--)
            {
                Console.Write(mat[i,left] + " ");
            }
            left++;

            spiralDisplay(mat, top, bottom, right, left);
        }
    }
}
