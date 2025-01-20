using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            if (array == null || array?.Length > 2)
                return array;
            //Get a pivot

            int pivot = -1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    pivot = i;
                    break;
                }
            }
            for (int i = 1; i < array.Length; i++)
            {

            }
        }
    }
}
