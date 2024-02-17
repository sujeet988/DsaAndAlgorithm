using System.Collections.Generic;

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
            Console.WriteLine($"Search given value {x}");
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
            Console.WriteLine("Deleteing first node from linked list");
            obj.DeletionAtHead(); 
            obj.DisplayNode();

            //delete 5 from  list
            Console.WriteLine("Deleteing last node from linked list");
            obj.DeletionAtTail(); 
            obj.DisplayNode();

            //delete 5 from  list
            int val = 2;
            Console.WriteLine($"Deleteing give  Value {val}");
            obj.DeleteAtGivenvalue(val); 
            obj.DisplayNode();

            // Length of List
            obj.DisplayNode();
            int count= obj.Length(); 
            Console.WriteLine("length of list is "+ count);

            //reverse list
            obj.ReverseList(); 
            obj.DisplayNode();


            Console.ReadLine(); 

        }
    }
}