using System;
using System.ComponentModel;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SmallerChunks chunks = new SmallerChunks();

            var res = chunks.MakeSmallerChunks(15, 15);
            res = chunks.MakeSmallerChunks(15, 45);

            res = chunks.MakeSmallerChunks(15, 50);
            
            res = chunks.MakeSmallerChunks(15, 7);
            res = chunks.MakeSmallerChunks(15, 0);
        }
    }
}