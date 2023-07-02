namespace ArrayPriorityOrder
{
    internal class Program
    {
        /*
         * input : int[] arr=new int[]{40,20,30,10}
         * output : {4,2,3,1} , Lower element have lower priority
         */

        public static void ArrayPriorityOrder(int[] arr)
        { 
            Array.Sort(arr);
            Dictionary<int,int> dic = new Dictionary<int,int>();
            int prioritynumber = 0;
            for(int i=0; i < arr.Length; i++)
            {
                prioritynumber++;
                dic[arr[i]] = prioritynumber;
            }

            foreach(var item in dic)
            {
                Console.Write(item.Value+" ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Array Priority Order");
            int[] arr = new int[] { 40,20,30,10};
            ArrayPriorityOrder(arr);
            Console.ReadLine();

        }
    }
}