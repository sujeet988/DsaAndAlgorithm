﻿using System.Collections.Generic;

namespace LinkedListAllOperation
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linked List Operation");
            LinkedList obj=new LinkedList();
            for(int i = 1;i <= 10; i++)
            {
                obj.InsertAtLast(i);
            }
            obj.DisplayNode();
            //Search value in Linked List
            int x = 4;
            var isFound = obj.Search(x);
            if (isFound)
            {
                Console.WriteLine(x + " Value is found ");

            }
            else
            {
                Console.WriteLine(x + " Value is not found ");

            }
            

            //delete 1 from  list
            obj.DeletionAtHead(); // deleting 1 from list 
            obj.DisplayNode();

            //delete 5 from  list
            obj.DeletionAtTail(); // deleting 1 from list 
            obj.DisplayNode();

            //delete 5 from  list
            obj.DeleteAtGivenvalue(2); // deleting 1 from list 
            obj.DisplayNode();

            // Length of List
            obj.DisplayNode();
            int count= obj.Length(); 
            Console.WriteLine("length of list is "+ count);

            //reverse list
            obj.ReverseList(); // deleting 1 from list 
            obj.DisplayNode();


            Console.ReadLine(); 

        }
    }
}