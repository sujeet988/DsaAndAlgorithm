// See https://aka.ms/new-console-template for more information
using HashSetDemo;

Console.WriteLine("Hello, World!");

int source = 10;
int result = ~source;
Console.WriteLine($"{result+1}");

HashSet<int> hashSets = new HashSet<int>();
hashSets.Add(1);
hashSets.Add(2);
hashSets.Add(3);
hashSets.Add(3);

//Count HashSets Values
Console.WriteLine(hashSets.Count);

//Check Element exists or not

if (hashSets.Contains(3)){
    Console.WriteLine("element found");
}


if (!hashSets.Contains(10)){
    Console.WriteLine("element not found");
}
//Delete Element


//Print All Elements using foeach
foreach (var item in hashSets)
{
    Console.WriteLine(item); // 1 2 3
}

//Print All Elements using for loop-not supprted

//Intersection
Console.WriteLine("IntersectionDemo");
int[] arr1 = new int[] { 89 ,24, 75, 11, 23 };
int[] arr2 = new int[] { 89, 2 ,4 };
Console.WriteLine(InterSectionofArrays.GetCountofIntersecvtion(arr1,arr2)); // ans is 1
Console.ReadLine();




