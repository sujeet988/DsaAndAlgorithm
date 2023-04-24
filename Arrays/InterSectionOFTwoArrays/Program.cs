// See https://aka.ms/new-console-template for more information
using InterSectionOfTwoSortedArrays;
/*
*  Find the intersection of two sorted arrays. OR in other words, Given 2 sorted arrays, find all the elements which occur in both the arrays.
*  Input: 
A: [1 2 3 3 4 5 6]
, B: [3 3 5]
Output: 3,3,5
Explanation: We are given two arrays A and B. 
The elements present in both the arrays  
are 3,3 and 5.
https://www.codingninjas.com/codestudio/problems/intersection-of-2-arrays_1082149?utm_source=youtube&utm_medium=affiliate&utm_campaign=striver_Arrayproblems
  https://www.geeksforgeeks.org/union-and-intersection-of-two-sorted-arrays-2/
https://takeuforward.org/data-structure/intersection-of-two-sorted-arrays/
*/

Console.WriteLine("InterSection of Two Sorted Arrays");

// Array Initialisation.
int[] A = { 1, 2, 3, 3, 4, 5, 6, 7 };
int[] B = { 3, 3, 4, 4, 5, 8 };
List<int> ans = null;

Console.WriteLine("InterSection of Two Sorted Arrays using brute force");
ans = InterSectionOfTwoSortedArray.intersectionOfArrays(A, B);
for (int i = 0; i < ans.Count; i++)
{
    Console.Write(ans[i]+" ");
}
//ans : 3 3 4 5
Console.WriteLine();
Console.WriteLine("InterSection of Two Sorted Arrays using two pointer");
ans = InterSectionOfTwoSortedArray.intersectionOfArraysByTwoPointer(A, B);

for (int i = 0; i < ans.Count; i++)
{
    Console.Write(ans[i] + " ");
}

Console.ReadLine();
