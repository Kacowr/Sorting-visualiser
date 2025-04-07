using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser.SortingAlgorithms.Implementations
{
    class InsertionSort : ISortingAlgorithms
    {
        public List<List<SetValue>> Sort(int[] array, int arrayLength)
        {
            List<List<SetValue>> valuesOrder = new List<List<SetValue>>();
            for (int i = 0; i < arrayLength - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        List<SetValue> order = new List<SetValue>();
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        order.Add(new SetValue(j - 1, array[j]));
                        array[j] = temp;
                        order.Add(new SetValue(j, temp));
                        
                        valuesOrder.Add(order);
                    }
                }
            }
            return valuesOrder;
        }
    }
}
