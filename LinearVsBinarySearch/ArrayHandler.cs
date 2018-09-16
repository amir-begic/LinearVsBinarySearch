using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    class ArrayHandler
    {
        private int[] ShuffledArray;
        private int ArraySize;

        public ArrayHandler(int arraySize)
        {
            ArraySize = arraySize;
        }

        public int[] GenerateSortedArray()
        {
            int[] sortedArray = new int[ArraySize];

            for (int i = 0; i < ArraySize; i++)
            {
                sortedArray[i] = i;
            }

            return sortedArray;
        }

        public int[] ShuffleArray(int[] sortedArray)
        {
            ShuffledArray = sortedArray;
            Random r = new Random();
            Shuffle(ShuffledArray, ShuffledArray.Length, r);
            
            return ShuffledArray;
        }

        private void Shuffle(int[] sortedArray, int length, Random r)
        {
            if (length == 0)
            {
                return;
            }
            
            int index = r.Next(0, length);
            
            int temp = sortedArray[length - 1];
            sortedArray[length - 1] = sortedArray[index];
            sortedArray[index] = temp;
            
            Shuffle(sortedArray, length - 1, r);
        }



    }
}
