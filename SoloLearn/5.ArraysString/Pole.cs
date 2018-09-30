using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.ArraysString
{
    class Pole
    {        
        static void Main(string[] args)
        {
            int[] myArray = new int[5];
            int[,] x = new int[3,4]; //2dimenzionální pole 3x4
            string[] names = { "John", "Mary", "Jessica" };

            int[] a = new int[10];
            foreach (int k in a)
            {
                Console.WriteLine(k);
            }

            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } };
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jaggedArr = new int[3][]; //vícenásobné pole
            jaggedArr = new int[][]
            {
                new int[ ]{1,8,2,7,9},
                new int[ ]{2,4,6},
                new int[ ]{33,42}
            };

            int[] arr = { 2, 4, 7, 1};
            Console.WriteLine(arr.Length); //počet prvků
            //Outputs 3

            Console.WriteLine(arr.Rank); //počet dimenzí
            //Outputs 1

            Console.WriteLine(arr.Max()); //největší prvek
            //Outputs 7

            Console.WriteLine(arr.Min()); //nejmenší prvek
            //Outputs 1

            Console.WriteLine(arr.Sum()); //součet prvků
            //Outputs 14
        }
    }
}
