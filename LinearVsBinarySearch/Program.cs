using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearVsBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var ah = new ArrayHandler();
            var sortedArray = ah.GenerateSortedArray();
            var unsortedArray = ah.ShuffleArray(ah.GenerateSortedArray());
        }
    }
}
