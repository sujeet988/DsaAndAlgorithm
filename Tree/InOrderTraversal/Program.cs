namespace InOrderTraversal
{
    /*
     * Input:
        10
     /      \ 
    20       30 
  /    \    /
 40    60  50
Output: 40 20 60 10 50 30

     */

    // Node class for the binary tree
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        // Constructor to initialize
        // the node with a value
        public Node(int val)
        {
            data = val;
            left = null;
            right = null;
        }
    }

   


    internal class Program
    {
        public static void InOrder(Node root, List<int> list)
        {
            if (root == null)
            {
                return;
            }

            InOrder(root.left, list);
            list.Add(root.data);
            InOrder(root.right, list);

        }

        public static List<int> InOrderUsingStack(Node root)
        {
            List<int> list = new List<int>();
            if (root == null)
            {
                return list;
            }

            Stack<Node> stack = new Stack<Node>();


            while (true) 
            {
                 if(root != null) 
                {
                    stack.Push(root);
                    root=root.left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        break;
                    }

                    Node temp= stack.Pop();
                    list.Add(temp.data);    
                    root = temp.right;
                }
            }

            return list;


        }
        static void Main(string[] args)
        {
           
            // Creating a sample binary tree
            Node root = new Node(10);
            root.left = new Node(20);
            root.right = new Node(30);
            root.left.left = new Node(40);
            root.left.right = new Node(60);
            root.right.left = new Node(50);

            List<int> list = new List<int>();
            Console.WriteLine("Inorder Traversal using recursion");
            InOrder(root, list);
            foreach(int val in list)
            {
                Console.Write($"{val}" +" "); //  40 20 60 10 50 30
            }

            Console.WriteLine();
            Console.WriteLine("Inorder Traversal using Stack or iterative ");

            var outputusingstack = InOrderUsingStack(root);
            foreach (int val in outputusingstack)
            {
                Console.Write($"{val}" + " "); //  40 20 60 10 50 30
            }

            Console.ReadLine();
        }
    }
}