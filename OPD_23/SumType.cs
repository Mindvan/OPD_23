using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    // В порядке возрастания (убывания) сумм элементов строк матрицы
    public class SumType : Type
    {
        public SumType(bool val) : base(val) {}
        public override bool IsCorrect(int[] a, int[] b)
        {
            int sumA = 0;
            int sumB = 0;

            foreach(int i in a)
            {
                sumA += i;
            }

            foreach(int i in b)
            {
                sumB += i;
            }

            return increase ? sumB < sumA : sumB > sumA;
        }
    }
}
