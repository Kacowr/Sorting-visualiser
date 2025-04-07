using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_visualiser
{
    static class ArrayGenerator
    {
        private const int generatorMultiplier = 10;
        public static int[] GenerateArray(int arraySize)
        {
            int[] array = new int [arraySize];
            for(int i=0;i<arraySize;i++)
            {
                array[i] = i+1;
            }
            Random random = new Random();
            for(int i=0;i<arraySize*generatorMultiplier;i++)
            {
                int firstIndex = random.Next(0, arraySize);
                int secondIndex = random.Next(0, arraySize);
                int temp = array[secondIndex];
                array[secondIndex] = array[firstIndex];
                array[firstIndex] = temp;
            }
            return array;
        }
    }
}
