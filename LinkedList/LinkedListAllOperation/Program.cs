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

            /*Detect a Loop in a Linked List
             */
            Console.WriteLine("Detect loop in Linked list demo");
            LinkedList list=new LinkedList();
            for(int i=1; i <= 5; i++)
            {
                list.InsertAtFirst(i);
                list.DisplayNode();
            }
            list.InsertLoop();
            list.Elements();
            string listLoop = list.Elements(); // printing list after creating loop
            Console.WriteLine("List : " + listLoop);

            bool checkLoop = list.DetectLoop(); // calling detectLoop function
            Console.WriteLine("Loop detected : " + checkLoop);

            /*
             *Find Middle Node in a Linked List
            */
            Console.WriteLine("Middle element of the list : Demo");
            list = new LinkedList();
            var rand = new Random();
            int num = 0;
            for (int i = 1; i <= 5; i++)
            {
                num = rand.Next(10);   //generating random numbers in range 1 to 100
                list.InsertAtFirst(num);    // inserting value in the list
                list.DisplayNode();
            }

            //using two pointer
            int mid = list.FindMid();    //calling findMid function
            Console.WriteLine("Middle element of the list using two pointer approach : " + mid);

            //using two loop
             mid = list.middleNodeusingtwoloop();    //calling findMid function
            Console.WriteLine("Middle element of the list using two loop approach : " + mid);

            //Remove Duplicate from unsorted Array
            Console.WriteLine("Remove duplciate from unsorted array demo");
            list = new LinkedList();
            list.InsertAtLast(1);
            list.InsertAtLast(3);
            list.InsertAtLast(3);
            list.InsertAtLast(2);
            list.InsertAtLast(2);
            list.InsertAtLast(4);
            list.InsertAtLast(5);
            list.DisplayNode();

            list.RemoveDuplicateFromUnsortedLinkedList();
            Console.WriteLine("Node after delete duplicate values");
            list.DisplayNode();


            ///Union of two linked list
            Console.WriteLine("Union Demo");
            LinkedList list1 = new LinkedList();  // creating lists
            LinkedList list2 = new LinkedList();
            list1.InsertAtLast(10);
            list1.InsertAtLast(20);
            list1.InsertAtLast(80);
            list1.InsertAtLast(20);
            list1.InsertAtLast(60);
            Console.WriteLine("List1 values");
            list1.DisplayNode();

            // list 2
            list2.InsertAtLast(15);
            list2.InsertAtLast(20);
            list2.InsertAtLast(30);
            list2.InsertAtLast(60);
            list2.InsertAtLast(60);
            list2.InsertAtLast(45);

            Console.WriteLine("List2 values");
            list2.DisplayNode();
            string result= list1.Union(list1,list2);
            Console.WriteLine("Union result : " + result);


            ///Intersection of two linked list
            Console.WriteLine("Union Demo");
             list1 = new LinkedList();  // creating lists
             list2 = new LinkedList();
            list1.InsertAtLast(10);
            list1.InsertAtLast(20);
            list1.InsertAtLast(80);
            list1.InsertAtLast(20);
            list1.InsertAtLast(60);
            Console.WriteLine("List1 values");
            list1.DisplayNode();

            // list 2
            list2.InsertAtLast(15);
            list2.InsertAtLast(20);
            list2.InsertAtLast(30);
            list2.InsertAtLast(60);
            list2.InsertAtLast(60);
            list2.InsertAtLast(45);

            Console.WriteLine("List2 values");
            list2.DisplayNode();
            string resultintersection = list1.Union(list1, list2);
            Console.WriteLine("intersction result : " + result);


            Console.ReadLine(); 

        }
    }
}