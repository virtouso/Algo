using System.Collections.Generic;

namespace Algorithms.Problems
{
    public class SerializeDeserializeBinaryTree
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root) {
            List<string> result = new List<string>();
            SerializeHelper(root, result);
            return string.Join(",", result);
        }

        private void SerializeHelper(TreeNode node, List<string> result) {
            if (node == null) {
                result.Add("null");
                return;
            }
        
            result.Add(node.val.ToString());
            SerializeHelper(node.left, result);
            SerializeHelper(node.right, result);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data) {
            Queue<string> nodes = new Queue<string>(data.Split(','));
            return DeserializeHelper(nodes);
        }

        private TreeNode DeserializeHelper(Queue<string> nodes) {
            if (nodes.Count == 0) {
                return null;
            }
        
            string val = nodes.Dequeue();
            if (val == "null") {
                return null;
            }
        
            TreeNode node = new TreeNode(int.Parse(val));
            node.left = DeserializeHelper(nodes);
            node.right = DeserializeHelper(nodes);
        
            return node;
        }
    }
}