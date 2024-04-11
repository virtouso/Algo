using System;

namespace Algorithms.Problems
{
    public class Traversal
    {
        
      public  class Node
        {
            public int data;
        public Node(int data)
        {
            this.data = data;
        }
        public Node left;
        public Node right;
    }
        
        public  void PreOrderTraversal(Node root)
        {
            if (root == null) return;

            Console.WriteLine("PreOrderTraversal at node {0}", root.data); // process the root
            PreOrderTraversal(root.left);// process the left
            PreOrderTraversal(root.right);// process the right
        }

        public  void InOrderTraversal(Node root)
        {
            if (root == null) return;

            InOrderTraversal(root.left);// process the left
            Console.WriteLine("InOrderTraversal at node {0}", root.data); // process the root
            InOrderTraversal(root.right);// process the right
        }

        public  void PostOrderTraversal(Node root)
        {
            if (root == null) return;

            PostOrderTraversal(root.left);// process the left            
            PostOrderTraversal(root.right);// process the right
            Console.WriteLine("PostOrderTraversal at node {0}", root.data); // process the root
        }
    }
}