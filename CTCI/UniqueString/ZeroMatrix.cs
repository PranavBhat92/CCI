using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndArrays
{
    class ZeroMatrix
    {
        //static void Main(string[] args)
        //{
        //    //MyVersion();
        //    CTCIVersion();
        //}

        public static void CTCIVersion()
        {
            var matrix = new int[,] {
                { 1,2,3,4 },
                { 5,6,7,8 },
                { 9,10,0,12 },
                { 13,14,15,16 }
                         };

            var rowArray = new bool[matrix.GetLength(0)];
            var columnArray = new bool[matrix.GetLength(1)];


            Console.WriteLine("Source Matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] == 0)
                    {
                        rowArray[i] = true;
                        columnArray[j] = true;
                    }
                }
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (rowArray[i])
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }


            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (columnArray[j])
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = 0;
                    }
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
