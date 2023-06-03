using System;

namespace BinaryTree
{




    public class BinaryTree
    {
        public  class Node
        {
           public int value;
            public Node left;
            public Node right;
            public Node(int value)
            {
             this.value = value;
            }
        }

        public Node root;

        public void Populate()
        {
            Console.WriteLine("Enter the root node values");
            int value=Convert.ToInt32(Console.ReadLine());
            root=new Node(value);
            Populate(root);
        }

        private void Populate(Node node)
        {
            Console.WriteLine("Do you want to enter left of " + node.value);
            Boolean left=Convert.ToBoolean(Console.ReadLine());
            if (left)
            {
                Console.WriteLine("Enter the value of left of " + node.value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.left= new Node(value);
                Populate(node.left);
            }

            Console.WriteLine("Do you want to enter right of " + node.value);
            Boolean right = Convert.ToBoolean(Console.ReadLine());
            if (right)
            {
                Console.WriteLine("Enter the value of right of " + node.value);
                int value = Convert.ToInt32(Console.ReadLine());
                node.right = new Node(value);
                Populate(node.right);
            }
        }

        public void Display()
        {
            Display(this.root, "");
        }

        private void Display(Node node, string indent)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(indent + node.value);
            Display(node.left, indent+"\t");
            Display(node.right, indent+"\t");


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tree Demo");
            BinaryTree obj=new BinaryTree();
            obj.Populate();
            obj.Display();
            Console.ReadLine();

        }
    }
}
