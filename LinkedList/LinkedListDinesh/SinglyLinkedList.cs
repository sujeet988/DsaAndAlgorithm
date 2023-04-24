using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDinesh
{
    public class SinglyLinkedList
    {

        private ListNode head;
        public class ListNode
        {

            public int data;
            public ListNode next;
            public ListNode(int data)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void display()
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.data + " --> ");
                current = current.next;
            }
            Console.Write("null");
            Console.WriteLine();
        }

        public int length()
        {
            if (head == null) return 0;
            int count = 0;
            ListNode current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
        public void insertFirst(int data)
        {
            ListNode newNode = new ListNode(data);
            newNode.next = head;
            head = newNode;
        }
        public void insertLast(int data)
        {
            ListNode newNode = new ListNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            ListNode current=head;
            while (current.next != null)
            {
                current=current.next;
            }
           current.next=newNode; 
        }

        public bool find(int searchKey)
        {
            if (head == null)
            {
                return false;
            }

            ListNode current = head;
            while (current != null)
            {
                if (current.data == searchKey)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
    }
}
