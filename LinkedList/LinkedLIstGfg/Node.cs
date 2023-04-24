using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;
using System.Text;

namespace LinkedLIstGfg
{
    internal class Node
    {
        public int data;
        public Node next;

        public Node(int x)
        {
            data = x;
            next = null;
        }

        public static Node InsertBegin(Node head, int x)
        {
            Node temp = new Node(x);
            temp.next = head;
            return temp;
        }

        public static Node InsertEnd(Node head, int x)
        {
            Node temp = new Node(x);
            if (head == null)
            {
                return temp;
            }
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;

            }
            curr.next = temp;
            return head;
        }

        public static Node DeleteHead(Node head)
        {
            if(head == null) { return null; }
            return head.next;
        }
        public static Node DeleteLastNode(Node head)
        {
            if (head == null) 
            {
                return null; 
            }
            if(head.next == null)
            {
                return null;
            }
            Node curr = head;
            while(curr.next.next != null) 
            {
                curr = curr.next;
            }
            curr.next = null;
            return head;
        }

        public static Node InsertPosition(Node head,int position,int data)
        {
            Node temp = new Node(data);
            if(position== 1)
            {
                temp.next = head;
                return temp;
            }
            Node curr = head;
            for(int i=1; i <= position-2 && curr!=null;i++)
            {
                curr= curr.next;
            }
            if (curr == null)
            {
                return head;
            }
            temp.next = curr.next;
            curr.next = temp;
            return head;
        }

        public static int search(Node head,int data)
        {
            int position = 1;
            Node curr = head;
            while(curr != null)
            {
                if (curr.data == data)
                {
                    return position;
                }
                else
                {
                    position++;
                    curr = curr.next;
                }
            }
            return -1;

        }

        public static int searchRecursive(Node head, int data)
        {
            if (head == null)
            {
                return -1;
            }
            if (head.data == data)
            {
                return 1;
            }
            else
            {
                int result=searchRecursive(head.next, data);
                if (result == -1)
                {
                    return -1;
                } 
                else
                {
                    return result + 1;
                }
            }

        }
    }
}
