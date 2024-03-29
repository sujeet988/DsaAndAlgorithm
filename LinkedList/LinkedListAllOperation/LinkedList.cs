﻿using System;
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
            Node temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.nextElement;
            }
            return count;
        }
        public void ReverseList()
        {

            Node prev = null;
            Node current = head;
            Node next = head.nextElement;
            while (current != null)
            {
                current.nextElement = prev;
                prev = current;
                current = next;
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
            Node fast = head;
            while (slow != null && fast != null && fast.nextElement != null)
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

            Node temp = head;

            if (temp == null)
            {
                return;
            }

            HashSet<int> hset = new HashSet<int>();
            hset.Add(temp.data);

            while (temp != null && temp.nextElement != null)
            {
                if (hset.Contains(temp.nextElement.data))
                {
                    temp.nextElement = temp.nextElement.nextElement;
                }
                else
                {
                    hset.Add(temp.nextElement.data);
                    temp = temp.nextElement;
                }
            }

        }

        public string PrintElementsusingstring()
        { 
            // this function will return all values of linked List
            string elementsList = "";
            Node start = head;

            elementsList += start.data.ToString();
            elementsList += "->";
            start = start.nextElement;

            while (start != null )
            {
                elementsList += start.data.ToString();
                elementsList += "->";
                start = start.nextElement;
            }

            if (start == null)
            {
                elementsList= elementsList + "null";
            }
                 

            return elementsList;
        }

        /* time complexity for Union 
If you did not have the care of duplicates, the runtime complexity of this algorithm would be O(m) where m is the size of the first list. However, because of duplicates, you need to traverse the whole union list. This increases the time complexity to 
O(m+n)2 where m is the size of the first list, and n is the size of the second list.
         */
        /// <summary>
        /// union of two linked list
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public string Union(LinkedList list1, LinkedList list2)
        {

            //Return other List if one of them is empty
            if (list1.IsEmpty())
            {
                list2.PrintElementsusingstring();
            }
            else if(list2.IsEmpty())
            {
                return list2.PrintElementsusingstring();
            }
            Node start = list1.head;
            //Traverse first list till the last element
            while(start.nextElement != null)
            {
                start=start.nextElement;
            }
            //Link last element of first list to the first element of second list
            start.nextElement = list2.head;//// append list2 with list 1 
            list1.RemoveDuplicateFromUnsortedLinkedList(); // removing duplicates from list and return list
            return list1.PrintElementsusingstring();  // converrting to string
        }

        /* Time complexity
        The outer loop will run m times, and the inner loop will run n times. Whereas, the complexity of the RemoveDuplicates() will be 
        RemoveDuplicates() will be 
        O(min(m,n)2
        )
        depending upon the size of the list3. The overall complexity of
        this solution will be max(O(mn),O(min(m,n) 2 ))
        where m is the size of the first list, and n is the size of the second list.
         */

        /// <summary>
        /// Intersction of two linked list
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public string InterSection(LinkedList list1, LinkedList list2)
        {
            LinkedList list3=new LinkedList ();
            Node t1=list1.head;
            Node t2 = list2.head;
            // Traverse both lists and store the same element 
            // in the resultant list list3
            while (t1 != null)
            {
                while(t2 != null)
                {
                    if (t1.data == t2.data)
                    {
                        list3.InsertAtFirst(t1.data);
                    }
                    t2=t2.nextElement;

                }
                t2 = list2.head;
                t1=t1.nextElement;
            }
 
            list3.RemoveDuplicateFromUnsortedLinkedList(); // removing duplicates from list and return list
            return list3.PrintElementsusingstring();  // converrting to string
        }

        //To Find nth node from end of list
        public int FindNth(int n)
        {
            // Write your code here
            if (IsEmpty())
            {
                return -1;
            }
            int len = 0;

            Node temp = head;
            while (temp != null)
            {
                temp=temp.nextElement;
                len++;
            }

            int pos = len - n + 1;
            // again  to temp
            temp= head;
            len = 0; 
            while (temp != null) 
            { 
                if(pos-1==len)
                {
                    return temp.data;
                }
                temp=temp.nextElement;
                len++;
            }

            return -1;
        }
    }

    
}
