using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    class LinearSearch
    {
        public SearchResult Search(int[] array, int searchTerm)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < array.Length; i++)
            {
                if (searchTerm == array[i])
                {
                    sw.Stop();
                    return new SearchResult(true, sw);
                }
            }
            sw.Stop();
            return new SearchResult(false, sw);
        }
    }
}
