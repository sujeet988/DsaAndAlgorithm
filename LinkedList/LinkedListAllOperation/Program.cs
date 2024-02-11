namespace LinkedListAllOperation
{

    class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;

        }

        public static void DisplayNodeValue(Node head) 
        {
            Node temp=head;
            while(temp != null)
            {
                Console.Write(temp.data);
                if(temp.next != null)
                {
                    Console.Write("->");
                }

                temp=temp.next;
            }
        
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operation");
            Node head=new Node(1);
            Node node2 = new Node(2);
            head.next = node2;
            Node node3 = new Node(3);
            node2.next = node3;
            Node node4 = new Node(4);
            node3.next = node4;

            // Display linked Values
            Node.DisplayNodeValue(head);

            Console.ReadLine(); 

        }
    }
}