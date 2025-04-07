using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser
{
    interface ISortingAlgorithms
    {
        List<List<SetValue>> Sort(int[] array, int ArrayLength);
    }
}
