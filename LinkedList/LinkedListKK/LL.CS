using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListKK
{
    public class LL
    {

        Node head;
        Node tail;
        int size = 0;
        public LL()
        {
            this.size = 0;
        }
        public void insertFirst(int val)
        {
            Node node=new Node(val);
            node.next = head;
            head = node;
            if(tail == null) //For single element in linked list
            {
                tail = head;
            }
            size++;
        }

        public void insertLast(int val)
        {
            Node node = new Node(val);
            if(tail== null)
            {
                insertFirst(val);
                return;
            }
            tail.next = node;
            tail = node;
           
        }

        public void insert(int val, int index)
        {
            if (index == 0)
            {
                insertFirst(val);
                return;
            }
            if (index == size)
            {
                insertLast(val);
                return;
            }

            Node temp = head;
            for(int i=1; i < index; i++)
            {
                temp = temp.next;
            }

            Node node = new Node(val, temp.next);
            temp.next = node;

            ////or
            ////Node node = new Node(val);
            ////node.next = temp.next;
            ////temp.next = node;
            size++;

        }

        public void display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.value + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("END");

        }


        private sealed class Node
        {
          internal readonly int value;
           internal Node next;

            public Node(int value)
            {
                this.value = value;
            }

            public Node(int value, Node next)
            {
                this.value = value;
                this.next = next;
            }
        }

    }
}
