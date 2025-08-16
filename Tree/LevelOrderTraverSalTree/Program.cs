namespace LevelOrderTraverSalTree
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
    internal class Program
    {
        /*
         * https://leetcode.com/problems/binary-tree-level-order-traversal/description/?envType=problem-list-v2&envId=mcp0c4ld
         * Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
         * Input: root = [3,9,20,null,null,15,7]
            Output: [[3],[9,20],[15,7]]
            Example 2:

            Input: root = [1]
            Output: [[1]]
            Example 3:

            Input: root = []
            Output: []
         */

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                IList<int> templist = new List<int>();
                int len = q.Count; // count ony for curent level

                for (int i = 0; i < len; i++)
                {
                    TreeNode temp = q.Dequeue();

                    templist.Add(temp.val);

                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }


                }
                result.Add(templist);

            }

            return result;
        }
        // // Another approach using the same logic but with different variable names
        public IList<IList<int>> LevelOrderApproach2(TreeNode root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            while (true)
            {
                IList<int> templist = new List<int>();
                int len = q.Count; // count ony for curent level
                if (len == 0) // If no nodes left to process, break the loop
                {
                    return result;
                }
                while (len > 0)
                {
                    TreeNode temp = q.Dequeue();
                    templist.Add(temp.val);
                    if (temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                    len--; // Decrease the count of nodes to process for the current level
                }
                result.Add(templist);
                
            }

           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Level Order Traversal");
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Program program = new Program();
            var result = program.LevelOrderApproach2(root);
            foreach (var list in result)
            {
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }  
            Console.ReadLine();
        }
    }
}
