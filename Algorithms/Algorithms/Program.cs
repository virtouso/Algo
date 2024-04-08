using System;
using System.ComponentModel;
using Algorithms.Problems;
using NUnit.Framework;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            BreadthFirstSearch  bfs = new BreadthFirstSearch();
            bfs.Run();
        }
    }
}