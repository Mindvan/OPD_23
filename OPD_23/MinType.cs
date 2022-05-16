using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    // В порядке возрастания (убывания) минимального элемента в строке матрицы;
    public class MinType : Type
    {
        public MinType(bool val) : base(val) { }
        public override bool IsCorrect(int[] a, int[] b)
        {
            int minA = a[0];
            int minB = b[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < minA)
                {
                    minA = a[i];
                }
                if (b[i] < minB)
                {
                    minB = b[i];
                }
            }
            return increase ? minB < minA : minB > minA;
        }
    }
}
