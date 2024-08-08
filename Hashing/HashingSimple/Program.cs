namespace HashingSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashing Demo");
            string name = "sujeet";
            int code= name.GetHashCode(); //  system defined function
            Console.WriteLine(code);
            Console.ReadLine();
        }
    }
}