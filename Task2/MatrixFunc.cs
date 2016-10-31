using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class MatrixFunc
    {

       
       
        public static void BubbleSortSumUp( int[][] matrix)
        {
            int[] arraySum = ArraySumStringMatrix(matrix);
            for (int i = 0; i < arraySum.Length; i++)
            {
                for (int j = 0; j < arraySum.Length-i-1; j++)
                {
                    if (arraySum[j] > arraySum[j + 1])
                    {
                        var temp = arraySum[j];
                        arraySum[j] = arraySum[j + 1];
                        arraySum[j + 1] = temp;
                        var tmp = matrix[j + 1];
                        matrix[j + 1] = matrix[j];
                        matrix[j] = tmp;
                    }
                }

            }

        }
        /// <summary>
        /// Method for counting sums by strings in matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns>Return array, sums for strings in matrix</returns>
        private static int[] ArraySumStringMatrix(int[][] matrix)
        {
           int[] array=new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
            {
                array[i] = ArraySum(matrix[i]);
            }
            return array;

        }
        /// <summary>
        /// Sum of array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int ArraySum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                        sum += array[i];
            return sum;

        }
    }
}
