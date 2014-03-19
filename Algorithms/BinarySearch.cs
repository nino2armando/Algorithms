using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public static int BSearch(int index, int[] arraryToSearch)
        {
            int lowIndex = 0;
            int highIndex = arraryToSearch.Length;

            if (index < arraryToSearch[lowIndex])
                return -1;
            if (index > arraryToSearch[highIndex - 1])
                return -1;

            while (lowIndex <= highIndex )
            {
                int mid = (lowIndex + highIndex )/2;

                if (index > arraryToSearch[mid])
                {
                    lowIndex = mid + 1;
                }
                else if(index < arraryToSearch[mid])
                {
                    highIndex = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
