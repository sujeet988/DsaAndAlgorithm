namespace DsaAndAlgorithm.Av.DeleteMiddleElementOfStack
{
    internal class Program
    {
        public static void DeleteMiddleElementOfStack(Stack<int> stack, int mid)
        {
            if (stack.Count == mid)
            {
                stack.Pop();
                return;
            }
            int temp= stack.Pop();
            DeleteMiddleElementOfStack(stack, mid);
            stack.Push(temp);

        }

        public static void DeleteMiddleElementOfStack2(Stack<int> stack, int mid)
        {
            if (mid==1)
            {
                stack.Pop();
                return;
            }
            int temp = stack.Pop();
            DeleteMiddleElementOfStack2(stack, mid-1);
            stack.Push(temp);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Delete Middle Element Of Stack");
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }

            ////Console.WriteLine("After Delete Middle Element");
            //////aproach 1
            ////int mid = (stack.Count / 2) + 1;
            ////DeleteMiddleElementOfStack(stack, mid);
            ////foreach (int i in stack)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //////output 5421

            //aproach 2
            Console.WriteLine("After Delete Middle Element");

            int mid = (stack.Count / 2) + 1;
            DeleteMiddleElementOfStack2(stack, mid);
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            //output 5421
            Console.ReadLine();
            
        }


    }
}