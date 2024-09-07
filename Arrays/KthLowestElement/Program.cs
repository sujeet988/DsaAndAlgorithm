
using KthLowestElement;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] arr = new int[6] { 100, 50, 8, 34, 2, 7 };

Kth obj = new Kth();
var output = obj.FindKthLargest(arr, 3);
Console.WriteLine(output); // 3rd highest is 34

output = obj.FindKthLowest(arr, 3);
Console.WriteLine(output); // 3 lowest is 8
Console.ReadLine();