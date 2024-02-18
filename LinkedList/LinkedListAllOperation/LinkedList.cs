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
            while (last.nextElement.nextElement != null)
            {

                last = last.nextElement;
            }

            last.nextElement = null;

            return true;
        }
        public bool DeleteAtGivenvalue(int value)
        {
            bool isDeleted = false;
            if (IsEmpty())
            {
                Console.WriteLine("list is empty");
                return false;
            }

            Node temp = head;
            if (temp.data == value)
            {
                return DeletionAtHead(); // value found at first position
            }

            return isDeleted;
        }
        public int Length()
        {
            int count = 0;
            Node temp= head;
            while (temp != null)
            {
                count++;
                temp= temp.nextElement;
            }
            return count;
        }
        public void ReverseList()
        {

            Node prev = null;
            Node current= head;
            Node next = head.nextElement;
            while (current != null)
            {
                current.nextElement = prev;
                prev= current;
                current= next;
                if (next != null)
                {
                    next = next.nextElement;
                }
            }
            head = prev;

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
        /// <summary>
        /// make cycle loop and point  last elemnt to  head or any other element
        /// </summary>
        public void InsertLoop()
        {
            Node temp = head;
            // traversing to get to last element of the list
            while (temp.nextElement != null)
            {
                temp = temp.nextElement;
            }
            temp.nextElement = head; // pointing last element to head of the list
        }

        public string Elements()
        { 
            // this function will return all values of linked List
            string elementsList = "";
            Node start = head;
            Node check = head;

            elementsList += start.data.ToString();
            elementsList += "->";
            start = start.nextElement;

            while (start != null && start.data != check.data)
            {
                elementsList += start.data.ToString();
                elementsList += "->";
                start = start.nextElement;
            }

            if (start == null)
                return elementsList + "null";

            elementsList += check.data.ToString();
            return elementsList;
        }
        public bool DetectLoop()
        {
            Node slow = head;
            Node fast= head;
            while (slow != null && fast !=null && fast.nextElement != null)
            {
                slow = slow.nextElement;
                fast = fast.nextElement.nextElement;
                /* If slow and fast meet at some point then there
                    is a loop */
                if (slow == fast)
                {
                    // Return 1 to indicate that loop is found */
                    return true;
                }
            }

            // Return false to indeciate that ther is no loop*/
            return false;
        }
        /// <summary>
        /// Find mid using two pointer
        /// </summary>
        /// <returns></returns>
        public int FindMid()
        {
            if (IsEmpty())
            {
                return 0;
            }
            Node slow = head;
            Node fast = head;
            if (slow.nextElement == null)
            {
                return slow.data;
            }
            while (fast != null && fast.nextElement != null)
            {
                slow = slow.nextElement;
                fast = fast.nextElement.nextElement;
            }
            // Write your code here
            return slow.data;
        }
        /// <summary>
        /// middle Node using two loop
        /// </summary>
        /// <returns></returns>
        public int middleNodeusingtwoloop()
        {
            if (IsEmpty())
            {
                return 0;
            }
            int len = 0;
            //find length of a linked list
             len = Length();
            Node temp = head;
            int mid = 0;

            while (mid < len / 2)
            {

                temp = temp.nextElement;
                mid++;
            }
            return temp.data; // first element is middle element

        }
        /// <summary>
        /// Remove Duplicate From Unsorted LinkedList
        /// </summary>
        /// <returns></returns>
        public void RemoveDuplicateFromUnsortedLinkedList()
        {

            Node temp= head;

            if (temp == null)
            {
                return ;
            }

            HashSet<int> hset=new HashSet<int> ();
            hset.Add (temp.data);

            while(temp != null && temp.nextElement !=null)
            {
                if(hset.Contains(temp.nextElement.data))
                {
                    temp.nextElement = temp.nextElement.nextElement;
                }
                else
                {
                    hset.Add (temp.nextElement.data);
                    temp = temp.nextElement;
                }
            }

        }


    }
}
