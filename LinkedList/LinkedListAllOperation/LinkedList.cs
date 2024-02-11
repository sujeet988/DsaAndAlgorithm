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

        public void InsertAtLast()
        {

        }

        public void InsertAtFirst(int x)
        {
            Node newnode=new Node ();
            newnode.data = x;
            if(IsEmpty()) 
            { 
                head = newnode;

            }
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
