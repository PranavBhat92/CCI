using System;

namespace StringsAndArrays
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {
            //MyVersion();
            CTCIVersion();
        }

        public static void CTCIVersion()
        {
            var matrix = new int[,] {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,11,12 },
                { 13,14,15,16 } 
                         };

            if (matrix.Length == 0 || matrix.Length != matrix.GetLength(0) * matrix.GetLength(1))
            {
                Console.WriteLine("Matrix is not square matrix!");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Source Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            var n = matrix.GetLength(0);
            for (int layer = 0; layer < n/2; layer++)
            {
                int first = layer;
                int last = n - layer - 1;

                for (int i = first; i < last; i++)
                {
                    int offset = i - first;

                    int top = matrix[first,i];

                    matrix[first, i] = matrix[last - offset, first];
                    matrix[last - offset, first] = matrix[last, last - offset];
                    matrix[last, last - offset] = matrix[i, last];
                    matrix[i, last] = top;
                }
            }

            Console.WriteLine("Resultant Matrix:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadLine();

        }


    }
}
