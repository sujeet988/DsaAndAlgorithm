using System;

namespace LinkedLIstGfg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Node head = new Node(10);
            ////Node temp1 = new Node(20);
            ////Node temp2 = new Node(30);
            ////head.next = temp1;
            ////temp1.next = temp2;


            //insert at begin
            Node head = null;
            head = Node.InsertBegin(head, 30);
            head = Node.InsertBegin(head, 20);
            head = Node.InsertBegin(head, 10);
            // head = Node.InsertEnd(head, 200);

            //print using recusrion
            // printusingrecusrion(head);
            //delete first head
            // head= Node.DeleteHead(head);
            //delete last node
            // head=Node.DeleteLastNode(head);
            //insert at given position

            head = Node.InsertPosition(head, 3, 300);

            //search
            Console.WriteLine(Node.searchRecursive(head, 30));

            //print(head);
            //print using recusrion
            printusingrecusrion(head);
            Console.ReadLine();
        }


      

        public static void print(Node head)
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data+" ");
            current = current.next;
            }
        }
        public static void printusingrecusrion(Node head)
        {
            if(head == null)
            {
                return;
            }
            Console.Write(head.data+" ");
            printusingrecusrion(head.next); 
        }
    }
}
