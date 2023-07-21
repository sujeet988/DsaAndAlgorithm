namespace DsaAndAlgorithm.InterViewAsked.BinearySearchComplexType
{
    internal class Program
    {
        public class OrderDetails
        {
            public List<int> OrderIds;
            public DateTime OrderDate { get; set; }
        }

       

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Complex type demo");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(10);
            list.Add(5);
            list.Add(50);
            list.Add(40);
            Console.WriteLine("Enter Element to Search");
            int n=Convert.ToInt32(Console.ReadLine());

           int output= list.BinarySearch(n);
            

            Console.ReadLine();

        }
    }
}