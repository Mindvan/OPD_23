using System;
using System.Collections.Generic;
using System.Text;

namespace OPD_23
{
    /* Создайте класс, который позволяет сортировать пузырьком матрицу 
     * целых чисел теrray), чтобы упорядочить строки матрицы */

    public class BubbleSort : IAlgorythm
    {
        public void SortMatrix(ref int[][] arr, TypeSort sort)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                for (int k = 0; k <= arr.Length - 2; k++)
                {
                    int[] temp;
                    {
                       if (sort(arr[k], arr[k+1])) 
                       {
                            temp = arr[k];
                            arr[k] = arr[k+1];
                            arr[k+1] = temp;
                       }
                    }
                }
            }
        }
    }
}
