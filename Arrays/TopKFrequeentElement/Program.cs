// See https://aka.ms/new-console-template for more information

/*
 * https://leetcode.com/problems/top-k-frequent-elements/
 * https://practice.geeksforgeeks.org/problems/top-k-frequent-elements-in-array/1
 */

using TopKFrequeentElement;
Console.WriteLine("Top K frequent Element");

int[] nums = new int[6] { 1, 1, 1, 2, 2, 3 };
int K = 2;
var output= TopKFreqElementsdata.TopKFreuentElement(nums, K);
foreach(var item in output)
{
    Console.Write(item+" ");
}
// ouput 1, 2 
Console.ReadLine();

