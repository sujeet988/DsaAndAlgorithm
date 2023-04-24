// See https://aka.ms/new-console-template for more information
using ArrayisSortedOrNot;

Console.WriteLine("Is Array Sorted Demo");
int [] arr ={ 20, 21, 45, 89, 89, 90 };
int[] arr2 = { 20, 20, 78, 98, 99, 97 };
//By Loop
 Console.WriteLine(ArrayIsSortedOrNot.IsSortedByIterativeApproach(arr)); //return  true
Console.WriteLine(ArrayIsSortedOrNot.IsSortedByIterativeApproach(arr2));//return false

//By loop and stack(LIFO)
Console.WriteLine(ArrayIsSortedOrNot.IsSortedByStackApproach(arr)); //return  true
Console.WriteLine(ArrayIsSortedOrNot.IsSortedByStackApproach(arr2));//return false

