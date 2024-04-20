using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class CloneGraphProblem
    {
        public class Node {
            public int val;
            public List<Node> neighbors;

            public Node() {
                val = 0;
                neighbors = new List<Node>();
            }

            public Node(int _val) {
                val = _val;
                neighbors = new List<Node>();
            }

            public Node(int _val, List<Node> _neighbors) {
                val = _val;
                neighbors = _neighbors;
            }
        }
        
           private Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
        
            public Node CloneGraph(Node node) {
                if (node == null) return null;
        
                if (visited.ContainsKey(node)) {
                    return visited[node];
                }
        
                Node cloneNode = new Node(node.val);
                visited.Add(node, cloneNode);
        
                foreach (Node neighbor in node.neighbors) {
                    cloneNode.neighbors.Add(CloneGraph(neighbor));
                }
        
                return cloneNode;
            }
    }
}