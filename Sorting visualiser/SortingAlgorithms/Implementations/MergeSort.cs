using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser.SortingAlgorithms.Implementations
{
    class MergeSort : ISortingAlgorithms
    {
        private static List<List<SetValue>> valuesOrder = new List<List<SetValue>>();
        public List<List<SetValue>> Sort(int[] array, int arrayLength)
        {
            valuesOrder.Clear();
            SortImplementation(array, 0, array.Length - 1);
            return valuesOrder;
        }
        private int[] SortImplementation(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                SortImplementation(array, left, middle);
                SortImplementation(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
        }
        private void MergeArray(int[] array, int left, int middle, int right)
        {
            var leftArrayLength = middle - left + 1;
            var rightArrayLength = right - middle;
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;
            for (i = 0; i < leftArrayLength; ++i)
                leftTempArray[i] = array[left + i];
            for (j = 0; j < rightArrayLength; ++j)
                rightTempArray[j] = array[middle + 1 + j];
            i = 0;
            j = 0;
            int k = left;
            while (i < leftArrayLength && j < rightArrayLength)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                {
                    List<SetValue> order = new List<SetValue> { new SetValue(k, leftTempArray[i]) };
                    array[k++] = leftTempArray[i++];
                    valuesOrder.Add(order);
                }
                else
                {
                    List<SetValue> order = new List<SetValue> { new SetValue(k, rightTempArray[j]) };
                    array[k++] = rightTempArray[j++];
                    valuesOrder.Add(order);
                }
            }
            while (i < leftArrayLength)
            {
                List<SetValue> order = new List<SetValue> { new SetValue(k, leftTempArray[i]) };
                array[k++] = leftTempArray[i++];
                valuesOrder.Add(order);
            }
            while (j < rightArrayLength)
            {
                List<SetValue> order = new List<SetValue> { new SetValue(k, rightTempArray[j]) };
                array[k++] = rightTempArray[j++];
                valuesOrder.Add(order);
            }
        }
    }
}
