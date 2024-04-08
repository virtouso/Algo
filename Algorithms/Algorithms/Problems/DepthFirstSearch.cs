using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Problems
{
    public class DepthFirstSearch
    {
        public class Node
        {
            public int Value { get; set; }
            public HashSet<Node> Neighbors { get; set; } = new HashSet<Node>();
        }


        public HashSet<Node> Dfs(Node start)
        {
            var visited = new HashSet<Node>();
            var stack = new Stack<Node>();
            var result = new HashSet<Node>();
            stack.Push(start);

            while (stack.Count>0)
            {
                var current = stack.Pop();
                if(!visited.Add(current))
                    continue;

                result.Add(current);
                var neighbours = current.Neighbors.Where(node => !visited.Contains(node));
                foreach(var neighbour in neighbours)// consider  neighbors.reverse
                {
                    stack.Push(neighbour);
                }
            }

            return result;
        }

        public void Run()
        {
            Node start = new Node{Value = 0};
            
            Node n1 = new Node{Value = 1};
            Node n2 = new Node{Value = 2};
            Node n3 = new Node{Value = 3};
            
            start.Neighbors.UnionWith(new []{n1,n2,n3});
            
            Node n4 = new Node{Value = 4};
            Node n5 = new Node{Value = 5};
            Node n6 = new Node{Value = 6};
            
            n2.Neighbors.UnionWith( new []{n4,n5,n6});
            
            var result = Dfs(start);

            StringBuilder showResult = new StringBuilder();

            foreach (var item in result)
            {
                showResult.Append(item.Value).Append(',').Append(' ');
            }
            
Console.WriteLine(showResult.ToString());
        }
        
    }
}