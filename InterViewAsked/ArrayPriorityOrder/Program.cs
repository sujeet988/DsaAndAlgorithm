namespace ArrayPriorityOrder
{
    internal class Program
    {
        /*
         * input : int[] arr=new int[]{40,20,30,10}
         * output : {4,2,3,1} , Lower element have lower priority
         */

        public static int[]  ArrayPriorityOrder(int[] arr)
        {
            int[] temp = new int[arr.Length];
            arr.CopyTo(temp, 0);

            Array.Sort(arr);
            Dictionary<int,int> dic = new Dictionary<int,int>();
            int prioritynumber = 0;
            for(int i=0; i < arr.Length; i++)
            {
                prioritynumber++;
                dic[arr[i]] = prioritynumber;
            }

            int[] arrouput = new int[arr.Length];

            for(int i=0; i < temp.Length; i++)
            {
                arrouput[i] = dic[temp[i]];
            }
            return arrouput;

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Array Priority Order");
            int[] arr = new int[] { 40,20,30,10};
            var output=ArrayPriorityOrder(arr);
            foreach(var item in output)
            {
                Console.Write(item +" ");
            }
            //ouput  4 2 3 1
            Console.ReadLine();

        }
    }
}