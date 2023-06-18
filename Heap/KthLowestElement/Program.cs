
using DsaAndAlgorithm.Heap.KthLowestElement;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[6] { 100, 10, 8, 34, 2, 7 };
Kth obj = new Kth();
var output = obj.FindKthLowest(arr, 3);
Console.WriteLine(output);
Console.ReadLine();