using System;
using System.Net.Http.Headers;

namespace LinkedListRaviDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node Head= null;
            Head = new Node(10);
            Node data1=new Node(20);
            Node data2=new Node(30);
            Head.next=data1;
            data1.next=data2;
            /////////////////////
            int n = 50;
            Node newnode= InsertItematFirst(Head,n);
            Display(newnode);
            Console.ReadLine();
        }

        public static  void Display(Node head)
        {
            Node temp = head;
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }

        public static Node InsertItematFirst(Node head,int n)
        {
            Node temp = new Node(n);
            temp.next = head;
            return temp;

        }
    }
}
