using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAllOperation
{
   public  class Node
    {
        public int data;
        public Node next;
        public Node()
        {
            next = null;

        }
    }


    public class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            if(head==null)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

       

        public void InsertAtFirst(int x)
        {
            Node newnode= new Node();
            newnode.data = x;
            newnode.next = head;
            head = newnode;
           
        }
        public void InsertAtLast(int x)
        {

            if (IsEmpty())
            {
                InsertAtFirst(x);
                return;

            }

            Node newnode = new Node();
            newnode.data = x;
            Node last = head;

            while(last.next != null)
            {
                last= last.next;
            }
            last.next=newnode;
        }

        public  void DisplayNode()
        {

            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.data+"->");
                temp = temp.next;
            }
            Console.WriteLine("null ");

        }
        
    }
}
