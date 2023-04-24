
// See https://aka.ms/new-console-template for more information
/*
 * https://leetcode.com/problems/move-zeroes/
 * https://practice.geeksforgeeks.org/problems/move-all-zeroes-to-end-of-array0751/1?utm_source=youtube&utm_medium=collab_striver_ytdescription&utm_campaign=move-all-zeroes-to-end-of-array
 */
using DsAlgo.Sujeet;
Console.WriteLine("Move all zeroes to end of array");

int[] arr = new int[] { 15 ,12 ,0 ,0 ,0 ,2, 2, 19, 6, 17, 16, 20, 0, 2, 16, 0, 10, 0, 14, 15 };
//Brute force solution
var output=PushZeroToend.PushZeroToEnd(arr);
foreach(var item in output)
{
    Console.Write(item+" ");
}

//By Two pointer approach
//optimized solution
var output1 = PushZeroToend.PushZeroToEndByTwoPointer(arr);
foreach (var item in output1)
{
    Console.Write(item + " ");
}


