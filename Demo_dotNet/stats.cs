using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_dotNet
{
    internal class stats
    {
        public static double findMean(int[] a, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += a[i];

            return (double)sum / (double)n;
        }
        // Function for
        // calculating median
        public static double findMedian(int[] a, int n)
        {
            // First we sort
            // the array
            Array.Sort(a);

            // check for
            // even case
            if (n % 2 != 0)
                return (double)a[n / 2];

            return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;
        }
        public static double findMode(int[] a,int n)
        {
            int maxValue=0, maxCount=0;

            for (int i = 0; i <n; ++i)
            {
                int count = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (a[j] == a[i]) 
                        ++count;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = a[i];
                }
            }

            return maxValue;
        }
    }
}
