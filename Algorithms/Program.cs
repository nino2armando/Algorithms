using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // bubble sort 
            var array = new int[] { 1, 4, 3, 7, 44, 34, 6, 11, 36, 43 };
            var sorted = BubbleSort.Sort(array);

            foreach(int item in sorted)
            {
                Console.Write(item.ToString());
            }

            // binary search

            var myArray = new int[] {1, 2, 4, 6, 10, 14, 15, 19, 20, 34, 36, 38, 40, 42};

            var value = BinarySearch.BSearch(10, myArray);
            
            Console.ReadKey();
        }
    }
}
