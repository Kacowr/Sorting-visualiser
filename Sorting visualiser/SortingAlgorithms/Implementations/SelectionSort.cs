using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser.SortingAlgorithms.Implementations
{
    class SelectionSort : ISortingAlgorithms
    {
        public List<List<SetValue>> Sort(int[] array, int arrayLength)
        {
            List<List<SetValue>> valuesOrder = new List<List<SetValue>>();
            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestValue = i;
                for (int j = i + 1; j < arrayLength; j++)
                {
                    if (array[j] < array[smallestValue])
                    {
                        smallestValue = j;
                    }
                }
                List<SetValue> order = new List<SetValue>();
                var temp = array[smallestValue];
                array[smallestValue] = array[i];
                order.Add(new SetValue(smallestValue, array[i]));
                array[i] = temp;
                order.Add(new SetValue(i, temp));
                valuesOrder.Add(order);
            }
            return valuesOrder;
        }
    }
}
