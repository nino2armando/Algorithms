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
            var array = new int[] { 1, 4, 3, 7, 44, 34, 6, 11, 36, 43 };
            var sorted = BubbleSort.Sort(array);

            foreach(int item in sorted)
            {
                Console.Write(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
