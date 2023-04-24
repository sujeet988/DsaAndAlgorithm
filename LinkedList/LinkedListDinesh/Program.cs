// See https://aka.ms/new-console-template for more information
using LinkedListDinesh;

SinglyLinkedList sll1 = new SinglyLinkedList();
sll1.insertFirst(10);
sll1.insertFirst(20);
sll1.insertFirst(30);
sll1.display();
sll1.insertLast(100);
sll1.display();
//search
var isexist = sll1.find(100);
Console.WriteLine(isexist);
Console.ReadLine();


