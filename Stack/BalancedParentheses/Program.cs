namespace BalancedParentheses
{
    /*
     * https://leetcode.com/problems/valid-parentheses/description/
     * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:
Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
    Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true
Example 3:

Input: s = "(]"
Output: false
     */


    public class Program
    {
        static bool isBalanced(string exp) 
        {
            if(exp == null)
            {
              return false;
            }
            Stack<char> stack = new Stack<char>();

            for( int i=0; i < exp.Length; i++)
            {
                char character = exp[i];

                if (exp[i]=='}' || exp[i]==')' || exp[i] == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    if((character=='}' &&  stack.Pop() != '{')
                      || (character == ')' && stack.Pop() != '(') || (character == ']' && stack.Pop() != '[')) 
                    {
                        return false;
                    }


                }
                else
                {
                    stack.Push(character);
                }
            }
            if( stack.Count !=0 ) {
                return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Parentheses");
            Console.WriteLine(isBalanced("{[()]}")); // true
            Console.WriteLine(isBalanced("()[]{}")); // true 
            Console.WriteLine(isBalanced("(]")); // false
            Console.ReadLine();
        }
    }
}