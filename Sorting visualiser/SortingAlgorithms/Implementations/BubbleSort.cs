using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser.SortingAlgorithms.Implementations
{
    class BubbleSort : ISortingAlgorithms
    {
        public List<List<SetValue>> Sort(int[] array, int arrayLength)
        {
            List<List<SetValue>> valuesOrder = new List<List<SetValue>>();
            for(int i=0;i<arrayLength;i++)
            {
                for(int j=i;j<arrayLength;j++)
                {
                    if (array[j] < array[i])
                    {
                        List<SetValue> order = new List<SetValue>();
                        int temp = array[j];
                        array[j] = array[i];
                        order.Add(new SetValue(j, array[i]));
                        array[i] = temp;
                        order.Add(new SetValue(i, temp));
                        valuesOrder.Add(order);
                    }
                }
            }
            return valuesOrder;
        }
    }
}
