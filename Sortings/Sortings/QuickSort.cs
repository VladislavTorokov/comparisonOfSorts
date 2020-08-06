using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings.Sortings
{
    public class QuickSort:BaseSort
    {
        //метод возвращающий индекс опорного элемента
        int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //быстрая сортировка
        int[] GetQuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            GetQuickSort(array, minIndex, pivotIndex - 1);
            GetQuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        public int[] GetQuickSort(int[] array)
        {
            return GetQuickSort(array, 0, array.Length - 1);
        }
    }
}
