using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RightChunkNumber num = new RightChunkNumber();
            Console.WriteLine(num.CalculateRightChunkNumber(4,75,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,74,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,100,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,50,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,10,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,0,100));
            Console.WriteLine(num.CalculateRightChunkNumber(4,1,100));

            
        }
    }
}