using System;
using Algorithms.Problems;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            SearchInRotatedSortedArray search = new SearchInRotatedSortedArray();
            
            Console.WriteLine(search.Search(new []{4,5,6,7,0,1,2},0));
            Console.WriteLine(search.Search(new []{4,5,6,7,0,1,2},3));
            Console.WriteLine(search.Search(new []{1},0));
        }
    }
}