
using DsaAndAlgorithm.Heap.KthLowestElement;
Console.WriteLine("Kth Lowest Element Demo");

int[] arr = new int[6] { 7, 10, 4, 3, 20, 15 };
int k = 3;
KthLowestElement obj = new KthLowestElement();
var output = obj.FindKthLowest(arr, k);
Console.WriteLine("kth {0} lowest element is {1}", k, output); // ouput 7

//By Reverse order i.e  Maxheap  Priority Queue

var kthlower = obj.FindKthLowestusingComparer(arr, k);
Console.WriteLine("kth {0} lowest element using reverse order/max heap {1}", k, kthlower); // ouput 7

Console.ReadLine();