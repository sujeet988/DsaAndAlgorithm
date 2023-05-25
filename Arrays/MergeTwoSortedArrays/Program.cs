
using MergeTwoSortedArrays;
Console.WriteLine("Merge Two Sorted Arrays");
//Brute force 1
//MergeForSortedArray.mergeWithExtraSpaces();

//Brute force 2

int[] arr1 = { 1, 4, 7, 8, 10 };
int[] arr2 = { 2, 3, 9 };
Console.WriteLine("Before merge:");
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write(arr1[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}

Console.WriteLine("\n After Merge");

var output = MergeForSortedArray.mergeExtraSpacesOnTimecomplexity(arr1, arr2, arr1.Length, arr2.Length);
foreach(var item in output)
{
    Console.Write(item+" ");
}
Console.WriteLine();

//Optimized approach

Console.ReadLine();