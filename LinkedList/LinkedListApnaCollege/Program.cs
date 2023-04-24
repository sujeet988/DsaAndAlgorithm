// See https://aka.ms/new-console-template for more information
using LinkedListApnaCollege;

Console.WriteLine("Linekd List Demo");
LL list= new LL();
list.addFirst("sujeet");
list.addFirst("amit");
list.addFirst("alok");
list.printList();
//Add Last
list.addLast("add last piyusj");
list.printList();
//remove first
//list.removeFirst();
//list.printList();

//remove last
////list.removeLast();
////list.printList();
///

//reverse a linked list
list.reverse();
list.printList();

Console.ReadLine();

