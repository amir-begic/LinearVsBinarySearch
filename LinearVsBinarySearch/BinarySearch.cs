using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    class BinarySearch
    {
        public SearchResult Search(int[] array, int searchTerm)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int min = 0;
            int N = array.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (searchTerm > array[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (array[mid] == searchTerm)
                {
                    sw.Stop();
                    return new SearchResult(true, sw);
                }

                //if (min > max)
                //   break;
            } while (min <= max);
            sw.Stop();
            return new SearchResult(false, sw);
        }
    }
}
