using System;

namespace LinkedListKK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LL list= new LL();
            list.insertFirst(4);
            list.insertFirst(3);
            list.insertFirst(2);
            list.insertFirst(1);
            list.display();
            list.insertLast(20);
            list.display();
            list.insert(100,3);
            list.display();


            Console.ReadLine();
        }
    }
}
