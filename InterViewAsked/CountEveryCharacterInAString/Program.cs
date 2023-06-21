// See https://aka.ms/new-console-template for more information

Console.WriteLine("To count the occurrences of each character in C#");
string input = "Hello, WorLd!";

string str=input.ToLower(); //l and L are different
Dictionary<char,int> dic = new Dictionary<char,int>();
foreach (char c in str)
{
    if (dic.ContainsKey(c))
    {
        dic[c] += 1;
    }
    else
    {
        dic.Add(c, 1);
    }
}

foreach(var item in dic)
{
    Console.WriteLine("count of charcater : {0} is {1}", item.Key,  item.Value);
}
Console.ReadLine();
