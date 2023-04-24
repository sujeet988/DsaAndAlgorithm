using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTrees
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }

    }

    public class BinaryTree

    {
        int idx = -1;
        public Node buildTree(int[] nodes)
        {
            idx++;
            if (nodes[idx] == -1)
            {
                return null;
            }

            Node newNode = new Node(nodes[idx]);
            newNode.left = buildTree(nodes);
            newNode.right = buildTree(nodes);
            return newNode;
        }

        public void preOrder(Node root)
        {
            if (root == null)
            {
                //Console.Write(-1 + " ");
                return;
            }
            Console.Write(root.data + " ");
            preOrder(root.left);
            preOrder(root.right);
        }

        public void inorder(Node root)
        {
            if (root == null)
            {
                //Console.Write(-1 + " ");
                return;
            }
            inorder(root.left);
            Console.Write(root.data + " ");
            inorder(root.right);
        }


        public void postorder(Node root)
        {
            if (root == null)
            {
                //// Console.Write(-1 + " ");
                return;
            }
            postorder(root.left);
            postorder(root.right);
            Console.Write(root.data + " ");
        }

    }

}
