using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;

namespace DeleteMiddleElememntFromStacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stackdemo demo = new Stackdemo();
            var stackoutput = demo.InsertValuesInStack();
            demo.DisplayStack(stackoutput);
            var stackafterdeletedmiddle = demo.DeleteMiddleFromStack(stackoutput);
            demo.DisplayStack(stackafterdeletedmiddle);
            Console.ReadLine();
        }
    }

    class Stackdemo
    {
        Stack<int> stack = null;
        public Stack<int> InsertValuesInStack()
        {
            stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            return stack;
        }
        public void DisplayStack(Stack<int> stack)
        {
            Console.WriteLine("Dispaly Stack Start:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("End Stack :");
        }

        public Stack<int> DeleteMiddleFromStack(Stack<int> stack)
        {
            Stack<int> tempsatck = new Stack<int>();
            int midPos = (stack.Count / 2) + 1;
            int count = stack.Count;
            for(int i=1; i < count; i++)
            {
                if (i == midPos)
                {
                    stack.Pop();
                    break;

                }
                tempsatck.Push(stack.Pop());
            }

            foreach (var item in tempsatck)
            {
                stack.Push(item);
            }

            return stack;
        }


        public Stack<int> DeleteMiddleFromStackWithouspace(Stack<int> stack)
        {
            Stack<int> tempsatck = new Stack<int>();
            int midPos = (stack.Count / 2) + 1;
            //int midPos = ceil((stack.Count + 1) / 2);
            int count = stack.Count;
            for (int i = 1; i < count; i++)
            {
                if (i == midPos)
                {
                    stack.Pop();
                    break;

                }
                tempsatck.Push(stack.Pop());
               
            }

            foreach (var item in tempsatck)
            {
                stack.Push(item);
            }

            return stack;
        }
    }
}
