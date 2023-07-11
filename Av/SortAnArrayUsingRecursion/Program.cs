namespace SortAnArrayUsingRecursion
{
    public class Program
    {
        public static void Sort(List<int> array)
        {
            if (array.Count == 1)
            {
                return;
            }

            int temp= array[array.Count-1];
            array.RemoveAt(array.Count-1);
            Sort(array);
            Insert(array,temp);
        }


        public static void Insert(List<int> array, int temp)
        {
            if(array.Count==0 || array[array.Count - 1] <= temp)
            {
                array.Add(temp);
                return;
            }
            int val= array[array.Count-1];
            array.RemoveAt(array.Count - 1);
            Insert(array, temp);
            array.Add(val);
          
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sort An Array Using Recursion");
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(5);
            list.Add(0);
            list.Add(2);
            Sort(list);
            foreach(var item in list)
            {
                Console.WriteLine($"{item.ToString()}");
            }

            Console.ReadLine();
        }
    }
}