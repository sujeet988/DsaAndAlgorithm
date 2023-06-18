
using DsaAndAlgorithm.Heap.KthLowestElement;
Console.WriteLine("Kth Lowest Element Demo");

int[] arr = new int[6] { 100, 10, 8, 34, 2, 7 };
int k = 3;
KthLowestElement obj = new KthLowestElement();
var output = obj.FindKthLowest(arr, k);
Console.WriteLine("kth {0} lowest element is {1}", k, output);
Console.ReadLine();