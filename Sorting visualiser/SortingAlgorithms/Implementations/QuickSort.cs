using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser.SortingAlgorithms.Implementations
{
    class QuickSort : ISortingAlgorithms
    {
        private static List<List<SetValue>> valuesOrder = new List<List<SetValue>>();
        public List<List<SetValue>> Sort(int[] array, int arrayLength)
        {
            valuesOrder.Clear();
            SortImplementation(array, 0, array.Length - 1);
            return valuesOrder;
        }

        private static void SortImplementation(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(array, left, right);
                if (pivot > 1)
                {
                    SortImplementation(array, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortImplementation(array, pivot + 1, right);
                }
            }
        }
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];

            while (true)
            {
                while (array[left] < pivot)
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    List<SetValue> order = new List<SetValue>();
                    int temp = array[left];
                    array[left] = array[right];
                    order.Add(new SetValue(left, array[right]));
                    array[right] = temp;
                    order.Add(new SetValue(right, temp));
                    valuesOrder.Add(order);
                }
                else
                {
                    return right;
                }
            }
        }
    }
}
