using System;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace DsaAndAlgorithm.Trees
{
    public class BinarySearchTree
    {
        public TreeNode root;
        public class TreeNode
        {
            public int data;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        public void Insert(int value)
        {
            root = Insert(root, value);
        }

        public TreeNode Insert(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }
            if (value < root.data)
            {
                root.left = Insert(root.left, value);
            }
            else
            {
                root.right = Insert(root.right, value);
            }

            return root;
        }
        public void InOrder()
        {
            InOrder(root);
        }
        public void InOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InOrder(root.left);
            Console.Write(root.data + " ");
            InOrder(root.right);
        }
        public TreeNode Search(int key)
        {
            return Search(root, key);
        }

        public TreeNode Search(TreeNode root, int key)
        {
            if (root == null || root.data == key)
            {
                return root;
            }
            if (key < root.data)
            {
                return Search(root.left, key);
            }
            else
            {
                return Search(root.right, key);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree Demo");
            BinarySearchTree objlist = new BinarySearchTree();
            objlist.Insert(10);
            objlist.Insert(20);
            objlist.Insert(30);

            //Print Binary Search Tree
            objlist.InOrder();

            //search Given Key
            int key = 40;
            var output = objlist.Search(key);
            if(output != null)
            {
                Console.WriteLine("Key found : "+key);
            }
            else
            {
                Console.WriteLine("Key Not found : " + key);
            }

            Console.ReadLine();

        }
    }
}
