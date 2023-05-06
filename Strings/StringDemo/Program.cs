// See https://aka.ms/new-console-template for more information
using AnargramOfString;

string s1 = "aabca";
string s2 = "acaba";
Console.WriteLine("String first "+s1);
Console.WriteLine("String first " + s2);
bool isanagram = CheckStringISAnargram.isAnagram(s1, s2);
Console.WriteLine("Is String is Anagram : " +isanagram);

Console.ReadLine();