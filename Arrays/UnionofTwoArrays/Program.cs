// See https://aka.ms/new-console-template for more information
using UnionofTwoArrays;

/*
 * https://practice.geeksforgeeks.org/problems/union-of-two-sorted-arrays-1587115621/1
 * The union of two arrays can be defined as the common and distinct elements in the two arrays.NOTE: Elements in the union should be in ascending order
 * https://takeuforward.org/data-structure/union-of-two-sorted-arrays/
 
 */

Console.WriteLine("Union OF Array Demo");

int n = 6, m = 7;
int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
int[] arr2 = new int[] { 2, 3, 4, 4, 5, 7,8};
Console.WriteLine("Array 1 values ");
foreach (int val in arr1)
    Console.Write(val + " ");
Console.WriteLine("\nArray 2 values ");
foreach (int val in arr2)
    Console.Write(val + " ");

//by third array
List<int> Union = null;
Console.WriteLine("\nUnion of arr1 and arr2 using 3rd array is ");
Union = UnionArrayDemo.findUnionByMergingint(arr1, arr2, n, m);

foreach (int val in Union)
    Console.Write(val + " ");


//by Hash set
Console.WriteLine("\nUnion of arr1 and arr2 using hash set is ");
Union = UnionArrayDemo.findUnionBYHashSet(arr1, arr2, n, m);

foreach (int val in  Union)
    Console.Write(val + " ");

Console.WriteLine("\nUnion of arr1 and arr2 using Dictionary is ");
Union = UnionArrayDemo.findUnionByDictionary(arr1, arr2, n, m);
foreach (int val in Union)
    Console.Write(val + " ");


Console.ReadLine();
