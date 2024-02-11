using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAllOperation
{
    public class Node
    {
        public int data;
        public Node nextElement;
        public Node()
        {
            nextElement = null;

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
            if (head == null)
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
            Node newnode = new Node();
            newnode.data = x;
            newnode.nextElement = head;
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
            while (last.nextElement != null)
            {
                last = last.nextElement;
            }
            last.nextElement = newnode;
        }
        public bool Search(int value)
        {
            if (IsEmpty())
            {
                return false;
            }

            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return true;
                }
                temp = temp.nextElement;
            }

            return false;
        }

        public bool DeletionAtHead()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return false;
            }
            head = head.nextElement;
            return true;
        }
        public bool DeletionAtTail()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
                return false;
            }
            Node last = head;
            while (last.nextElement.nextElement!= null)
            {

                last= last.nextElement;
            }

            last.nextElement = null;

            return true;
        }
        public bool Delete(int value)
        {
            bool isDeleted=false;

            return isDeleted;
        }

            public void DisplayNode()
        {

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.nextElement;
            }
            Console.WriteLine("null ");

        }

    }
}
