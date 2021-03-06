﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Comparing to arrays :should return 1,0,-1
    /// </summary>
    public interface IComparor<in T> 
    {
         int Compare(T[] a,T[] b);
    }
    
    public static class MatrixFunc
    {
        /// <summary>
        /// "Bubble" sorting of matrix strings with rule getting from first ICompare-type param
        /// If matrix strings is null it get first places
        /// </summary>
        /// <param name="rule">The type of object must implement ICompare interface</param>
        /// <param name="matrix"></param>
        public static void BubbleSort(IComparor<int> rule, int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length - i - 1; j++)
                {
                    if (matrix[j] == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (matrix[j + 1] == null || rule.Compare(matrix[j], matrix[j + 1]) == 1)
                        {
                            Swap(ref matrix[j], ref matrix[j + 1]);
                        }
                        else continue;
                    }
                }

        }

        }

        private static void Swap(ref int[] a,ref int[] b)
        {
            var tmp = a;
            a = b;
            b = tmp;

        }
    }
}
