
using SecondLargestElementInArray;
using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;

/*
 * Input:
N = 6
Arr[] = { 12, 35, 1, 10, 34, 1}
Output: 34
Explanation: The largest element of the 
array is 35 and the second largest element
is 34.
https://practice.geeksforgeeks.org/problems/second-largest3735/1
 */
int[] arr = new int[] { 12, 35, 1, 10, 34, 1 };

Console.WriteLine("Find 2nd Largest Element in array");

int n= SecondMaxElement.SecoondLargetElement(arr);
Console.WriteLine(n); //34 ans
Console.ReadLine();



