using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.PairsSums
{
    class TestFindPairSums
    {
        public TestFindPairSums(int arrayLength, int randDepth, int nSum)
        {
            List<int[]> pairs = FindPairsSums.Find(RandomArray(arrayLength, randDepth), nSum);
            if(pairs.Count==0)
                Console.WriteLine("No pairs found.");
            else
            foreach (int[] a in pairs)
               Console.WriteLine(a[0]+" + "+a[1]+" = " +nSum);            
        }
        private int[] RandomArray(int arrayLength, int randDepth)
        {
            Random rand = new Random();
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(0, randDepth);
            }
            return array;
        }
    }
}
