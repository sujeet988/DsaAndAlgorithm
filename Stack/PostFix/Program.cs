namespace PostFix
{
    /*
     * https://www.geeksforgeeks.org/problems/evaluation-of-postfix-expression1735/1
     * Given string S representing a postfix expression, the task is to evaluate the expression and find the final value.
     * Operators will only include the basic arithmetic operators like *, /, + and -.
     * Input: S = "231*+9-"
Output: -4
Explanation:
After solving the given expression, 
we have -4 as result.
     */
    internal class Program
    {
        public static int EvaluatePostfix(string S)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] =='*' || S[i] == '+' || S[i] == '-' || S[i] == '/') 
                {
                    int operand1 = stack.Pop();
                    int operand2 = stack.Pop();
                    int result = 0;

                    if(S[i] == '*') 
                    {
                        result = operand2* operand1;
                    }
                    if (S[i] == '+')
                    {
                        result = operand2 + operand1;
                    }

                    if (S[i] == '-')
                    {
                        result = operand2 - operand1;
                    }

                    if (S[i] == '/')
                    {
                        result = operand2 / operand1;
                    }
                    stack.Push(result);

                }
                else 
                {
                    stack.Push(S[i] - '0'); // converting char to int as ouput needed in int
                }


            }
            return stack.Pop();


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Post fix demo");
            string S = S = "231*+9-";
            int result = EvaluatePostfix(S);
            Console.WriteLine(result); // -4 
            Console.ReadLine();

        }
    }
}
