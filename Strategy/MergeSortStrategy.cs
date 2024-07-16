using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skillTestVillon.Strategy
{
    public class MergeSortStrategy : SortStrategy
    {
        public string Sort(string input)
        {
            char[] chars = input.ToCharArray();
            PerformMergeSort(chars, 0, chars.Length - 1);
            return new string(chars);
        }

        private void PerformMergeSort(char[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                PerformMergeSort(array, left, middle);
                PerformMergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private void Merge(char[] array, int left, int middle, int right)
        {
            int leftArrayLength = middle - left + 1;
            int rightArrayLength = right - middle;

            char[] leftArray = new char[leftArrayLength];
            char[] rightArray = new char[rightArrayLength];

            for (int i = 0; i < leftArrayLength; ++i)
                leftArray[i] = array[left + i];

            for (int j = 0; j < rightArrayLength; ++j)
                rightArray[j] = array[middle + 1 + j];

            int leftIndex = 0, rightIndex = 0;
            int mergedIndex = left;

            while (leftIndex < leftArrayLength && rightIndex < rightArrayLength)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    array[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < leftArrayLength)
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < rightArrayLength)
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }
}
