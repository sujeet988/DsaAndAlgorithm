using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApnaCollege
{
    public class LL
    {
        Node head = null;

        public class Node
        {
            public string data;
            public Node next;
            public Node(string data)
            {
                this.data = data;
                this.next = null;
            }
        }

        public void addFirst(string data)
        {
            Node newNode=new Node(data);
            newNode.next = head;
            head = newNode;   
        }
        public void addLast(string data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node lastNode = head;
            while(lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            lastNode.next = newNode;
        }

        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing To Delets");
                return;
            }
            head = head.next;
        }

        public void removeLast()
        {
            Node currentnode = head;
            Node lastNode = head;
            while(lastNode.next.next != null)
            {
                currentnode= currentnode.next;
                lastNode = lastNode.next;
            }
            currentnode.next = null;
        }
        public void reverse()
        {
            Node prev = null;
            Node current = head;

            while( current != null )
            {
                Node next=current.next;
                current.next = prev;
                prev = current;
                current= next;
            }
            head = prev;
        }

        public void printList()
        {
            Node current= head;
            while(current != null)
            {
                Console.Write(current.data + " > ");
                current = current.next;
            }
            Console.WriteLine("End");
        }
    }
}
