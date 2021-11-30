// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo_dotNet // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a stats world!");
            int[] a = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int n = a.Length;
            // Function call
            Console.WriteLine("Mean = " + stats.findMean(a, n) + "\n");
            Console.WriteLine("Median = " + stats.findMedian(a, n) + "\n");
            Console.WriteLine("Mode = " + stats.findMode(a, n) + "\n");

        }
    }
}
