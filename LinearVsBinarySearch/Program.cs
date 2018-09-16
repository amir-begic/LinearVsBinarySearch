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
            while (true)
            {
                Console.WriteLine("Search Key: ");
                var searchKey = Console.ReadLine();

                Console.WriteLine("Array Length: ");
                var size = Console.ReadLine();

                var ah = new ArrayHandler(Int32.Parse(size));
                var sortedArray = ah.GenerateSortedArray();
                var unsortedArray = ah.ShuffleArray(ah.GenerateSortedArray());
                var linearSearch = new LinearSearch();
                var binarySearch = new BinarySearch();

                Console.WriteLine("Searching for the given term in a sorted Arraylist with a Linear Search Algorithm.");
                Console.WriteLine(linearSearch.Search(sortedArray, Int32.Parse(searchKey)).ToString());

                Console.WriteLine("Searching for the given term in a shuffled Arraylist with a Linear Search Algorithm.");
                Console.WriteLine(linearSearch.Search(unsortedArray, Int32.Parse(searchKey)).ToString());

                Console.WriteLine("Searching for the given term in a sorted Arraylist with a Binary Search Algorithm.");
                Console.WriteLine(binarySearch.Search(sortedArray, Int32.Parse(searchKey)).ToString());

                Console.WriteLine("Searching for the given term in a shuffled Arraylist with a Binary Search Algorithm.");
                Console.WriteLine(binarySearch.Search(unsortedArray, Int32.Parse(searchKey)).ToString());

                Console.ReadKey();
            }
        }
    }
}
