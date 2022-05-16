using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    public delegate bool TypeSort(int[] a, int[] b);
    public delegate void Sort(ref int[][] arr, TypeSort asc);
    public class Matrix
    {
        public int[][] matrix = new int[][] { 
            new int[] { -14, -6, 18 }, 
            new int[] { -2, 3, -1 },
            new int[] { 0, 11, -7 },
            new int[] { 4, 5, 2 }, 
            new int[] { 10, 8, 3 } 
        };

        private Sort Alg { get; set; }
        private TypeSort AlgType { get; set; }

        public Matrix(IAlgorythm alg, Type type)
        {
            Alg = new Sort(alg.SortMatrix);
            AlgType = type.IsCorrect;
        }

        public Matrix(IAlgorythm alg)
        {
            Alg = new Sort(alg.SortMatrix);
        }

        public Matrix( Type type)
        {
            AlgType = type.IsCorrect;
        }

        public Matrix () {}

        public void setAlgorythm(IAlgorythm arg)
        {
            Alg = new Sort(arg.SortMatrix);
        }

        public void setType(Type arg)
        {
            AlgType=arg.IsCorrect;
        }

        public void SortMatrix()
        {
            if (Alg == null || AlgType == null)
            {
                return;
            }
            Alg(ref matrix, AlgType);
        }

        // вывод матрицы
        public void Show()
        {
            string[] str = new string[matrix.Length];
            for (int i =0; i < matrix.Length; i++)
            {
                str[i] = String.Join(" ", matrix[i]);
            }
            Console.WriteLine("[{0}]", String.Join(" | ", str));
        }
    }
   
}
