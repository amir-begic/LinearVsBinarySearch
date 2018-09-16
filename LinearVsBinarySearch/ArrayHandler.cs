using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    class ArrayHandler
    {
        private int[] shuffledArray;
        public int[] GenerateSortedArray()
        {
            int[] sortedArray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                sortedArray[i] = i;
            }

            return sortedArray;
        }

        public int[] ShuffleArray(int[] sortedArray)
        {
            shuffledArray = sortedArray;
            Random r = new Random();
            Shuffle(shuffledArray, shuffledArray.Length, r);
            
            return shuffledArray;
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
