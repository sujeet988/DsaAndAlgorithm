// See https://aka.ms/new-console-template for more information
using AnargramOfString;

string s1 = "aabca";
string s2 = "acaba";

bool isanagram = CheckStringISAnargram.isAnagram(s1, s2);
Console.WriteLine(isanagram);

String[] strings = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };

var output= CheckStringISAnargram.GroupAnagrams(strings);


Console.ReadLine();