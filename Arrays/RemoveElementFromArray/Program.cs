// See https://aka.ms/new-console-template for more information
using System;
using DsAgo.Sujeet;
///https://www.geeksforgeeks.org/remove-an-element-at-specific-index-from-an-array-in-java/
Console.WriteLine("Remove an Element at Specific Index from an Array in Java");

// Get the array
int[] arr = { 1, 2, 3, 4, 5 };
Console.WriteLine("Original Array:");
foreach (int i in arr)
{
    Console.Write(i + " ");
}
// Get the specific index
int index = 2;
// Print the index
Console.WriteLine("Index to be removed: " + index);

int[] result = null;
// Remove the element using loop
result = RemoveElementFromArray.removeTheElement(arr, index);

// Print the resultant array
Console.WriteLine("Resultant Array:");
foreach(int i in result)
{
    Console.Write(i+" ");
}

// Remove the element using list
result = RemoveElementFromArray.removeTheElementUsingList(arr, index);
// Print the resultant array
Console.WriteLine("Resultant Array:");
foreach (int i in result)
{
    Console.Write(i + " ");
}