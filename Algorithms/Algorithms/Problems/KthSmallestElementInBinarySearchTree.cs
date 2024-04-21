using System.Collections.Generic;
using System.Xml.Xsl;

namespace Algorithms.Problems
{
    public class KthSmallestElementInBinarySearchTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }


        public int KthSmallest(TreeNode root, int k)
        {
            List<TreeNode> parsed = new List<TreeNode>();
            InOrder(parsed, root);
            if (parsed.Count < k) return -1;
            return parsed[k].val;
        }

        private void InOrder(List<TreeNode> parsed, TreeNode root)
        {
            if (root == null) return;

            InOrder(parsed, root.left);
            parsed.Add(root);
            InOrder(parsed, root.right);
        }


        public void Run()
        {
            TreeNode root = new TreeNode { val = 3 };
            TreeNode l1 = new TreeNode { val = 1 };
            TreeNode l2 = new TreeNode { val = 4 };
            root.left = l1;
            root.right = l2;
            TreeNode l3 = new TreeNode { val = 2 };
            l1.right = l2;

            KthSmallest(root, 1);
        }
    }
}