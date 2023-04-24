using System;
using System.Collections.Generic;

namespace CrudQueqe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queqe Demo");
            QueqeDemo obj=new QueqeDemo ();
            obj.InserDataToQueqe();
            obj.DisplayDataToQueqe();
            obj.PickFirstElement();

            obj.DeleteDataToQueqe();
            obj.PickFirstElement();
            obj.DisplayDataToQueqe();

            Console.ReadLine();

        }
    }

    public class QueqeDemo
    {

       Queue<int> queue;
       public void InserDataToQueqe()
        {
            queue= new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
        }
        public void DeleteDataToQueqe()
        {
           
            if (queue.Count != 0)
            {
                var temp = queue.Peek();
                queue.Dequeue();
                Console.WriteLine($"Deleted Element : {temp}");
            }
        }

        public void DisplayDataToQueqe()
        {
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void PickFirstElement()
        {
            var firstelement = queue.Peek();
            Console.WriteLine($"First element : {firstelement}");
        }
    }
}
