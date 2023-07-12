namespace DsaAndAlgorithm.Av.ReverseAStackUsingRecursion
{
    internal class Program
    {

        public static void ReverseAStack(Stack<int> stack)
        {
            // base condition
            if (stack.Count == 0)
            {
                return;
            }
            // hypothesis
            int temp =stack.Peek();
            stack.Pop();
            ReverseAStack(stack);
            // induction
            insert(stack, temp);
        }

        private static void insert(Stack<int> stack, int temp)
        {
            if (stack.Count==0)
            {
                stack.Push(temp);
                return;
            }

            int val = stack.Pop();
            insert(stack, temp);
            stack.Push(val);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Reverse A Stack Using Recursion");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            //Reverse stack
            ReverseAStack(stack);
            Console.WriteLine("After Reverse stack");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}