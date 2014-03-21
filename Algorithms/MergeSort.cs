namespace Algorithms
{
    public class MergeSort
    {
        public static int[] Sort(int[] array)
        {
            if (array.Length == 1)
                return array;

            int mid = array.Length/2;

            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            // fill the left and right arrays
            for (int i = 0; i < mid; i ++)
            {
                left[i] = array[i];
            }

            for (int i = 0; i < array.Length - mid; i++)
            {
                right[i] = array[mid + i];
            }

            left = Sort(left);
            right = Sort(right);

            int leftPntr = 0;
            int righPntr = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (leftPntr < left.Length && left[leftPntr] <= right[righPntr])
                {
                    array[i] = left[leftPntr];
                    leftPntr++;
                }
                else
                {
                    array[i] = right[righPntr];
                    righPntr++;
                }

            }
            return array;
        }
    }
}
