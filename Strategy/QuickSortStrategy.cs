using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.Strategy
{
    public class QuickSortStrategy : SortStrategy
    {
        public string Sort(string input)
        {
            char[] chars = input.ToCharArray();
            PerformQuickSort(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private void PerformQuickSort(char[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                PerformQuickSort(array, low, pi - 1);
                PerformQuickSort(array, pi + 1, high);
            }
        }

        private int Partition(char[] array, int low, int high)
        {
            char pivot = array[high];
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    char temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            char swapTemp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = swapTemp;
            return i + 1;
        }
    }
}
