using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.PairsSums
{
    class FindPairsSums
    {
        public static List<int[]> Find(int[] array, int sum)
        {
            Array.Sort(array);
            int first = 0;
            int last = array.Length - 1;
            List<int[]> result = new List<int[]>();
            while (first < last)
            {
                int s = array[first] + array[last];
                if (s == sum)
                {
                    result.Add(new int[] { array[first], array[last] });
                    //Console.WriteLine(array[first] + " + " + array[last] + " = " + sum);
                    first++;
                    last--;
                }
                else
                {
                    if (s < sum) first++;
                    else last--;
                }
            }
            return result;
        }
    }
}
