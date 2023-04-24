using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace DsAlgo.Tree
{
    public class BinaryTree
    {

        public class TreeNode
        {
            public TreeNode left;
            public TreeNode right;
            public int data;
            public TreeNode(int data)
            {
                this.data = data;

            }
        }

        public TreeNode root;

        public void createBinaryTree()
        {
            TreeNode first = new TreeNode(1);
            TreeNode second = new TreeNode(2);
            TreeNode third = new TreeNode(3);
            TreeNode fourth = new TreeNode(4);
            TreeNode fifth = new TreeNode(5);
            TreeNode sixth = new TreeNode(6);
            TreeNode seventh = new TreeNode(7);

            root = first;
            first.left = second;
            first.right = third;
            second.left = fourth;
            second.right = fifth;
            third.left = sixth;
            third.right = seventh;
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

        public void PreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.Write(root.data + " ");
            PreOrder(root.left);
            PreOrder(root.right);
        }
        public void PreOrderByIteration()
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode temp = stack.Pop();
                Console.Write(temp.data + " ");
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }
            }

        }

        public void PostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            PostOrder(root.left);
            PostOrder(root.right);
            Console.Write(root.data + " ");
        }
        public void PostOrderByIteration()
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode temp = stack.Pop();
                Console.Write(temp.data + " ");
                if (temp.right != null)
                {
                    stack.Push(temp.right);
                }
                if (temp.left != null)
                {
                    stack.Push(temp.left);
                }

            }
        }

        public void LevelOrder()
        {
            if (root == null)
            {
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                TreeNode temp = queue.Dequeue();
                Console.Write(temp.data + " ");
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.right);
                }
            }
        }

        public  IList<IList<int>>  LevelOrdeusingList()
        {
            List<IList<int>> result = new List<IList<int>>();

            if (root == null)
            {
                return result;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {

                var levelnumber = queue.Count;
                List<int> sublist = new List<int>();
                for(int i=0; i < levelnumber; i++)
                {
                    TreeNode temp = queue.Dequeue();
                    if (temp.left != null)
                    {
                        queue.Enqueue(temp.left);
                    }
                    if (temp.right != null)
                    {
                        queue.Enqueue(temp.right);
                    }
                    sublist.Add(temp.data);
                }
                result.Add(sublist);
            }
           return result;
        }

        public void PrintLevelOrdeusingList()
        {
            var result = LevelOrdeusingList();
            foreach(var list in result)
            {
                foreach(var item in list)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            bt.createBinaryTree(); ////Creating tree;
                                   //in order display
            //bt.InOrder(bt.root);
            //Console.WriteLine();
            //bt.PreOrder(bt.root);
            //Console.WriteLine();
            //bt.PostOrder(bt.root);
            //Console.WriteLine("\nPreOrder using iteration");
            //bt.PreOrderByIteration();
            //Console.WriteLine("\nPostOrder using iteration");
            //bt.PostOrderByIteration();
            //level order travrersal
            Console.WriteLine("\nLevel order");
            bt.LevelOrder();
            Console.WriteLine("\nLevel order using list");
            bt.PrintLevelOrdeusingList();
            Console.ReadLine();

        }
    }

}
